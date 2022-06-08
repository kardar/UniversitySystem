using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Teachers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int YearOfService { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
