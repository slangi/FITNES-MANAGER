using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public delegate void MemberAddedHandler(Member member);
    public delegate void NotificationHandler(string message);
    public delegate bool MemberFilter(Member member);
}
