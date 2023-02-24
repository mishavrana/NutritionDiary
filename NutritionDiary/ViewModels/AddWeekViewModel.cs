using NutritionDiary.Commands;
using NutritionDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NutritionDiary.ViewModels
{
    internal class AddWeekViewModel: ViewModelBase
    {

        public DateTime StartDate => DateTime.Now;
        public DateTime EndDate => DateTime.Now.AddDays(5);

        private string _newProduct;
        public string NewProduct
        {
            get { return _newProduct; }
            set
            {
                _newProduct = value;
                OnPropertyChanged(nameof(NewProduct));
            }
        }

        private string _numberOfWeek; 
        public string NumberOfWeek
        {
            get { return _numberOfWeek; }
            set
            {
                _numberOfWeek = value;
                OnPropertyChanged(nameof(NumberOfWeek));
            }
        }

        public ICommand StartNewWeek { get; }
        public ICommand Cancel { get; }

        public AddWeekViewModel(Diary diary)
        {
            StartNewWeek = new StartNewWeekCommand(this, diary);
            Cancel = new CancelStartNewWeekCommand();
        }

    }
}
