using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DisplayName("Address")]
        public PersonAddress PersonAddress { get; set; }
        public virtual ICollection<GroupMembership> GroupMemberships { get; set; }

        // Views
        public string FullName => $"{FirstName} {LastName}";
    }
}
