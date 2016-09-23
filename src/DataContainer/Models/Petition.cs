using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataContainer.Models
{
    public class Petition
    {
        public int ID { get; set; }

        public string Content { get; set; }

        public DateTime When_folded { get; set; }

        public DateTime When_applied { get; set; }

        //Foreign Key
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
