using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}