// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");

Student student1 = new Student() { Id = 1, Name = "Hakan", Age = 25, Score = 74 };
Student student2 = new Student() { Id = 2, Name = "Sümeyye", Age = 26, Score = 65 };
Student student3 = new Student() { Id = 3, Name = "Zeynep", Age = 29, Score = 80 };

ClassRoom classRoom = new ClassRoom();
classRoom.Add(student1);
classRoom.Add(student2);
classRoom.Add(student3);

classRoom.GetSortedStudents();
foreach (var student in classRoom)
{
    Console.WriteLine($"{student.Name} {student.Age} {student.Score}");
}

