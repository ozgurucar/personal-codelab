using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Id = 1,
            Name = "Ozgur",
            Age = 22,
            Department = "Ceng"
        };

        var repo = new StudentRepository();
        var list = new List<Student>();
        list.Add (student);

        repo.SaveAsTxt(list);
        // repo.SaveAsJson(list);

        var list2 = repo.LoadFromJson();
        foreach (var s in list2)
        {
            Console.WriteLine(s.Name);
        }
    }
} 