
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsSlider : ContentPage
{
    public ControlsSlider()
    {
        InitializeComponent();
        BindingContext = new SliderViewModel();

        UpdateVisuals(MySlider.Value);

        SetPlatformPadding();
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
                                       => UpdateVisuals(e.NewValue);

    private void UpdateVisuals(double value)
    {
        MyBox.Opacity = value;

        ValueLabel.Text = string.Format("Slider Value: {0:F2}", value);

        InfoLabel.Opacity = value;

    }

    private void SetPlatformPadding()
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }
        else
        {
            Padding = Thickness.Zero;
        }
    }
}

