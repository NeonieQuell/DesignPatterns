using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proxy;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddKeyedScoped<IServiceRepository, ServiceRepository>("Concrete");
    services.AddKeyedScoped<IServiceRepository, CachedServiceRepository>("Proxy");
}).Build();

var cachedServiceRepository = host.Services.GetRequiredKeyedService<IServiceRepository>("Proxy");

var objectId = 1;

// First invocation = not cached
cachedServiceRepository.GetObject(objectId);

// Second invocation = cached
cachedServiceRepository.GetObject(objectId);
