namespace Project1;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;


public class StudentRepository
{
    private string textFile = "students.txt";
    private string xmlFile = "students.xml";
    private string jsonFile = "students.json";

    public void SaveAsTxt(List<Student> students)
    {
        using (StreamWriter writer = new StreamWriter(textFile))
        {
            foreach (var s in students)
            {
                writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Department}");
            }
        }
    }

    public List<Student> LoadFromTxt()
    {
        var students = new List<Student>();

        foreach (var line in File.ReadLines(textFile))
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


}
