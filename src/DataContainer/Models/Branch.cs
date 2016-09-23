using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataContainer.Models
{
    public class Branch
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        //Foreign Key
        public virtual Address Address { get; set; }
        public virtual ICollection<Diagram> Diagrams { get; set; }
    }
}
