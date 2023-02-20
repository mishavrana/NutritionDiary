using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NutritionDiary.Models
{
    public class Diary
    {
        private List<Week> _weeks;
        private List<String> _allowedProducts; 
        private List<String> _bannedProducts;

        public Diary() 
        { 
            _weeks= new List<Week>();
            _allowedProducts= new List<String>();
            _bannedProducts= new List<String>();
        }

        // Adding a weeek
        public void AddNote(DateTime startDate, DateTime endDate, string product)
        {
            Week week = new Week(startDate, endDate, product);
            _weeks.Add(week);
        }

        // Deleting a week
        public void DeleteNote (DateTime id)
        {
            foreach (Week note in _weeks)
            {
                _weeks.Where(note => note.Id == id.ToString());
            }
        }
    }
}
