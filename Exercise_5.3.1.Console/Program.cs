// See https://aka.ms/new-console-template for more information
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Exercise_5._3._1.API;


/*ITimePrintingService timePrintingService = new TimePrintingService();
ITimeService ts = new TimeService(timePrintingService);
Console.WriteLine(ts.GetTime());*/

var builder = new ContainerBuilder();
builder.RegisterType<TimeService>().As<ITimeService>();
builder.RegisterType<TimePrintingService>().As<ITimePrintingService>();

// Zbudowanie kontenera
var container = builder.Build();

// Stworzenie providera usług
var serviceProvider = new AutofacServiceProvider(container);

// Rozwiązywanie zależności
using (var scope = container.BeginLifetimeScope())
{
    var timeService = scope.Resolve<ITimeService>();
    Console.WriteLine(timeService.GetTime());
}