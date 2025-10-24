

// Person person1 = new("John", "Doe");

// String[] names = { "Alice", "Bob", "Charlie", "David" };

// var namesV2 = names.Where(name => name.Length >= 5)
//     .Select(name => name + " !")
//     .ToList();

// foreach (var name in namesV2)
// {
//     Console.WriteLine(name);
// }

// if (person1.FirstName is "John") Console.WriteLine("Hello John");

// static void Greet(Person person,Action<string> func)
// {
//     Console.WriteLine("Greeted:");
//     func($"{person.FirstName} {person.LastName}");
// }

// Greet(person1, Console.WriteLine);

// string? s = null;

// Person? person2 = null;

// try {
// Console.WriteLine(person2.FirstName);
// } catch (NullReferenceException ex) {
//     Console.WriteLine("Caught NullReferenceException when accessing person2.FirstName");
//     Console.WriteLine(ex.Message);
// }
//     Console.WriteLine(s ?? "Default Value");


// Student student = new("Emily", "Brown", 10);
// student.Speak();

// Student student2 = new("Michael", "Black", 11);
// student.Greet(student2);

// if (student is Human human)
// {
//     Console.WriteLine($"Student's name is {human.Name} and hair color is {human.HairColor}");
// }

// if (student is IGreetable greetable)
// {
//     greetable.Greet(student2);
// }

//     int x = int.MaxValue;
//     System.Console.WriteLine(x);
//     x = x + 123412421;
//     System.Console.WriteLine(x);


// abstract class Human
// {
//     public string Name { get; }
//     public string HairColor { get; }

//     public Human(string name, string hairColor)
//     {
//         Name = name;
//         HairColor = hairColor;
//     }


//     public abstract void Speak();
// }

// class Student : Human, IGreetable
// {
//     public Student(string name, string hairColor, int grade)
//     : base(name, hairColor)
//     {
//         Grade = grade;
//     }
//     public int Grade { get; set; }

//     public void Greet(Student other)
//     {
//         Console.WriteLine($"Hello {other.Name}, my name is {Name}.");
//     }


//     public override void Speak()
//     {
//         Console.WriteLine($"Hello, my name is {Name} and my hair color is {HairColor}.");
//     }
// }

// interface IGreetable
// {
//     void Greet(Student other);
// }



// record Person(string FirstName, string LastName);


double x = 10;
double y = 0;

string input = Console.ReadLine();

if(String.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided.");
}
else 
{
    Console.WriteLine($"Input is {input}");
}