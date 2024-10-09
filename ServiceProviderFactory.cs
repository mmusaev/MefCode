using System;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

public class ServiceProviderFactory
{
    public static IServiceProvider CreateServiceProvider()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddHttpClient();
        return serviceCollection.BuildServiceProvider();
    }
}

[Export(typeof(IServiceProvider))]
public class ServiceProviderExport
{
    private readonly IServiceProvider _serviceProvider;

    public ServiceProviderExport()
    {
        _serviceProvider = ServiceProviderFactory.CreateServiceProvider();
    }

    public IServiceProvider GetServiceProvider()
    {
        return _serviceProvider;
    }
}