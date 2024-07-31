using System;


class _24_Method_Hiding
{
    // Method Hiding

    static void Main(string[] args)
    {
        Alto alt = new Alto("1234565");
        alt.mileage = 100;
        alt.speed = 40;
        alt.PrintCarDetails();

        Dzire dzire = new Dzire("LIC!@$#");
        dzire.mileage = 400;
        dzire.speed = 50;
        // Calling the hiding Method
        dzire.PrintCarDetails();


        // TypeCasting to call the parent method
        ((Car)dzire).PrintCarDetails();

        // Calling the Child class but it will trigger the parent class method
        Car dzireCar = new Dzire("SHR$#$");
        dzireCar.mileage = 430;
        dzireCar.speed = 60;
        dzireCar.PrintCarDetails();


    }
}

// Base Class
class Car
{
    public int speed;
    public int mileage;

    public void PrintCarDetails()
    {
        Console.WriteLine("Chasis of Car have {0} Speed and {1} Mileage", this.speed, this.mileage);
    }

    public void PrintCarID()
    {
        Console.WriteLine("1234343");
    }
}

// Child Class
class Alto : Car
{
    public string companyid;

    public Alto(string companyid)
    {
        this.companyid = companyid;
    }

}

// child class
class Dzire : Car
{
    public string companyLic;
    public Dzire(string companyLic)
    {
        this.companyLic = companyLic;
    }

    // Method Hiding
    public new void PrintCarDetails()
    {
        // calling the base class methods
        base.PrintCarID();
        Console.WriteLine("Dzire Car with {2} Chasis of Car have {0} Speed and {1} Mileage", this.speed, this.mileage, this.companyLic);
    }

    public void CarScrap()
    {
        Console.WriteLine("Car is Scrapped");
    }


}
