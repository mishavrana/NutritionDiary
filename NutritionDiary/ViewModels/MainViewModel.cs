using NutritionDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionDiary.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Diary diary) 
        {
            CurrentViewModel = new AddWeekViewModel(diary);
        }  
    }
}
