using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeSatisProject.DataAccess.Abstract;
using MaskeSatisProject.DataAccess.Concrete.EntityFramework.Base;
using MaskeSatisProject.Entities.Concrete;

namespace MaskeSatisProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<Users, MaskContext>,IUserDal
    {
    }
}
