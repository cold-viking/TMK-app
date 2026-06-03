using SpaceProj.Entities;

namespace SpaceProj.Services;

public static class CosmoObjectInitializer
{
    public static List<ICosmoObject> Create()
    {
        ICosmoObject star = new Star(
            "Sun",
            9999,
            220,
            4.5,
            5800,
            "Yellow"
        );

        ICosmoObject planet = new Planet(
            "Earth",
            5972,
            29.78,
            4.5,
            true,
            "Nitrogen-oxygen",
            6371
        );

        ICosmoObject blackHole = new BlackHole(
            "Sagittarius A*",
            4300000,
            0,
            13.6,
            12000000,
            999999
        );

        ICosmoObject asteroid = new Asteroid(
            "Ceres",
            939,
            17.9,
            4.5,
            939.4,
            "Rock and ice"
        );
        List<ICosmoObject> cosmoObjects = new List<ICosmoObject>();
        
        cosmoObjects.Add(star);
        cosmoObjects.Add(planet);
        cosmoObjects.Add(blackHole);
        cosmoObjects.Add(asteroid);
        
        return cosmoObjects;
    }

    public static void InitializeFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            List<ICosmoObject> cosmoObjects = Create();
            WriteCosmoObject.Save(cosmoObjects, fileName);
        }
    }
}