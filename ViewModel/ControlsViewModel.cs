using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModels
{
    public partial class ControlsViewModel : ObservableObject
    {
        public string Title => TitleControls.Title;
        public string Slider => TitleControls.Slider;
        public string Switch => TitleControls.Switch;
        public string Stepper => TitleControls.Stepper;
        public string Entry => TitleControls.Entry;
        public string Picker => TitleControls.Picker;
        public string DateandTimePicker => TitleControls.DateandTimePicker;

        [RelayCommand]
        private async Task SliderClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderPage));
        }

        [RelayCommand]
        private async Task StepperClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperPage));
        }

    }
}


