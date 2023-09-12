using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.CsvStoring;

public class PersonRepository : IPersonRepository
{
    public IQueryable<Person> LoadAll()
    {
        return File.ReadAllLines("data.csv")
            .Select(l => l.Split(","))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            }).AsQueryable();
    }
}