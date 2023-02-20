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
        private readonly ObservableCollection
        private List<Week> _weeks = new List<Week>();
        public List<Week> Weeks
        {
            get { return _weeks; }
            set
            {
                _weeks = value;
                OnPropertyChanged(nameof(Weeks));
            }
        }

        private List<string> _allowedProducts = new List<string>();
        public List<string> AllowedProducts
        {
            get { return _allowedProducts; }
            set
            {
                _allowedProducts = value;
                OnPropertyChanged(nameof(AllowedProducts));
            }
        }
 
        private List<string> _bannedProducts = new List<string>();
        public List<string> BannedProducts
        {
            get { return _bannedProducts; }
            set
            {
                _bannedProducts = value;
                OnPropertyChanged(nameof(BannedProducts));
            }
        }

        public ICommand NewWeekCommand { get; }

        public NutritionDiaryViewModel()
        {

        }

    }
}
