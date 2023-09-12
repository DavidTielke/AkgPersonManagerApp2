using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;
using DiMappings;
using Ninject;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new KernelFactory().Create();
        var app = kernel.Get<Application>();
        app.Run();
    }
}

internal class Application
{
    private readonly IPersonManager _manager;

    public Application(IPersonManager manager)
    {
        _manager = manager;
    }

    public void Run()
    {
        var adults = _manager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}