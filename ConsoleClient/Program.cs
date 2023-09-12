using DavidTielke.PersonManagerApp.Logic.PersonManagement;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var manager = new PersonManager();

        var adults = manager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}