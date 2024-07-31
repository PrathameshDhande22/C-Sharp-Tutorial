using System;


// Base Class
class Human
{
    int age;
    string profession;

    public Human(int age, string profession)
    {
        this.age = age;
        this.profession = profession;
    }

    public Human()
    {
        Console.WriteLine("Human Constructor is called with empty");
    }

    public void print()
    {
        Console.WriteLine("Age is {0} and Profession is {1}", this.age, this.profession);
    }

}


// child Class
class Man : Human
{
    int earns;
    // Base calling the base class constructor
    public Man(int earns, int age, string profession) : base(age, profession)
    {
        this.earns = earns;
    }
}

class Woman : Human
{
    int works;
    public Woman(int works)
    {
        Console.WriteLine("Woman Constructor Called");
        this.works = works;
    }
}


class _23_Inheritance
{
    // Inheritance Tutorial

    static void Main(string[] args)
    {
        Man mn = new Man(earns: 23000, age: 21, profession: "Software");
        mn.print();

        Woman wn = new Woman(23);

    }

}
