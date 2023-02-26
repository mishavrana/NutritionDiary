using NutritionDiary.Comands;
using NutritionDiary.Models;
using NutritionDiary.Stores;
using NutritionDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace NutritionDiary.Commands
{
    public class AddNewWeekCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Diary _diary;
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new AddWeekViewModel(_diary, _navigationStore);
        }

        public AddNewWeekCommand(NavigationStore navigationStore, Diary diary)
        {
            _navigationStore= navigationStore;
            _diary = diary;
        }
    }
}
