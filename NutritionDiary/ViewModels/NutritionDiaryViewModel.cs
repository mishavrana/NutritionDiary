using NutritionDiary.Commands;
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
        public IEnumerable<WeekViewModel> Weeks => _weeks;

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

        public ICommand AddNewWeek { get; }

        public NutritionDiaryViewModel(Diary diary)
        {
            _weeks = new ObservableCollection<WeekViewModel>();
        }

    }
}
