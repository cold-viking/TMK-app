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
            "Yellow" );

        Planet planet = new Planet(
            "Earth", 99999, 122,
            222,
            true,
            "normal",
            12312
        );
            
        string fileName = "cosmo.json";
        WriteCosmoObject.Save(star, fileName);

        Star restoredObject = ReadCosmoObject.Load<Star>(fileName);
        Console.WriteLine(restoredObject.GetInfo());
        
        WriteCosmoObject.Save(planet, fileName);
        Planet planetObject = ReadCosmoObject.Load<Planet>(fileName);
        Console.WriteLine(planetObject.GetInfo());
    }
}