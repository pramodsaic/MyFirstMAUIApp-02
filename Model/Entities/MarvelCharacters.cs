namespace MyFirstMAUIApp.Model.Entities;

public class MarvelCharacters
{
    public static string MarvelCharactersTitle { get; internal set; } = "Collection w/Images";
    public string NameofCharacter { get; set; }
    public string NameofActor { get; set; }
    public ImageSource ImagePath { get; set; }

    public MarvelCharacters(string name)
    {
        NameofCharacter = name;
    }

    public MarvelCharacters(string characterName, string actorName, ImageSource imageFile)
    {
        NameofCharacter = characterName;
        NameofActor = actorName;
        ImagePath = imageFile; //ImageSource.FromFile(imageFile);
    }

    public static List<MarvelCharacters> GetCharacters() => new List<MarvelCharacters>
    {
        new MarvelCharacters("Starlord", "Chris Pratt", ImageSource.FromFile("starlord.jpg")),
        new MarvelCharacters("Gamora", "Zoe Saldana", ImageSource.FromFile("gamora.jpg")),
        new MarvelCharacters("Groot", "Vin Diesel", ImageSource.FromFile("groot.jpg")),
        new MarvelCharacters("Rocket", "Bradley Cooper", ImageSource.FromFile("rocket.jpg")),
        new MarvelCharacters("Nebula", "Karen Gillan", ImageSource.FromFile("nebula.jpg"))
     };
}