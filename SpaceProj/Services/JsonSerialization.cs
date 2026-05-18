using System.Text.Encodings.Web;
using System.Text.Json;
using SpaceProj.Entity;

namespace SpaceProj.Services;

public static class JsonSerialization
{
    public static void Run()
    {
        Star star = new Star(
            "Sun",
            9999,
            220,
            4.5,
            5800,
            "Yellow"
        );
        
        string json = JsonSerializer.Serialize(star);

        File.WriteAllText("star.json", json);

        string jsonFromFile = File.ReadAllText("star.json");

        Star? restoredStar = JsonSerializer.Deserialize<Star>(jsonFromFile);

        if (restoredStar == null)
        {
            Console.WriteLine("Object was not deserialize from json");
            return;
        }

        Console.WriteLine("Object was  deserialize from json");
        Console.WriteLine(restoredStar.GetInfo());
    }
}