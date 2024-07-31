using System;
using System.Collections.Generic;
using System.Linq;
class _50_Indexers
{
    static void Main(string[] args)
    {
        // Using Indexers
        ASUS asus = new ASUS();

        // Accessing the index 2 Laptop Name
        Console.WriteLine(asus[2]);

        // Changing the name of index 2 laptop
        asus[2] = "Vivobook";
        Console.WriteLine(asus[2]);

        // Accessing the index 2 Processor
        Console.WriteLine(asus["AMD Ryzen 5"]);

        // Setting the index 2 Processor
        asus["AMD Ryzen 5"] = "i9 10th";
        Console.WriteLine(asus["i9 10th"]);
    }
}


class Laptop
{
    public string Name { get; set; }
    public string Processer { get; set; }
    public int Id { get; set; }
}

// Creating Indexers
class ASUS
{
    private List<Laptop> list;
    public ASUS()
    {
        list = new List<Laptop>();
        list.Add(new Laptop { Id = 1, Name = "TUF Gaming F15", Processer = "i5 10th" });
        list.Add(new Laptop { Id = 2, Name = "TUF Gaming A15", Processer = "AMD Ryzen 5" });
        list.Add(new Laptop { Id = 3, Name = "ROG", Processer = "i5 13th" });
        list.Add(new Laptop { Id = 4, Name = "TUF Gaming F15", Processer = "i5 8th" });
        list.Add(new Laptop { Id = 5, Name = "Notebook", Processer = "i5 10th" });

    }

    // creating indexers using this keyword
    public string this[int id]
    {
        // getting the Name of the passed index
        get
        {
            return list.FirstOrDefault(laps => laps.Id == id).Name;
        }

        // setting the name of the passed index
        set
        {
            list.FirstOrDefault(laps => laps.Id == id).Name = value;
        }
    }

    // Overloading indexers
    public string this[string processor]
    {
        get
        {
            return list.Find(match => match.Processer == processor).Processer;
        }
        set
        {
            list.Find(match => match.Processer == processor).Processer = value;
        }
    }
}
