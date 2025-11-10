namespace MyFirstMAUIApp.ViewModel;

public class LayoutsFlexViewModel : ContentPage
{
	public LayoutsFlexViewModel()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}