using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public class PremiumMember : Member
    {
        public DiscountLevel Discount { get; set; }
        public bool VipAccess { get; set; }

        public PremiumMember(int id, string name, Membership membership,
                             DiscountLevel discount, bool vipAccess)
            : base(id, name, membership)
        {
            Discount = discount;
            VipAccess = vipAccess;
        }

        public override string MemberType => "Premium";

        public override bool HasActiveMembership()
        {
            if (Membership == null)
                return false;

            return DateTime.Now <= Membership.GetExpirationDate().AddDays(7);
        }

        public decimal GetDiscountedPrice()
        {
            if (Membership == null)
                return 0m;

            return Membership.Price * (1 - (decimal)Discount / 100m);
        }

        public override decimal CalculateFinalPrice()
        {
            return GetDiscountedPrice();
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() +
                   $"\nPopust: {(int)Discount}%\n" +
                   $"Cena s popustom: {GetDiscountedPrice():F2}\n" +
                   $"VIP dostop: {(VipAccess ? "Da" : "Ne")}";
        }
    }
}
