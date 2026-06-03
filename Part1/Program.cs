using SpaceProj.Services;
using SpaceProj.Entities;

namespace SpaceProj;

public class Program
{
    public static void Main()
    {

        string fileName = "cosmoObjects.json";

        CosmoObjectInitializer.InitializeFile(fileName);

        Console.WriteLine("Initialization completed");

        Console.WriteLine(Path.GetFullPath(fileName));
    }
}