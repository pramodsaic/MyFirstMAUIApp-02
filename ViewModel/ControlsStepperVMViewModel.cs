using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            LabelText = $"Value is {direction:F0}";
        }

        partial void OnDirectionChanged(double value) => UpdateVisual(value);

        public void UpdateVisual(double value)
        {
            LabelText = $"Value is {value:F0}";

        }
    }
}
