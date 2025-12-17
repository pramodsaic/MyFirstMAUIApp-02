using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIApp.Model.Entities;

namespace MyFirstMAUIApp.Model.Messages
{
    public class UpdateMovieMessage : ValueChangedMessage<(MarvelMovies OldValue, MarvelMovies NewValue)>
    {
        public UpdateMovieMessage(MarvelMovies oldValue, MarvelMovies newValue)
            : base((oldValue, newValue)) { }

        public MarvelMovies OldValue => Value.OldValue;
        public MarvelMovies NewValue => Value.NewValue;
    }
}

namespace MyFirstMAUIApp.Model.Titles
{
    public static class TitlesMisc
    {
        // Page title
        public static string Title { get; set; } = "Misc Menu";

        // Used by AddCollectionViewModel
        public static string AddTitle { get; set; } = "Add Collection";

        // NEW: Used by EditCollectionViewModel
        public static string EditTitle { get; set; } = "Edit Collection";
    }
}

namespace MyFirstMAUIApp.ViewModel
{
    // Forwarding shim so existing ViewModels that reference TitlesMisc
    // without adding a using still resolve.
    public static class TitlesMisc
    {
        public static string Title => MyFirstMAUIApp.Model.Titles.TitlesMisc.Title;
        public static string AddTitle => MyFirstMAUIApp.Model.Titles.TitlesMisc.AddTitle;
        public static string EditTitle => MyFirstMAUIApp.Model.Titles.TitlesMisc.EditTitle;
    }
}

