using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_DbFirst.DataAccess
{
    internal interface IDataAccess <TEntity, in TPk> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TPk id,TEntity entity);
        Task<TEntity> DeleteAsync(TPk id);
    }
}
