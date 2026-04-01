using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public class MemberManager
    {
        public MemberCollection Members { get; } = new MemberCollection();

        public event MemberAddedHandler MemberAdded;
        public event NotificationHandler NotificationRaised;

        public void AddMember(Member member)
        {
            Members.Add(member);

            MemberAdded?.Invoke(member);
            NotificationRaised?.Invoke($"Dodan član: {member.Name}");
        }

        public List<Member> FilterMembers(MemberFilter filter)
        {
            List<Member> result = new List<Member>();

            foreach (Member member in Members)
            {
                if (filter(member))
                {
                    result.Add(member);
                }
            }

            return result;
        }

        public void CheckExpiringMemberships(int days)
        {
            foreach (Member member in Members)
            {
                if (member.Membership != null &&
                    member.Membership.GetExpirationDate() <= DateTime.Now.AddDays(days))
                {
                    NotificationRaised?.Invoke(
                        $"Član {member.Name} ima članstvo do {member.Membership.GetExpirationDate():dd.MM.yyyy}");
                }
            }
        }
    }
}
