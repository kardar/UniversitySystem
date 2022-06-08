// See https://aka.ms/new-console-template for more information
using SchoolSystem.DbContext;
using UniversitySystem.Model;
using UniversitySystem.Repositories;

Console.WriteLine("Hello, World!");

DbData dbData = new DbData("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DemoTest;Data Source=CRLHL-ALIIKHAI1");

//StudentsRepository studentsRepository = new StudentsRepository(dbData);
Departments departments = new Departments("CS");
Departments departments1 = new Departments("Math");
Departments departments2 = new Departments("Physics");





Students student = new Students { Name = "Ali", Age = 21, Departments = departments };
Students student1 = new Students { Name = "Ahmed", Age = 20, Departments = departments1 };
Students student2 = new Students { Name = "Test", Age = 22, Departments = departments2 };
Students student3 = new Students { Name = "Jhon", Age = 23};
StudentsRepository studentsRepository = new StudentsRepository(dbData);
studentsRepository.Add(student);

Teachers teachers = new Teachers { Name = "Ahmed", YearOfService = 4};
teachers.Students = new Students[] { student1, student2 };
departments1.Teachers = new Teachers[] { teachers };

TeacherRepository teacherRepository = new TeacherRepository(dbData);
teacherRepository.Add(teachers);
 
dbData.SaveChanges();

 

/*
 
Teachers teacher = new Teachers("Bilal", 32, "email", 34, "3-4-2019", "Junior", "Masters", "Math");
dbData.Teachers.Add(teacher);
dbData.SaveChanges();

AdminStaff adminStaff = new AdminStaff("Rahid", 32, "email", 34, "3-4-2019", "Junior", "Masters" );
dbData.AdminStaff.Add(adminStaff);
dbData.SaveChanges();

*/


