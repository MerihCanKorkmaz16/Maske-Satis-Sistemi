using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeSatisProject.DataAccess.Abstract;
using MaskeSatisProject.DataAccess.Concrete.EntityFramework.Base;
using MaskeSatisProject.Entities.ComplexType;
using MaskeSatisProject.Entities.Concrete;

namespace MaskeSatisProject.DataAccess.Concrete.EntityFramework
{
    public class EfMaskDal : EfEntityRepositoryBase<MaskTable, MaskContext>, IMaskDal
    {
        public List<MaskDetails> GetMaskDetail(int userId)
        {
            using (MaskContext context = new MaskContext())
            {
                var result = from p in context.Users
                             join c in context.MaskTable on p.UserId equals c.UserId
                             where p.UserId == userId
                             select new MaskDetails
                             {
                                 UserId = p.UserId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 OperationDate = c.OperationDate
                             };
                return result.ToList();

            }

        }
    }
}
