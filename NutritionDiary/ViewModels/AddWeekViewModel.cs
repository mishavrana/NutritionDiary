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
                _numberOfWeek= value;   
                OnPropertyChanged(nameof(NumberOfWeek));    
            }
        }

        public ICommand AddProduct { get; }
        public ICommand Cancel { get; }

    }
}
