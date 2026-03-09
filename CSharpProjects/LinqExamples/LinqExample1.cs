using System;
using System.Collections.Generic;
using System.Linq;

var list = Data.GetStudents();

foreach(var s in list) {

Console.WriteLine(s.Id);
}


var grp = list.GroupBy(l => l.No.Substring(0,4)).Select(g => new {Prelude = g.Key, Count = g.Count()});

foreach (var g in grp) {
	Console.WriteLine(g.Prelude + " " + g.Count );
}




public static class Data 
{

	public static List<Student> GetStudents(){
		var list = new List<Student>();
		
		var student = new Student {
			No = "2021510142",
			Name = "Özgür",
			LastName = "Uçar"
		};
		
		list.Add(student);

		student = new Student {
			No = "2022510200",
			Name = "Ahmet",
			LastName = "Demir"
		};


		list.Add(student);
		
		student = new Student {
			No = "2022510134",
			Name = "Doğukan",
			LastName = "Sarı"
		};
	
		list.Add(student);
		
		return list;
	}
	
}

public class Student 
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string No { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	public List<Guid> Lectures  { get; set; }= new List<Guid>();
}

public class ClassRoom 
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid LecturerId { get; set; }
	public string Label { get; set; }
}

public class Lecture 
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; }
	public int Akts { get; set; }
	public Guid LecturerId { get; set; }
}


public class Lecturer 
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string FullName { get; set; } 
}
