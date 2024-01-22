using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity: BaseEntity
    {
        IQueryable<TEntity> GetEntitiesQuery();
        Task<TEntity> GetEntityById(int id);
        Task AddEntity(TEntity entity);
        void UpdateEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntity(int id);
        Task SaveChanges();
    }
}
