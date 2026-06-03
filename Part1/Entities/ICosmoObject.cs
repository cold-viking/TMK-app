using System.Text.Json.Serialization;

namespace SpaceProj.Entities;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "objectType")]
[JsonDerivedType(typeof(Star), "star")]
[JsonDerivedType(typeof(Planet), "planet")]
[JsonDerivedType(typeof(Asteroid), "asteroid")]
[JsonDerivedType(typeof(BlackHole), "blackHole")]
public interface ICosmoObject
{
    Guid Id { get; set; }

    string Name { get; set; }

    double MassInTons { get; set; }

    double SpeedKmPerSecond { get; set; }

    double AgeInBillionYears { get; set; }

    string GetInfo();
}
