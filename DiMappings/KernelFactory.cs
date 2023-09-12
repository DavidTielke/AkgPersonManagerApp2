using DataStoring.InMemory;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;
using Ninject;

namespace DiMappings;

public class KernelFactory
{
    public IKernel Create()
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonRepository>().To<PersonMemRepository>();
        kernel.Bind<IPersonManager>().To<PersonManager>();

        return kernel;
    }
}