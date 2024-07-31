using System;
class _28_Structs
{
    // Structure Tutorial

    static void Main(string[] args)
    {
        // Creating the object or instance of struct
        Computer compt = new Computer()
        {
            Name = "Gigabyte",
            Processor = "intel i5 10th"
        };

        // Calling method of struct
        compt.PrintDetails();
    }

}

// Creating Structure
public struct Computer
{
    private string _name;
    private string _processor;

    // Getter and setter in Struct
    public string Name { get => _name; set => _name = value; }
    public string Processor { get => _processor; set => _processor = value; }

    // Methods in Structure
    public void PrintDetails()
    {
        Console.WriteLine("Computer with Name = {0} and processor = {1}", this._name, this._processor);
    }

}

