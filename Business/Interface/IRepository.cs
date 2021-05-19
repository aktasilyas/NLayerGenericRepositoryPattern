using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null);
        TEntity GetById(Expression<Func<TEntity,bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        
    }
}
