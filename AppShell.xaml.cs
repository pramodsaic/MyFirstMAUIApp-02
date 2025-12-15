using MyFirstMAUIApp.Views;
using MyFirstMAUIApp.ViewModels;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            //Layouts
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));

            //Layouts Child Page 
            Routing.RegisterRoute(nameof(LayoutsStackPage), typeof(LayoutsStackPage));
            Routing.RegisterRoute(nameof(LayoutsVerticalPage), typeof(LayoutsVerticalPage));
            Routing.RegisterRoute(nameof(LayoutsHorizontalPage), typeof(LayoutsHorizontalPage));
            Routing.RegisterRoute(nameof(LayoutsAbsolutePage), typeof(LayoutsAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutsFlexPage), typeof(LayoutsFlexPage));
            //Images
            Routing.RegisterRoute(nameof(ImageMenu), typeof(ImageMenu));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(ActivityIndicatorPage), typeof(ActivityIndicatorPage));
            //Collections
            Routing.RegisterRoute(nameof(CollectionPage), typeof(CollectionPage));
            Routing.RegisterRoute(nameof(CollectionMarvelMoviesPage), typeof(CollectionMarvelMoviesPage));
            Routing.RegisterRoute(nameof(CollectionGOGwImagesPage), typeof(CollectionGOGwImagesPage));
            Routing.RegisterRoute(nameof(AddCollectionPage), typeof(AddCollectionPage));
            Routing.RegisterRoute(nameof(EditCollectionPage), typeof(EditCollectionPage));
            Routing.RegisterRoute(nameof(UpdateableCollectionWButtonsPage), typeof(UpdateableCollectionWButtonsPage));

        }

    }
}