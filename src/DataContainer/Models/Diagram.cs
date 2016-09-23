using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataContainer.Models
{
    public class Diagram
    {
        public int ID { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string DiagramXML { get; set; }

        public int Effective_week { get; set; }

        public DateTime Added_date { get; set; }

        //Foreign Key
        public virtual Branch Branch { get; set; }
    }
}
