using System;
using System.Collections.Generic;
class _53_List_class
{
    static void Main(string[] args)
    {
        Student1 st1 = new Student1() { Id = 1, Name = "Prathamesh", Standard = "engg", Marks = 100 };
        Student1 st2 = new Student1() { Id = 2, Name = "Steve", Standard = "mengg", Marks = 40 };
        Student1 st3 = new Student1() { Id = 3, Name = "Blaze", Standard = "10th", Marks = 70 };
        Student1 st4 = new Student1() { Id = 4, Name = "Carry", Standard = "12th", Marks = 80 };

        // List Class
        List<Student1> students = new List<Student1>();

        // Adding the data in the list
        students.Add(st1);
        students.Add(st2);
        students.Add(st2);

        // iterating through list
        foreach (Student1 st in students)
        {
            Console.WriteLine(st);
        }

        // Count total number of elements present in the list
        Console.WriteLine("Total Number of student in list:{0}", students.Count);

        // Insert Method
        students.Insert(1, st4); // inserts the element at the given index in the list.
        foreach (Student1 st in students)
        {
            Console.WriteLine(st);
        }

        // Remove method
        Console.WriteLine();
        Console.WriteLine(students.Remove(st2)); // used to remove the element from the list
        foreach (Student1 st in students)
        {
            Console.WriteLine(st);
        }

        // RemoveAt method
        students.RemoveAt(1); // removes the element of the given index from the list
        Console.WriteLine();

        // Converting the list to array
        Student1[] sts=students.ToArray(); // return the array of student
        foreach(Student1 st in sts)
        {
            Console.WriteLine(st);
        }

        // index of method
        Console.WriteLine(students.IndexOf(st1));  // if found the element returns its index otherwise returns -1


        students.Add(st4);
        students.Add(st3);

        Console.WriteLine();
        // Exists method
        foreach (Student1 st in students)
        {
            Console.WriteLine(st);
        }
        Console.WriteLine(students.Exists(st=>st.Marks==100));

        // Find Method
        Console.WriteLine(students.Find(st=>st.Name.StartsWith("P")));

    }


}

