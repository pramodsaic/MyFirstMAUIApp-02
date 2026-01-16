using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;
using MyFirstMAUIApp.Views;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = TitleMain.Title;

        [ObservableProperty]
        public string layouts = TitleMain.Layouts;

        [ObservableProperty]
        public string images = TitleMain.Images;

        [ObservableProperty]
        public string collections = TitleMain.Collections;

        [ObservableProperty]
        public string controls = TitleMain.Controls;

        [ObservableProperty]
        public string sQLite = TitleMain.SQLite;

        //Button Commands
        //public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel()
        {
            //Title = TitleMain.Title;

            ////Set Commands
            //OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        //private async void OnLayoutsClickedAsync()
        //{
        //    await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        //}
        [RelayCommand]
        private async Task ImagesClicked()
        {
            // If your app uses Shell and the page is routable by name, this is fine:
            // await Shell.Current.GoToAsync(nameof(LayoutsPage));

            // If you are not using Shell or want a safe fallback, use PushAsync:
            //System.Diagnostics.Debug.WriteLine("MAINVM: OnLayoutsClicked invoked");
            //await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
            await Shell.Current.GoToAsync(nameof(ImageMenu));
        }

        [RelayCommand]
        private async Task CollectionsClicked()
        {
            // If your app uses Shell and the page is routable by name, this is fine:
            // await Shell.Current.GoToAsync(nameof(LayoutsPage));

            // If you are not using Shell or want a safe fallback, use PushAsync:
            //System.Diagnostics.Debug.WriteLine("MAINVM: OnLayoutsClicked invoked");
            //await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
            await Shell.Current.GoToAsync(nameof(CollectionPage));
        }
        [RelayCommand]
        private async Task ControlsClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsPage));
        }
    }

}



