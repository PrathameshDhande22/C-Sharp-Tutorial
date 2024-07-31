using System;
class _46_Override_Equals
{

    static void Main(string[] args)
    {
        Retailer r1 = new Retailer("Vaibhav", 23);
        Retailer r2 = new Retailer("Vaibhav", 23);

        Console.WriteLine(r1.Equals(r2));
    }

}

class Retailer
{
    public string name;
    public int id;

    public Retailer(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public override bool Equals(object obj)
    {
        Retailer ret = obj as Retailer;
        if (!string.IsNullOrWhiteSpace(ret.name))
        {
            if (ret.name == name && ret.id == id)
            {
                return true;
            }
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}