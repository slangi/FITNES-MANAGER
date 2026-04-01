using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public class StandardMember : Member
    {
        public StandardMember(int id, string name, Membership membership)
            : base(id, name, membership)
        {
        }

        public override string MemberType => "Navaden";

        public override decimal CalculateFinalPrice()
        {
            return Membership?.Price ?? 0m;
        }
    }
}
