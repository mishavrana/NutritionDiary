using NutritionDiary.Commands;
using NutritionDiary.Models;
using NutritionDiary.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NutritionDiary.ViewModels
{
    public class CurrentWeekViewModel: ViewModelBase
    {
        private IDictionary<DateTime, Reaction> _daysAndReactions;
        public IDictionary<DateTime, Reaction> DaysAndReactions
        {
            get { return _daysAndReactions; }
        }

        private string _currentWeekNumber;
        public string CurrentWeekNumber
        {
            get { return _currentWeekNumber; }
            set
            {
                _currentWeekNumber = value;
                OnPropertyChanged(nameof(CurrentWeekNumber));
            }
        }

        private string _currentProduct;
        public string CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                _currentProduct = value;
                OnPropertyChanged(nameof(CurrentProduct));
            }
        }

        public string CurrentDate => DateTime.Now.ToString();

        public ICommand GoodReaction { get; }
        public ICommand BadReaction { get; }
        public ICommand Done { get; }  
        public CurrentWeekViewModel(NavigationStore navigationStore, Diary diary, Week week)
        {
            GoodReaction = new GoodReactionCommand();
            BadReaction = new BadReactionCommand();
            Done = new DoneCommand(navigationStore, diary);

            _currentWeekNumber = week.Id;
            _currentProduct = week.Product;
            _daysAndReactions= new Dictionary<DateTime, Reaction>();   
        }
    }
}
