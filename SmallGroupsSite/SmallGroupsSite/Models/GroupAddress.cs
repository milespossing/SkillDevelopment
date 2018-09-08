using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public class GroupAddress : Address
    {
        public int ID { get; set; } 

        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
