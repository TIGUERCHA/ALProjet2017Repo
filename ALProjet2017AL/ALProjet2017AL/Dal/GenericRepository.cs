using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ALProjet2017AL.Dal
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private CalendrierESGIEntities context;
        private DbSet<TEntity> dbset;

        public GenericRepository(CalendrierESGIEntities context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public virtual string Add(TEntity entityToAdd)
        {
            string messErreur = null;
            try
            {
                context.Entry(entityToAdd).State = EntityState.Added;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {

                Exception raise = dbEx;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        messErreur = messErreur != null ? " , " + validationErrors.Entry.Entity.ToString() : validationErrors.Entry.Entity.ToString();
                    }
                }
            }
            return messErreur;
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split
                        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!string.IsNullOrEmpty(includeProperty))
                    {
                        query = query.Include(includeProperty);
                    }
                }
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
            //return null;
        }
    }
}