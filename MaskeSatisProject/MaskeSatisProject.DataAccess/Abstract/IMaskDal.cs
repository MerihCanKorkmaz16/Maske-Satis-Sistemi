using MaskeSatisProject.DataAccess.Concrete.EntityFramework;
using MaskeSatisProject.Entities.ComplexType;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.DataAccess.Abstract
{
    public interface IMaskDal:IEntityRepository<MaskTable>
    {
        List<MaskDetails> GetMaskDetail(int userId);
    }
}
