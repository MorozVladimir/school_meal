using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_meal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string pupilName { get; set; }
        public string pupilGrade { get; set; }
        public string role;
        public decimal totalPrepayment { get; set; }
        public decimal totalBalance { get; set; }
        public virtual List<EDay> eDays { get; set; }
        
    }

}
