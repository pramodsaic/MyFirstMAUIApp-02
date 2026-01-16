using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsStepperXAMLViewModel : ObservableObject
    {
        public string Title => TitleControls.StepperXAMLTitle;

    }
}

