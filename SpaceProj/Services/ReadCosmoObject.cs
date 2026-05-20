using System.Text.Json;


namespace SpaceProj.Services;

public static class ReadCosmoObject
{
    public static T Load<T>(string fileName)
    {
        string jsonFromFile = File.ReadAllText(fileName);

        T? restoredStar = JsonSerializer.Deserialize<T>(jsonFromFile);

        if (restoredStar == null)
        {
            throw new InvalidOperationException("ERROR: Object was not deserialized from json");
        }

        return restoredStar;
    }
}