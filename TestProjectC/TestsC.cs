using System.Text.Json;
using System.Text.Json.Serialization;
using LibraryC;
using NUnit.Framework;
using RestSharp.Serializers.Json;

namespace TestProjectC;

public class TestsC
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

    [Test]
    public void CreateWrappedClient_ShouldNotThrow()
    {
        Assert.DoesNotThrow(() =>
        {
            var wrappedClient = new WrappedClient(new SystemTextJsonSerializer(SerializerOptions));
        });
    }
}