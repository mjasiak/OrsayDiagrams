using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataContainer.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //Foreign Key
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Petition> Petitions { get; set; }
    }
}
