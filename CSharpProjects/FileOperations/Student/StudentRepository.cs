using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
class StudentRepository
{
    private string _textFile = "students.txt";

    public void SaveAsTxt(List<Student> studentList)
    {

        using (StreamWriter writer = new StreamWriter(_textFile))
        {

            foreach (var s in studentList)
            {
                writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Department}");
            }
        }
    }

    public List<Student> ReadFromTxt()
    {

        var students = new List<Student>();

        foreach (var line in File.ReadLines(_textFile))
        {
            var parts = line.Split(',');

            var student = new Student
            {

                Id = int.Parse(parts[0]),
                Name = parts[1],
                Age = int.Parse(parts[2]),
                Department = parts[3]
            };
            students.Add(student);
        }
        return students;
    }

    public void SaveAsJson(List<Student> studentList)
    {
        var jsonString = JsonSerializer.Serialize(studentList);
        File.WriteAllText("students.json", jsonString);
    }
    
    public List<Student> LoadFromJson()
    {
        var jsonString = File.ReadAllText("students.json");
        var students = JsonSerializer.Deserialize<List<Student>>(jsonString);
        return students;
    }
}
