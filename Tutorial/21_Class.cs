using System;


class _21_Class
{
    // Class Tutorial

    static void Main(string[] args)
    {
        // Creating the object of an Employee Class
        Employee emp = new Employee();
        emp.PrintEmployeeDetails();

        // Creating object with and arguments in the clas
        Employee emp1 = new Employee("Prathamesh", "Dhande");
        emp1.PrintEmployeeDetails();
    }

}


// Defining the Class
class Employee
{
    // Class Attributes
    string _firstname;
    string _lastname;

    // Constructor
    public Employee(string firstname, string lastname)
    {
        this._firstname = firstname;
        this._lastname = lastname;
    }

    // Default Constructor
    public Employee() : this("NO Employee", "No Employee") { }

    // Class Instance Methods
    public void PrintEmployeeDetails()
    {
        Console.WriteLine("Employee First Name:{0} , Last Name:{1}", this._firstname, this._lastname);
    }

    // Destructor
    ~Employee()
    {
        Console.WriteLine("Cleared");
    }

}
