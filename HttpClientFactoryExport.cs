using System.ComponentModel.Composition;
using System.Net.Http;

[Export(typeof(IHttpClientFactory))]
public class HttpClientFactoryExport
{
    private readonly IHttpClientFactory _httpClientFactory;

    [ImportingConstructor]
    public HttpClientFactoryExport(IServiceProvider serviceProvider)
    {
        _httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
    }

    public IHttpClientFactory GetHttpClientFactory()
    {
        return _httpClientFactory;
    }
}