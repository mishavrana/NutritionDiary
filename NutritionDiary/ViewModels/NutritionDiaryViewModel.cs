using NutritionDiary.Commands;
using NutritionDiary.Models;
using NutritionDiary.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace NutritionDiary.ViewModels
{
    public class NutritionDiaryViewModel : ViewModelBase
    {
        private readonly ObservableCollection<WeekViewModel> _weeks;
        private readonly Diary _diary;
        private readonly NavigationStore _navigationStore;
        public IEnumerable<String> Weeks
        {
            get
            {
                List<String> weeksInStringRrpresantable = new List<String>();
                foreach (var week in _weeks)
                {
                    weeksInStringRrpresantable.Add($"{week.StartDate.ToString("d")}-{week.EndDate.ToString("d")}: {week.Product}");
                }
                return weeksInStringRrpresantable;
            }
        }

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

        private String _selectedItem;
        public String SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
                //SelectWeek.Execute();
                
            }
        }

        public ICommand AddNewWeek { get; }
        public ICommand SelectWeek { get; }

        public NutritionDiaryViewModel(NavigationStore navigationStore, Diary diary)
        {
            _weeks = new ObservableCollection<WeekViewModel>();
            _navigationStore= navigationStore;  
            _diary = diary;
            AddNewWeek = new AddNewWeekCommand(navigationStore, diary);
            SelectWeek = new SelectWeekCommand(navigationStore, diary, SelectedItem); 
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
 