using System;

namespace aspnetcoreapp.Models
{
    public class GroupMembership
    {
        public int ID { get; set; }
        public DateTime DateJoined { get; set; }

        public virtual Person Person { get; set; }
        public virtual Group Group { get; set; }
    }
}