using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIApp.Model.Entities;

// This message is used to notify other parts of the app that a new MarvelMovie was added
namespace MyFirstMAUIApp.Models.Messages
{
    public class AddMovieMessage : ValueChangedMessage<MarvelMovies>
    {
        public AddMovieMessage(MarvelMovies value) : base(value) { }
    }
}