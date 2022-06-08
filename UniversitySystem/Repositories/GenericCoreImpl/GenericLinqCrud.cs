using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Repositories.GenericRepos;

namespace UniversitySystem.Repositories.GenericCoreImpl
{
    internal class GenericLinqCrud<T> : ICrud<T>  where T : class
    {
        DataContext context;

        public GenericLinqCrud()
        {
            context = new DataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=tempdb;Data Source=DESKTOP-GM0D66R");
            context.DeferredLoadingEnabled = false;
        }

        public void Add(T entity)
        {
           context.GetTable<T>().InsertOnSubmit(entity);
            context.SubmitChanges();
            
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
