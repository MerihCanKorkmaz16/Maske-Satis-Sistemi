using MaskeSatisProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T :class, IEntity, new()
    {
        List<T> GetAllUser(Expression<Func<T,bool>> filter = null);
        T GetUser(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);


    }
}
