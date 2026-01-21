using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsSliderXAMLViewModel : ObservableObject
    {
        public string Title => TitleControlsSliderXAML.Title;
    }
}