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
        public string Product { get; set; }

        // If there is at least one bad reaction on the product it returns "Bad", otherwise the reaction is "Good"
        // It sets the reaction to the current date in the "DaysAndReactions" list
        public string Reaction
        {
            get 
            {
                foreach(Reaction reaction in DaysAndReactions.Values)
                {
                    if(reaction == Models.Reaction.Bad)
                        return ("Bad");
                    else
                        return ("Good");
                }
                return "Undefined";
            }
            set
            {
                Reaction reaction = Models.Reaction.Undifined;

                if(value == "Good")
                    reaction = Models.Reaction.Good;
                else 
                    reaction = Models.Reaction.Bad; 

                DaysAndReactions[DateTime.Now] = reaction;
            }
        }

        public Week(DateTime startDate, DateTime endDate, string product)
        {
            StartDate = startDate;
            EndDate = endDate;
            DaysAndReactions = new Dictionary<DateTime, Reaction>();
            Product = product;
        }
    }
}
