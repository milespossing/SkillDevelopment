using System.Collections.Generic;

namespace aspnetcoreapp.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string DayOfWeek { get; set; }

        public virtual List<GroupLeadership> GroupLeaderships { get; set; }
        public virtual List<GroupMembership> GroupMemberships { get; set; }
    }
}