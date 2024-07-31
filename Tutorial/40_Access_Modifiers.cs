using System;



class _40_Access_Modifiers
{

    static void Main(string[] args)
    {
        Strong sg = new Strong();

        // Accessing Public members
        sg.isStrongClass = false;



    }

}


// Access modifiers
class Strong
{
#pragma warning disable
    // Private type members
    private int id = 102;

    // Protected Type Members
    protected string name;

    // Public Type members
    public bool isStrongClass;

    // private protected members
    private protected string gender;

    // private method
    private void CallStrongMethod()
    {
        // Using the private members
        this.id = 1;
        Console.WriteLine("Called Strong Class private Method");
    }
}

class Weak : Strong
{
    public void TryWeakClass()
    {
        // Accessing Private Type Members
        // this.id => Throws error

        // Accessing the Protected Members available to only derived class
        Console.WriteLine(this.name);
        Weak wk = new Weak();
        wk.name = "Prathamesh";

        // Accessing the private protected members
        wk.gender = "Male";




        // Calling private Method
        //this.CallStrongMethod(); throws Error


    }
}