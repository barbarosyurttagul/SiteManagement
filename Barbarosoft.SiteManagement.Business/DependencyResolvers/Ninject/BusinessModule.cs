using Barbarosoft.SiteManagement.Business.Abstract;
using Barbarosoft.SiteManagement.Business.Concrete.Managers;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Barbarosoft.SiteManagement.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICurrentOccupierService>().To<CurrentOccupierManager>().InSingletonScope();
            Bind<ICurrentOccupierDal>().To<EfCurrentOccupierDal>();

           
        }
    }
}
