using System.Text.Json;

namespace SpaceProj.Services;

public static class WriteCosmoObject
{
    public static void Save<T>(T objectToWrite,  string fileName)
    {
        string json = JsonSerializer.Serialize(objectToWrite);

        File.WriteAllText(fileName, json);
    }
}