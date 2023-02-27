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
    class SelectWeekCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Diary _diary;
        private readonly String _weekId;

        private Week Week
        {
            get
            {
                return _diary.Weeks.Where(s => s.Id == _weekId).FirstOrDefault()!;
            }
        } 
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new CurrentWeekViewModel(_navigationStore, _diary, Week);
        }

        public SelectWeekCommand(NavigationStore navigationStore, Diary diary, String week) 
        { 
            _navigationStore = navigationStore;
            _diary = diary;
            _weekId = week;
        }
    }
}
