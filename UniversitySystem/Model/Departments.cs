using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Departments
    {
        public Departments(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        

        public ICollection<Students> Students { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
        public string V { get; }
    }
}
