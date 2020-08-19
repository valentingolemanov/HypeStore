using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetwearStore.Data.Repository
{
    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext context;

        public EfRepository(ApplicationDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        public Task AddAsync(TEntity entity) =>  this.DbSet.AddAsync(entity).AsTask();


        public virtual IQueryable<TEntity> All() => this.DbSet;

       
        public virtual IQueryable<TEntity> AllAsNoTracking() => this.DbSet.AsNoTracking();


        public void Delete(TEntity entity) => this.DbSet.Remove(entity);


        public Task<int> SaveChangesAsync() => this.context.SaveChangesAsync();

        public void Update(TEntity entity)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
    }
}
