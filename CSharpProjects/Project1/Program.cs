// using System;
// namespace Project1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student("John Doe", new DateTime(2000, 1, 1));
//             Console.WriteLine($"Student Name: {student.Name}");

//             student.AddLesson(new Lesson("Math", "Basic Mathematics"));

//             var lessons1 = student.GetLessons();
//             foreach (var lesson in lessons1)
//             {
//                 Console.WriteLine($"Lesson Title: {lesson.Title}, Description: {lesson.Description}");
//             }

//             var mathLessons = from lesson in student.GetLessons()
//                               where lesson.Title == "Math"
//                               select lesson;
//             foreach (var lesson in mathLessons)
//             {
//                 Console.WriteLine($"Found Math lesson: {lesson.Title}, {lesson.Description}");
//             }

//             Classroom classroom = new Classroom("Class A", 2);
//             classroom.AddStudent(student);
//             Console.WriteLine(classroom.ToString());

//             Student student2 = new Student("Jane Smith", new DateTime(2001, 2, 2));

//             Console.WriteLine(student2.BirthDate);
//             Console.WriteLine((DateTime.Now - student2.BirthDate).GetType());
        
//         }



//     }
// }

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        var repo = new StudentRepository();
        // List<Student> students = new()
        // {
        //     new Student { Id = 1, Name = "Ali", Age = 20, Department = "Computer Science" },
        //     new Student { Id = 2, Name = "Ayşe", Age = 22, Department = "Mathematics" }
        // };

        // repo.SaveAsTxt(students);

        List<Student> loadedStudents = repo.LoadFromTxt();
        foreach (var student in loadedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
        }
    }
}

