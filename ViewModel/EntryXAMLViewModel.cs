using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
namespace MyFirstMAUIApp.ViewModel
{
    public partial class EntryXAMLViewModel : ObservableObject
    {
        public string Title => TitleEntryXAML.Title;
        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            string entryText = EntryValue.Text;
            if (string.IsNullOrWhiteSpace(entryText))
            {
                await Shell.Current.DisplayAlert(TitlesEntry.EntryXAMLTitle, "Entry is empty. Please enter text.", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert(TitlesEntry.EntryXAMLTitle, "You entered: " + entryText, "OK");
            }
        }
    }
}