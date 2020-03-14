using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_meal.Models
{
    public class EDay
    {
        public int Id { get; set; }
        public string day { get; set; }
        
        public int userId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
