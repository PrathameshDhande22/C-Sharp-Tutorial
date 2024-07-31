using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
class _52_Dictionary
{
    static void Main(string[] args)
    {
        // Dictionary initialization
        Dictionary<int, Student1> students = new Dictionary<int, Student1>();

        // Adding values to the dictionary
        students.Add(1, new Student1() { Id = 1, Name = "Prathamesh", Standard = "engg", Marks = 100 });
        students.Add(2, new Student1() { Id = 2, Name = "Steve", Standard = "mengg", Marks = 40 });
        students.Add(3, new Student1() { Id = 3, Name = "Blaze", Standard = "10th", Marks = 70 });

        // Another Way of adding the values to the dictionary
        students[43] = new Student1() { Id = 43, Name = "Berkely", Standard = "UG", Marks = 60 };

        // Accessing the particular value by giving the key
        Console.WriteLine("Accessing particular Value");
        Console.WriteLine(students[2]);

        // Iterating through the dictionary
        Console.WriteLine("\nIterating through each");
        foreach (KeyValuePair<int, Student1> kvp in students)
        {
            Console.WriteLine($"Key={kvp.Key} Value={kvp.Value}");
        }

        // Getting only the values from the dictionary
        Console.WriteLine("\nValues in Dictionary");
        foreach (Student1 val in students.Values)
        {
            Console.WriteLine(val);
        }

        // Getting only the keys from the dictionary
        Console.WriteLine("\nKeys in Dictionary");
        foreach (int kys in students.Keys)
        {
            Console.WriteLine(kys);
        }

        // TryGetValue() method
        Console.WriteLine(students.TryGetValue(3, out Student1 goSt));
        Console.WriteLine(goSt);

        // if not found the key then
        Console.WriteLine(students.TryGetValue(7, out Student1 goSt1));
        Console.WriteLine(goSt1); // return null

        // Count Property
        Console.WriteLine("Total Number of Students : {0}", students.Count);

        // Count Method from Linq extension method
        Console.WriteLine("Total Number of Students : {0}", students.Count());
        // To query the count method 
        Console.WriteLine("Total Number of Students with Marks greater than 50: {0}", students.Count(st => st.Value.Marks >= 50));

        // Remove Method
        Console.WriteLine(students.Remove(2));

        // Clear method
        //students.Clear();


        // Ways to convert array into dictionary
        Student1[] sts = { new Student1() { Id = 1, Name = "Prathamesh", Standard = "engg", Marks = 100 }, new Student1() { Id = 2, Name = "Steve", Standard = "mengg", Marks = 40 }, new Student1() { Id = 3, Name = "Blaze", Standard = "10th", Marks = 70 } };

        Dictionary<int, Student1> dict1 = sts.ToDictionary(st => st.Id);
        foreach (var ky in dict1)
        {
            Console.WriteLine(ky);
        }


        // Updating the value in the dictionary
        Console.WriteLine("\nUpdated the value at index 2");
        students[2] = new Student1() { Id = 4, Name = "Robert", Standard = "PG", Marks = 90 };
        foreach (var kv in students)
        {
            Console.WriteLine(kv);
        }
    }
}


class Student1
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Standard { get; set; }
    public int Marks { get; set; }

    public override string ToString()
    {
        return $"Student(Id={Id},Name={Name},Standard={Standard},Marks={Marks})";
    }
}
