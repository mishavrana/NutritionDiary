using NutritionDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NutritionDiary.ViewModels
{
    internal class NutritionDiaryViewModel : ViewModelBase
    {
        private readonly ObservableCollection<WeekViewModel> _weeks;

        private List<string> _startAndEndDays = new List<string>();
        public List<string> StartAndEndDays
        {
            get { return _startAndEndDays; }
        }

        private List<string> _allowedProducts = new List<string>();
        public List<string> AllowedProducts
        {
            get { return _allowedProducts; }
        }
 
        private List<string> _bannedProducts = new List<string>();
        public List<string> BannedProducts
        {
            get { return _bannedProducts; }
        }

        public ICommand NewWeekCommand { get; }

        public NutritionDiaryViewModel()
        {
            _weeks = new ObservableCollection<WeekViewModel>();
            _weeks.Add(new WeekViewModel(new Week(DateTime.Now, DateTime.Now.AddDays(5), "Potato")));

            foreach (WeekViewModel week in _weeks)
            {
                _startAndEndDays.Add(week.Id);
            }
            AllowedProducts.Add("Apple");
            AllowedProducts.Add("Carrot");
        }

    }
}
