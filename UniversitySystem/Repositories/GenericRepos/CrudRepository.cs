using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Repositories.GenericRepos
{
    public class CrudRepository<TEntity> : ICrud<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;


        public CrudRepository(DbContext context)
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {

            try
            {
                if(entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Context.Set<TEntity>().Add(entity);
            }catch
            {
                Console.WriteLine("Entity not saved");
            }

            
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
