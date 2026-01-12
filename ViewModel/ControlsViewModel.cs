using MyFirstMAUIApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

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

    }
}

