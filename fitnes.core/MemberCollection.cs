using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public class MemberCollection : IEnumerable<Member>
    {
        private readonly List<Member> _members = new List<Member>();

        public int Count => _members.Count;

        public Member this[int index]
        {
            get => _members[index];
            set => _members[index] = value;
        }

        public Member this[string name]
        {
            get => _members.FirstOrDefault(m =>
                m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void Add(Member member)
        {
            _members.Add(member);
        }

        public IEnumerator<Member> GetEnumerator()
        {
            return _members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
