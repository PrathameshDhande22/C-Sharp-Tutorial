using System;

class _33_Multiple_inheritance
{
    // Multiple inheritance can be achieved using interfaces
    static void Main(string[] args)
    {
        AB ab = new AB();
        ab.BMethod();
        ab.AMethod();
    }

}

// First Interface
interface IA
{
    void AMethod();
}

class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A Method");
    }
}

// Second Interface
interface IB
{
    void BMethod();
}
class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B Method");
    }
}

// Multiple Inheritance Using Interface
class AB : IA, IB
{
    public void AMethod()
    {
        A a = new A();
        a.AMethod();
    }

    public void BMethod()
    {
        B b = new B();
        b.BMethod();
    }
}
