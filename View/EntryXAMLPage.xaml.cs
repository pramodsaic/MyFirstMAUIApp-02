using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class EntryXAMLPage : ContentPage
{
	public EntryXAMLPage()
	{
		InitializeComponent();
        BindingContext = new EntryXAMLViewModel();
    }
}