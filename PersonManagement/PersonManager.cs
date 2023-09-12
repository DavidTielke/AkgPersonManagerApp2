using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;

    public PersonManager(IPersonRepository repository)
    {
        _repository = repository;
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