using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class SliderViewModel : ObservableObject
    {
        public string Title => TitleControls.VMTitle;

        [ObservableProperty]
        private double sliderValue;

        [RelayCommand]
        private void SetToHalf()
        {
            sliderValue = 0.5;
        }

    }
}

