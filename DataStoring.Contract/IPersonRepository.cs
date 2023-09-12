using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Contract;

public interface IPersonRepository
{
    IQueryable<Person> LoadAll();
}