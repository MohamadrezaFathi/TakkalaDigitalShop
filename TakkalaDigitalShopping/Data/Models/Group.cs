using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakkalaDigitalShopping.Data.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public List<SubGroup> SubGroups { get; set; }
    }
}
