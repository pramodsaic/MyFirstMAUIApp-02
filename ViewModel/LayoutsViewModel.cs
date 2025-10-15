using MyFirstMAUIApp.Model;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMAUIApp.ViewModel
{
    public class LayoutsViewModel : BaseViewModel
    {
        public string LayoutsTitle { get; set; } = TitleLayouts.Title;
        public string ButtonTextStackLayout { get; set; } = TitleLayouts.ButtonTextStackLayout;
        public string ButtonTextVerticalLayout { get; set; } = TitleLayouts.ButtonTextVerticalLayout;
        public string ButtonTextHorizontalLayout { get; set; } = TitleLayouts.ButtonTextHorizontalLayout;
        public string ButtonTextAbsoluteLayout { get; set; } = TitleLayouts.ButtonTextAbsoluteLayout;
        public string ButtonTextFlexLayout { get; set; } = TitleLayouts.ButtonTextFlexLayout;

        public LayoutsViewModel()
        {
            Title = TitleLayouts.Title;
        }
    }
}


