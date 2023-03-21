using RestSharp;
using RestSharp.Serializers;

namespace LibraryC;

public class WrappedClient
{
    public WrappedClient(IRestSerializer restSerializer)
    {
        _ = new RestClient(new RestClientOptions(), configureSerialization: sc => sc.UseSerializer(() => restSerializer));
    }
}