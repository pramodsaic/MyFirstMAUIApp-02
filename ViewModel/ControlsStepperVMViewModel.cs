using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsStepperVMViewModel : ObservableObject
    {

        public string Title => TitleControls.StepperVMTitle;

        [ObservableProperty]
        public string labelText;

        [ObservableProperty]
        private double direction;

        public ControlsStepperVMViewModel()
        {
            direction = 0;
            LabelText = $"The Stepper Value is {direction:F0}";
        }

        partial void OnDirectionChanged(double value) => UpdateVisual(value);

        public void UpdateVisual(double value)
        {
            LabelText = $"The Stepper Value is {value:F0}";

        }
    }
}