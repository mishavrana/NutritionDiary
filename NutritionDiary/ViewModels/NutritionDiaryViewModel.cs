using NutritionDiary.Commands;
using NutritionDiary.Models;
using NutritionDiary.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NutritionDiary.ViewModels
{
    public class NutritionDiaryViewModel : ViewModelBase
    {
        private readonly ObservableCollection<WeekViewModel> _weeks;
        private readonly Diary _diary;
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

        public NutritionDiaryViewModel(NavigationStore navigationStore, Diary diary)
        {
            _weeks = new ObservableCollection<WeekViewModel>();
            _diary = diary;
            AddNewWeek = new AddNewWeekCommand(navigationStore, diary);
            UpdateWeeks();
        }

        private void UpdateWeeks()
        {
            _weeks.Clear();
            foreach(var week in _diary.Weeks)
            {
                WeekViewModel weekViewModel = new WeekViewModel(week);
                _weeks.Add(weekViewModel);
            }
        }

    }
}
 