using System.Text.Json;


namespace SpaceProj.Services;

public static class ReadCosmoObject
{
    public static T Load<T>(string fileName)
    {
        string jsonFromFile = File.ReadAllText(fileName);

        T? restoredObject = JsonSerializer.Deserialize<T>(jsonFromFile);

        if (restoredObject == null)
        {
            throw new InvalidOperationException("ERROR: Object was not deserialized from json");
        }

        return restoredObject;
    }
}