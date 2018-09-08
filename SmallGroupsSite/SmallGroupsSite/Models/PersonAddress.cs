using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public class PersonAddress
    {
        public int ID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public int PersonID { get; set; }
        public virtual Person Person { get; set; }

        public override string ToString()
        {
            string output = "";
            if (Line1 != null) output += Line1 + " ";
            if (Line2 != null) output += Line2 + " ";
            if (City != null) output += City + " ";
            if (State != null) output += State + " ";
            if (ZipCode != 0) output += ZipCode;
            return output;
        }
    }
}
