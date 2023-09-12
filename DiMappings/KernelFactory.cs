using DavidTielke.PersonManagerApp.Data.CsvStoring;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using Ninject;

namespace DiMappings;

public class KernelFactory
{
    public IKernel Create()
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonRepository>().To<PersonRepository>();
        kernel.Bind<IPersonManager>().To<PersonManager>();

        return kernel;
    }
}