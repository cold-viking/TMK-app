using SpaceProj.Services;
using SpaceProj.Entities;

namespace SpaceProj;

public class Program
{
    public static void Main()
    {

        string fileName = "cosmoObjects.json";

        CosmoObjectInitializer.InitializeFile(fileName);

        List<CosmoObject> objects = Reader.Load<List<CosmoObject>>(fileName);

        foreach (CosmoObject cosmoObject in objects)
        {
            Console.WriteLine($"{cosmoObject.Name} | {cosmoObject.Type} | {cosmoObject.GetType().Name}");
        }
    }
}