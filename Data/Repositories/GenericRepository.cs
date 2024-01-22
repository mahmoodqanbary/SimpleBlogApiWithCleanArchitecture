using Data.Context;
using Data.Contracts;
using Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region Constractor
        private readonly ApplicationDbContext _context;
        private DbSet<TEntity> _entity;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _entity = this._context.Set<TEntity>();
        }
        #endregion

        #region Methods
        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return _entity.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(int id)
        {
            return await _entity.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddEntity(TEntity entity)
        {
            entity.CreateDate = DateTime.UtcNow;
            entity.UpdateDate = entity.CreateDate;
            await _entity.AddAsync(entity);
        }

        public void UpdateEntity(TEntity entity)
        {
            entity.UpdateDate = DateTime.UtcNow;
            _entity.Update(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            entity.IsDeleted = true;
            _entity.Update(entity);
        }

        public async Task DeleteEntity(int id)
        {
            var entity = await GetEntityById(id);
            DeleteEntity(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

    }
}
