using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using web.data.Infrastructure;
using web.entities;

namespace web.data.Repositories
{
    public sealed class EntityBaseRepository<T> : IEntityBaseRepository<T> where T:class,IEntityBase,new()
    {
        private StudentDbContext dataContext;


        #region --Properities

        private IDbFactory DbFactory { get; }

        private StudentDbContext studentDbContext => dataContext ?? (dataContext = DbFactory.Init());
        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        #endregion

        public IQueryable<T> GetAll()
        {
            return studentDbContext.Set<T>().Where(x => x.IsDeleted == false);
        }

        /// <summary>
        /// Get All
        /// <value>
        /// All
        /// </value>
        /// </summary>
        public IQueryable<T> All => GetAll();

        /// <summary>
        /// AllIncluding 
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IQueryable<T> AllIncluding(params Expression<Func<T,Object>>[] includeProperties)
        {
            var query = studentDbContext.Set<T>().Where(x => x.IsDeleted == false);
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        /// <summary>
        /// get By single Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetSingle(long id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Find By
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return studentDbContext.Set<T>().Where(predicate).Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> FindByAll(Expression<Func<T, bool>> predicate)
        {
            return studentDbContext.Set<T>().Where(predicate);
        }

        /// <summary>
        /// Add Student
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            entity.IsDeleted = false;
            studentDbContext.Entry(entity);
            studentDbContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                entity.IsDeleted = false;
                studentDbContext.Entry(entity);
                studentDbContext.Set<T>().Add(entity);
            }
        }

        public void Edit (T oldEntity, T newEntity)
        {
            studentDbContext.Entry(oldEntity).CurrentValues.SetValues(newEntity);
        }

        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = studentDbContext.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void SoftDelete(T entity)
        {
            entity.IsDeleted = true;
            DbEntityEntry dbEntityEntry = studentDbContext.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

       
    }
}
