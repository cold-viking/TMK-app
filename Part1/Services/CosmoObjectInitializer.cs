using SpaceProj.Entities;

namespace SpaceProj.Services;

public static class CosmoObjectInitializer
{
    public static List<CosmoObject> Create()
    {
        CosmoObject star = new Star(
            "Sun",
            9999,
            220,
            4.5,
            5800,
            "Yellow"
        );

        CosmoObject planet = new Planet(
            "Earth",
            5972,
            29.78,
            4.5,
            true,
            "Nitrogen-oxygen",
            6371
        );

        CosmoObject blackHole = new BlackHole(
            "Sagittarius A*",
            4300000,
            0,
            13.6,
            12000000,
            999999
        );

        CosmoObject asteroid = new Asteroid(
            "Ceres",
            939,
            17.9,
            4.5,
            939.4,
            "Rock and ice"
        );
        List<CosmoObject> cosmoObjects = new List<CosmoObject>();
        
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
            List<CosmoObject> cosmoObjects = Create();
            Writer.Save(cosmoObjects, fileName);
        }
    }
}