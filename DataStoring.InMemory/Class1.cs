using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;

namespace DataStoring.InMemory;

public class PersonMemRepository : IPersonRepository
{
    public IQueryable<Person> LoadAll()
    {
        return new List<Person>
        {
            new() { Id = 1, Name = "Test", Age = 99 },
            new() { Id = 2, Name = "Testi", Age = 3 }
        }.AsQueryable();
    }
}