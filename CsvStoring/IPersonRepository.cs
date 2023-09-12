using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.CsvStoring;

public interface IPersonRepository
{
    IQueryable<Person> LoadAll();
}