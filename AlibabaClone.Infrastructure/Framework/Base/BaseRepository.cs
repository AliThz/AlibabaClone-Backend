using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Framework.Base
{
    public class BaseRepository<K_DbContext, T_Entity, U_PrimaryKey> :
                 Domain.Framework.Interfaces.Repositories.IRepository<T_Entity, U_PrimaryKey>
                 where K_DbContext : DbContext
                 where T_Entity : class
    {
        #region [ - Ctor - ]
        public BaseRepository(K_DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<T_Entity>();
        }
        #endregion

        #region [ - Props - ]
        public virtual K_DbContext DbContext { get; set; }
        public virtual DbSet<T_Entity> DbSet { get; set; }
        #endregion

        #region [ - Methods - ]

        #region [ - InsertAsync(T_Entity entity) - ]
        public virtual async Task InsertAsync(T_Entity entity)
        {
            await DbContext.AddAsync(entity);
        }
        #endregion

        #region [ - Task<List<T_Entity>> SelectAsync() - ]
        public virtual async Task<List<T_Entity>> SelectAsync()
        {
            var entityList = DbSet.ToListAsync();
            return await entityList;
        }
        #endregion

        #region [ - FindByIdAsync(U_PrimaryKey id) - ]
        public virtual async Task<T_Entity> FindByIdAsync(U_PrimaryKey id)
        {
            return await DbSet.FindAsync(id);
        }
        #endregion

        #region [ - Update(T_Entity entity) - ]
        public virtual void Update(T_Entity entity)
        {
            DbSet.Update(entity);
        }
        #endregion

        #region [ - DeleteAsync(T_Entity entity) - ]
        public virtual async Task DeleteAsync(T_Entity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }
        #endregion

        #region [ - DeleteAsync(U_PrimaryKey id) - ]
        public virtual async Task DeleteAsync(U_PrimaryKey id)
        {
            var entityToDelete = await DbSet.FindAsync(id);
            DbSet.Remove(entityToDelete);
        }
        #endregion

        #endregion
    }
}
