using System;
class _30_Interfaces
{

    static void Main(string[] args)
    {
        // Calling the interface from Bank Class
        IConsumer1 cons = new BankBranch();
        cons.Method1();

        // Calling the methods of Interface from class
        BankBranch bb = new BankBranch();
        bb.Method1();
        bb.Process();

        BankStaff staff = new BankStaff();
        staff.Method1();
        staff.Process();
        staff.StaffUnderConsumer();
    }

}

// Creating Interfaces
interface IConsumer1
{
    void Method1();
}

interface IBank
{
    void Process();
}


//Interface Inheriting the Interface
interface IStaff : IConsumer1, IBank
{
    void StaffUnderConsumer();
}


class BankStaff : IStaff
{

    public void Method1()
    {
        
        Console.WriteLine("method 1 of interface from staff");
    }

    public void Process()
    {
        Console.WriteLine("process method of interface from staff");
    }

    public void StaffUnderConsumer()
    {
        Console.WriteLine("staffunderconsumer method of interface from staff");
    }
}

// Inheriting multiple Interfaces
class BankBranch : IConsumer1, IBank
{
    public void Method1()
    {
        Console.WriteLine("Method 1 of Interface Consumer 1");
    }

    public void Process()
    {
        Console.WriteLine("Method Process of Interface Bank");
    }
}

