using SpaceProj.Entities;

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
        Writer.Save(star, fileName);

        Star restoredObject = Reader.Load<Star>(fileName);
        Console.WriteLine(restoredObject.GetInfo());
        
        Writer.Save(planet, fileName);
        Planet planetObject = Reader.Load<Planet>(fileName);
        Console.WriteLine(planetObject.GetInfo());
    }
}