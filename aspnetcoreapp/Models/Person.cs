using System;
using System.Collections.Generic;

namespace aspnetcoreapp.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }

        public virtual List<GroupLeadership> GroupLeaderships { get; set; }
        public virtual List<GroupMembership> GroupMemberships { get; set; }
    }
}