using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Repositories.GenericRepos;

namespace UniversitySystem.Repositories.EntityRepos
{
    internal class StudentsRepository : CrudRepository<Model.Students>
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }
    }
}
