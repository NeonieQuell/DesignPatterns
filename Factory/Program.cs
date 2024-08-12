using Factory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddScoped<IPaymentFactory, PaymentFactory>();
}).Build();

var paymentFactory = host.Services.GetService<IPaymentFactory>();

var payment = paymentFactory!.GetPayment(PaymentOption.ApplePay);
payment.Pay();
