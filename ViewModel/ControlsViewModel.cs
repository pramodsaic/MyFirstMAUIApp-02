using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsViewModel : ObservableObject
    {
        public string Title => TitleControls.Title;

        [ObservableProperty]
        private string buttonTextSlider = TitleControls.ButtonTextSlider;

        [ObservableProperty]
        private string buttonTextStepper = TitleControls.ButtonTextStepper;

        [ObservableProperty]
        private string buttonTextSwitch = TitleControls.ButtonTextSwitch;

        [ObservableProperty]
        private string buttonTextEntry = TitleControls.ButtonTextEntry;

        [ObservableProperty]
        private string buttonTextPicker = TitleControls.ButtonTextPicker;

        [ObservableProperty]
        private string buttonTextDateAndTimePicker = TitleControls.ButtonTextDateAndTimePicker;

        public ControlsViewModel()
        {

        }

        [RelayCommand]
        private async Task SliderMenuClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSlider));
        }

    }
}