using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Students
    {
 
        /* public Students(string name, int age,Departments departments1 )
{
    Name = name;
    Age = age;
    Departments = departments1;

}
*/
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Departments Departments { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
    }
}
