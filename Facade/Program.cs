using Facade;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddScoped<ISmartLighting, SmartLighting>();
    services.AddScoped<ISecuritySystem, SecuritySystem>();
    services.AddScoped<ISmartHomeFacade, SmartHomeFacade>();
}).Build();

var smartHome = host.Services.GetRequiredService<ISmartHomeFacade>();

Console.WriteLine("Morning Setup:");
smartHome.MorningSetup();

Console.WriteLine();

Console.WriteLine("Evening Setup:");
smartHome.EveningSetup();