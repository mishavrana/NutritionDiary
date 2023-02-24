using NutritionDiary.Comands;
using NutritionDiary.Models;
using NutritionDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NutritionDiary.Commands
{
    class StartNewWeekCommand : CommandBase
    {
        private readonly AddWeekViewModel _addWeekViewModel;
        private readonly Diary _diary;

        public StartNewWeekCommand(AddWeekViewModel addWeekViewModel, Diary diary)
        {
            _addWeekViewModel = addWeekViewModel;
            _diary = diary;

            _addWeekViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sendet, PropertyChangedEventArgs e)
        { 
            if(e.PropertyName== nameof(AddWeekViewModel.NewProduct)) 
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_addWeekViewModel.NewProduct) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Week week = new Week(_addWeekViewModel.StartDate, _addWeekViewModel.EndDate);
            try
            {
                _diary.StartNewWeek(week);
                MessageBox.Show("Added new week!", "Error", MessageBoxButton.OK);
            } catch
            {
                return;
            }


        }
    }
}
