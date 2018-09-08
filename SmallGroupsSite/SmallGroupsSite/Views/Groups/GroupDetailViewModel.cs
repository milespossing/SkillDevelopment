using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmallGroupsSite.Models;

namespace SmallGroupsSite.Views.Groups
{
    public class GroupDetailViewModel
    {
        public Group Group;
        public SmallGroupsSiteContext Context;

        public GroupDetailViewModel(Group group)
        {
            Group = group;
        }
    }
}
