using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.Json;

namespace LibraryB;

public sealed class WrappedClient
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public WrappedClient()
    {
        _ = new RestClient(new RestClientOptions(), configureSerialization: sc => sc.UseSerializer(() => new SystemTextJsonSerializer(SerializerOptions)));
    }
}