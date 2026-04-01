using fitnes.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fitnes.manager
{
    public partial class Form1 : Form
    {
        private readonly MemberManager manager = new MemberManager();
        private int idCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager.MemberAdded += Manager_MemberAdded;
            manager.NotificationRaised += Manager_NotificationRaised;

            cmbType.Items.Clear();
            cmbType.Items.Add("Navaden");
            cmbType.Items.Add("Premium");
            cmbType.SelectedIndex = 0;

            cmbDiscount.Items.Clear();
            cmbDiscount.Items.Add(10);
            cmbDiscount.Items.Add(20);
            cmbDiscount.Items.Add(30);
            cmbDiscount.SelectedIndex = 0;
            cmbDiscount.Enabled = false;

            lblInfo.Text = "";
            UpdateMemberCountLabel();
        }

        private void Manager_MemberAdded(Member member)
        {
            lstMembers.Items.Add(member.ToString());
            UpdateMemberCountLabel();
        }

        private void Manager_NotificationRaised(string message)
        {
            Text = $"Fitness Membership Manager - {message}";
        }

        private void UpdateMemberCountLabel()
        {
            int premiumCount = manager.FilterMembers(m => m is PremiumMember).Count;
            lblMemberCount.Text = $"Število članov: {Member.GetMemberCount()} | Premium: {premiumCount}";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDiscount.Enabled = cmbType.SelectedIndex == 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string memberName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(memberName))
            {
                MessageBox.Show("Vnesi ime člana!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (manager.Members[memberName] != null)
            {
                MessageBox.Show("Član s tem imenom že obstaja!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Membership membership = new Membership(
                nudPrice.Value,
                (int)nudDuration.Value,
                DateTime.Now
            );

            Member member;

            if (cmbType.SelectedIndex == 1)
            {
                if (cmbDiscount.SelectedItem == null)
                {
                    MessageBox.Show("Izberi veljaven popust!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int discount = Convert.ToInt32(cmbDiscount.SelectedItem);

                member = new PremiumMember(
                    idCounter++,
                    memberName,
                    membership,
                    (DiscountLevel)discount,
                    true
                );
            }
            else
            {
                member = new StandardMember(
                    idCounter++,
                    memberName,
                    membership
                );
            }

            manager.AddMember(member);
            manager.CheckExpiringMemberships(1);

            txtName.Clear();
            nudPrice.Value = nudPrice.Minimum;
            nudDuration.Value = nudDuration.Minimum;
            cmbType.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
            cmbDiscount.Enabled = false;
        }

        private void lstMembers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstMembers.SelectedIndex < 0)
            {
                lblInfo.Text = "";
                return;
            }

            Member member = manager.Members[lstMembers.SelectedIndex];
            lblInfo.Text = member.GetDisplayInfo();
            UpdateMemberCountLabel();
        }
    }
}
