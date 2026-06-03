using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceProj.Entities;

namespace SpaceProj.Services;

public class CosmoObjectJsonConverter : JsonConverter<CosmoObject>
{
    public override CosmoObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, CosmoObject value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}