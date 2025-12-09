using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.Models.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class CollectionsImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        public string verticalStackLayoutTitle = TitleLayoutsVerticalStack.VerticalLayoutTitle;

    }
}


