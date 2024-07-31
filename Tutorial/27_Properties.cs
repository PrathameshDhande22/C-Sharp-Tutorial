using System;
class _27_Properties
{
    static void Main()
    {
        // Getting and setting the value 
        Student stud = new Student();
        stud.Age = 21;
        stud.City = "Boisar";
        Console.WriteLine("Student with Age ={0} & City ={1}", stud.Age, stud.City);


        // Other way to set the property
        Student stud2 = new Student()
        {
            Age = 30,
            City = "Ahemdabad"
        };
    }
}

class Student
{
#pragma warning disable CS0169 // The field 'Student.city' is never used
    private string city;
#pragma warning restore CS0169 // The field 'Student.city' is never used
    private int age;

    // getter and setter in age 
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value == 100)
            {
                throw new Exception("Age cannot be greater or less than 0 or 100");
            }

            this.age = value;
        }
    }

    // getter and setter without using any additional logic
    public string City { get; set; }


}

