using System;
using System.Reflection;

class _43_Reflection
{
    // Reflection Example
    static void Main(string[] args)
    {
        // Getting the types and properties of a studentTable
        Type T = typeof(StudentTable);

        // Info of the Student Table
        Console.WriteLine("Type of the Student Table : {0}",T.Name);
        Console.WriteLine(T.FullName);


        Console.WriteLine("\nProperties Present in the Table");    
        // Getting the Properties Present in the Table
        PropertyInfo[] pi = T.GetProperties();
        foreach(PropertyInfo pi2 in pi)
        {
            Console.WriteLine($"Property : {pi2.Name}, Type: {pi2.PropertyType}");
        }

        // Methods in the Table
        Console.WriteLine("\nMethods Present in the Table");
        MethodInfo[] mi=T.GetMethods();
        foreach (MethodInfo mi2 in mi)
        {
            Console.WriteLine($"Method : {mi2.Name}, Return Type: {mi2.ReturnType}");
        }

        // Constructor Present in the table
        Console.WriteLine("\nConstructor Present in the Table");
        ConstructorInfo[] ci = T.GetConstructors();
        foreach (ConstructorInfo ci2 in ci)
        {
            Console.WriteLine($"Constructor : {ci2}");
        }
    }
}

class StudentTable
{

    public string Name { get; set; }
    public string Branch { get; set; }

    public int id { get; set; }

    public StudentTable() { }

    public StudentTable(string name, string branch, int id)
    {
        Name = name;
        Branch = branch;
        this.id = id;
    }


    public void DeleteStudent(int id)
    {
        Console.WriteLine("Delete Student Record");
    }

}

