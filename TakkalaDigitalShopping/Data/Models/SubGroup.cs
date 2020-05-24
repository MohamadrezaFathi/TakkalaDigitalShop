using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakkalaDigitalShopping.Data.Models
{
    public class SubGroup
    {
        public int SubGroupID { get; set; }
        public string SubGroupName { get; set; }
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }
        public List<Product> Products { get; set; }
    }
}
