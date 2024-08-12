using Decorator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddScoped<IStudent, Student>();
    services.AddScoped<ITStudentDecorator>(provider =>
    {
        var concreteObject = provider.GetRequiredService<IStudent>();
        return new ITStudentDecorator(concreteObject);
    });
    services.AddScoped<SoftwareEngineerDecorator>(provider =>
    {
        var concreteObject = provider.GetRequiredService<IStudent>();
        return new SoftwareEngineerDecorator(concreteObject);
    });
}).Build();

var sourceStudent = host.Services.GetRequiredService<IStudent>();
var itStudent = host.Services.GetRequiredService<ITStudentDecorator>();
var swe = host.Services.GetRequiredService<SoftwareEngineerDecorator>();

Console.WriteLine(swe.GetSkill());
