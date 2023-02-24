using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionDiary.Models
{
    public class Week
    {
        public string Id => $"{StartDate.ToString()} - {EndDate.ToString()}";  
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public IDictionary<DateTime, Reaction> DaysAndReactions { get; set; }
        public string? Product { get; set; }

        public Week(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
            DaysAndReactions = new Dictionary<DateTime, Reaction>();
        }
    }
}
