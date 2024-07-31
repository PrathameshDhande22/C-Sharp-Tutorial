using System;
class _25_Polymorphism
{
    // Polymorphism tutorial
    static void Main(string[] args)
    {
        // Polymorphism calling Derived class from child class.
        College ft = new Faculty();
        College st = new Students();
        College head = new Head();
        College mgmt = new Management();

        ft.Details();
        st.Details();
        head.Details();
        mgmt.Details();
    }

}

class College
{
    // Virtual Method
    public virtual void Details()
    {
        Console.WriteLine("College Base");
    }
}

class Faculty : College
{

}

class Students : College
{
    // Override method
    public override void Details()
    {
        Console.WriteLine("College Base - Students");
    }

    public void StudentDetails()
    {
        Console.WriteLine("Student Details is Secured");
    }
}

class Head : College
{
    public override void Details()
    {
        Console.WriteLine("College Base - head of the Depts");
    }
}

class Management : College
{
    // Method Hiding
    public new void Details()
    {
        Console.WriteLine("Method Hiding");
    }

}