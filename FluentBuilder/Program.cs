using FluentBuilder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddScoped<Order>();
    services.AddScoped<Address>();
    services.AddScoped<IOrderBuilder, OrderBuilder>();
    services.AddScoped<IAddressBuilder, AddressBuilder>();
}).Build();

var orderBuilder = host.Services.GetRequiredService<IOrderBuilder>();

var order1 = orderBuilder.HasOrderId(1)
                         .ShipTo(a =>
                            a.Street("Korea")
                             .City("Taguig")
                             .Country("Philippines"))
                         .Build();

Console.WriteLine(order1);

//

var addressBuilder = host.Services.GetRequiredService<IAddressBuilder>();
var address = addressBuilder.Street("Italy")
                            .City("Taguig")
                            .Country("Philippines")
                            .Build();

var order2 = orderBuilder.HasOrderId(2)
                         .ShipTo(address)
                         .Build();

Console.WriteLine(order2);
