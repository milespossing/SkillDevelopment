﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallGroupsSite.Models
{
    public class PersonAddress : Address
    {
        public int ID { get; set; }

        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}
