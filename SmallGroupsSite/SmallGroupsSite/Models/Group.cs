using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public virtual GroupAddress Address { get; set; }
    }
}
