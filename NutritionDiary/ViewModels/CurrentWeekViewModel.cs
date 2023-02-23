using NutritionDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ICommand Good { get; }
        public ICommand Bad { get; }
    }
}
