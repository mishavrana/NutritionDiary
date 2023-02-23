using NutritionDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionDiary.ViewModels
{
    public class WeekViewModel: ViewModelBase 
    {
        private readonly Week _week;
        public string Product => _week.Product;
        public string DateNow = DateTime.Now.ToString();
        public string Id => _week.Id;

        public WeekViewModel(Week week)
        {
            _week = week;
        }

    }
}
