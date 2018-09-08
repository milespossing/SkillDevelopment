using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public enum MembershipType
    {
        Member,
        Leader
    }

    public class GroupMembership
    {
        public int ID { get; set; }
        public MembershipType MembershipType { get; set; }
        
        public int GroupID { get; set; }
        public Group Group { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
