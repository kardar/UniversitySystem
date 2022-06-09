// See https://aka.ms/new-console-template for more information
using SchoolSystem.DbContext;
using UniversitySystem.Model;
using UniversitySystem.Repositories.EntityRepos;
using UniversitySystem.Repositories.GenericCoreImpl;

 

DbData dbData = new DbData("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DemoTest;Data Source=CRLHL-ALIIKHAI1");

StudentsRepository studentsRepository = new StudentsRepository(dbData);
TeacherRepository teacherRepository = new TeacherRepository(dbData);
DepartmentRepository departmentRepository = new DepartmentRepository(dbData);
GenericLinqCrud<Students> genericLinq = new GenericLinqCrud<Students>();
Departments departments3 = new Departments(5, "Physics");

Teachers teachers = new Teachers { Name = "Ahmed", Age = 22, Address = "Address test", Education = "Maters", Salary = 200,  YearsOfService = 4 };
Students student = new Students(


     "Bilal",
      20,
     "Main City 6th Avenue",
     3,
     5,
     departments3


    );


//Departments departments = new Departments {Name = "CS" };
//Departments departments2 = new Departments("Physics");



//studentsRepository.Add(student);
//dbData.Dispose();
//Console.WriteLine(studentsRepository.Get(3));
dbData.Students.Attach(student);
studentsRepository.Remove(student);

dbData.SaveChanges();


 


//Students student1 = new Students { Name = "Ahmed", Age = 20, Departments = departments1 };
//Students student2 = new Students { Name = "Test", Age = 22, Departments = departments2 };
//Students student3 = new Students { Name = "Jhon", Age = 23};


//studentsRepository.Add(student);
//Teachers teachers = new Teachers { Name = "Ahmed", Age = 22, YearsOfService = 4};
//teachers.Students = new Students[] { student1, student2 };
//departments1.Teachers = new Teachers[] { teachers };


//teacherRepository.Add(teachers);


dbData.SaveChanges();



 
 




