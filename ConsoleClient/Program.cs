using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DiMappings;
using Ninject;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new KernelFactory().Create();

        var manager = kernel.Get<IPersonManager>();

        var adults = manager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}