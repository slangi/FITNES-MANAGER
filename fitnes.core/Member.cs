using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public abstract class Member : IPriceCalculable, IDisplayable
    {
        public int Id { get; }
        public string Name { get; set; }
        public Membership Membership { get; set; }

        private static int _memberCount = 0;

        protected Member(int id, string name, Membership membership)
        {
            Id = id;
            Name = name;
            Membership = membership;
            _memberCount++;
        }

        public static int GetMemberCount()
        {
            return _memberCount;
        }

        public virtual bool HasActiveMembership()
        {
            return Membership != null && Membership.IsActive();
        }

        public abstract decimal CalculateFinalPrice();

        public abstract string MemberType { get; }

        public virtual string GetDisplayInfo()
        {
            if (Membership == null)
            {
                return $"Ime: {Name}\nTip: {MemberType}\nČlanstvo ni dodeljeno.";
            }

            return
                $"Ime: {Name}\n" +
                $"Tip člana: {MemberType}\n" +
                $"Aktivno članstvo: {(HasActiveMembership() ? "Da" : "Ne")}\n" +
                $"Cena: {Membership.Price:F2}\n" +
                $"Končna cena: {CalculateFinalPrice():F2}\n" +
                $"Velja do: {Membership.GetExpirationDate():dd.MM.yyyy}\n" +
                $"Trajanje (dni): {Membership.DurationDays}\n" +
                $"DDV (VAT): {Membership.VAT * 100}%";
        }

        public override string ToString()
        {
            return $"{Name} ({MemberType})";
        }
    }
}
