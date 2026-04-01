using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace fitnes.manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpIInput = new GroupBox();
            btnAdd = new Button();
            cmbDiscount = new ComboBox();
            lblDiscount = new Label();
            cmbType = new ComboBox();
            lblType = new Label();
            nudDuration = new NumericUpDown();
            lblDuration = new Label();
            nudPrice = new NumericUpDown();
            lblPrice = new Label();
            txtName = new TextBox();
            lblName = new Label();
            grpMembers = new GroupBox();
            lstMembers = new ListBox();
            grpDetails = new GroupBox();
            lblMemberCount = new Label();
            lblInfo = new Label();
            grpIInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            grpMembers.SuspendLayout();
            grpDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpIInput
            // 
            grpIInput.Controls.Add(btnAdd);
            grpIInput.Controls.Add(cmbDiscount);
            grpIInput.Controls.Add(lblDiscount);
            grpIInput.Controls.Add(cmbType);
            grpIInput.Controls.Add(lblType);
            grpIInput.Controls.Add(nudDuration);
            grpIInput.Controls.Add(lblDuration);
            grpIInput.Controls.Add(nudPrice);
            grpIInput.Controls.Add(lblPrice);
            grpIInput.Controls.Add(txtName);
            grpIInput.Controls.Add(lblName);
            grpIInput.Location = new Point(29, 24);
            grpIInput.Margin = new Padding(4, 4, 4, 4);
            grpIInput.Name = "grpIInput";
            grpIInput.Padding = new Padding(4, 4, 4, 4);
            grpIInput.Size = new Size(429, 504);
            grpIInput.TabIndex = 0;
            grpIInput.TabStop = false;
            grpIInput.Text = "Vnos člana";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.Location = new Point(101, 412);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 48);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Dodaj člana";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbDiscount
            // 
            cmbDiscount.Enabled = false;
            cmbDiscount.Font = new Font("Segoe UI", 11.25F);
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "10%", "20%", "30%" });
            cmbDiscount.Location = new Point(163, 327);
            cmbDiscount.Margin = new Padding(4, 4, 4, 4);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(228, 28);
            cmbDiscount.TabIndex = 9;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            lblDiscount.Location = new Point(23, 337);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 18);
            lblDiscount.TabIndex = 8;
            lblDiscount.Text = "Popust:";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 11.25F);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Navaden", "Premium" });
            cmbType.Location = new Point(163, 247);
            cmbType.Margin = new Padding(4, 4, 4, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(228, 28);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ImageAlign = ContentAlignment.MiddleLeft;
            lblType.Location = new Point(23, 257);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(85, 18);
            lblType.TabIndex = 6;
            lblType.Text = "Tip člana:";
            // 
            // nudDuration
            // 
            nudDuration.Font = new Font("Segoe UI", 11.25F);
            nudDuration.Location = new Point(163, 170);
            nudDuration.Margin = new Padding(6, 5, 6, 5);
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(228, 27);
            nudDuration.TabIndex = 5;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.ImageAlign = ContentAlignment.MiddleLeft;
            lblDuration.Location = new Point(20, 179);
            lblDuration.Margin = new Padding(4, 0, 4, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(122, 18);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Trajanje (dni):";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Segoe UI", 11.25F);
            nudPrice.Location = new Point(163, 99);
            nudPrice.Margin = new Padding(6, 5, 6, 5);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(228, 27);
            nudPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(21, 108);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(119, 18);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Cena članstva:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F);
            txtName.Location = new Point(163, 35);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 27);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 38);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Ime člana:";
            // 
            // grpMembers
            // 
            grpMembers.Controls.Add(lstMembers);
            grpMembers.Location = new Point(486, 24);
            grpMembers.Margin = new Padding(4, 4, 4, 4);
            grpMembers.Name = "grpMembers";
            grpMembers.Padding = new Padding(4, 4, 4, 4);
            grpMembers.Size = new Size(357, 504);
            grpMembers.TabIndex = 1;
            grpMembers.TabStop = false;
            grpMembers.Text = "Seznam članov";
            // 
            // lstMembers
            // 
            lstMembers.BackColor = Color.White;
            lstMembers.Font = new Font("Segoe UI", 11.25F);
            lstMembers.FormattingEnabled = true;
            lstMembers.ItemHeight = 20;
            lstMembers.Location = new Point(21, 28);
            lstMembers.Margin = new Padding(4, 4, 4, 4);
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(301, 444);
            lstMembers.TabIndex = 0;
            lstMembers.SelectedIndexChanged += lstMembers_SelectedIndexChanged_1;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblMemberCount);
            grpDetails.Controls.Add(lblInfo);
            grpDetails.Location = new Point(871, 24);
            grpDetails.Margin = new Padding(4, 4, 4, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(4, 4, 4, 4);
            grpDetails.Size = new Size(371, 504);
            grpDetails.TabIndex = 2;
            grpDetails.TabStop = false;
            grpDetails.Text = "Podrobnosti";
            // 
            // lblMemberCount
            // 
            lblMemberCount.AutoSize = true;
            lblMemberCount.Location = new Point(20, 412);
            lblMemberCount.Margin = new Padding(4, 0, 4, 0);
            lblMemberCount.Name = "lblMemberCount";
            lblMemberCount.Size = new Size(53, 18);
            lblMemberCount.TabIndex = 1;
            lblMemberCount.Text = "label1";
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.White;
            lblInfo.Font = new Font("Segoe UI", 11.25F);
            lblInfo.Location = new Point(20, 28);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(343, 360);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1263, 553);
            Controls.Add(grpDetails);
            Controls.Add(grpMembers);
            Controls.Add(grpIInput);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness Membership Manager";
            Load += Form1_Load;
            grpIInput.ResumeLayout(false);
            grpIInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            grpMembers.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpIInput;
        private Label lblPrice;
        private TextBox txtName;
        private Label lblName;
        private NumericUpDown nudDuration;
        private Label lblDuration;
        private NumericUpDown nudPrice;
        private Label lblType;
        private Button btnAdd;
        private ComboBox cmbDiscount;
        private Label lblDiscount;
        private ComboBox cmbType;
        private GroupBox grpMembers;
        private ListBox lstMembers;
        private GroupBox grpDetails;
        private Label lblInfo;
        private Label lblMemberCount;
    }
}
