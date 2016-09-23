using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataContainer.Models
{
    public class Address
    {
        public int ID { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        //Foreign Key
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
