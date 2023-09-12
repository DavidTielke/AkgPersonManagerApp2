using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.CsvStoring;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository.LoadAll().Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository.LoadAll().Where(p => p.Age < 18);
    }
}