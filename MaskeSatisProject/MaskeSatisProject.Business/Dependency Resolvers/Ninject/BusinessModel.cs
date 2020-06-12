using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.Concrete.Managers;
using MaskeSatisProject.Business.ServiceAdapter;
using MaskeSatisProject.DataAccess.Abstract;
using MaskeSatisProject.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Dependency_Resolvers.Ninject
{
    public class BusinessModel : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IMaskService>().To<MaskManager>().InSingletonScope();
            Bind<IMaskDal>().To<EfMaskDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
