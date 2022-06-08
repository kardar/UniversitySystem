using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using UniversitySystem.Model;

namespace SchoolSystem.DbContext
{
    internal class DbData : System.Data.Entity.DbContext
    {
        public DbData()
        {

        }
        public DbData(string connectionString) : base(connectionString)
        {

        }

        public System.Data.Entity.DbSet<Departments> Departments { get; set; }

        public System.Data.Entity.DbSet<Students> Students { get; set; }

        public System.Data.Entity.DbSet<Teachers> Teachers { get; set; }



    }

   
}
