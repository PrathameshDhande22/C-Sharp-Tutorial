using System;


class _42_Custom_Attributes
{
    // Using the Custom Attributes
    [ComputerLabel("i3", 4, "Dell Inspiron")]
    public void ComputerData() { }


    static void Main(string[] args)
    {

    }



}


// Creating Custom Attributes
// Specifying the attribute target, and allow multiple
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class ComputerLabelAttribute : Attribute
{
    string CPU;
    int cores;
    private string name;

    public ComputerLabelAttribute(string CPU, int cores, string names)
    {
        this.CPU = CPU;
        this.cores = cores;
        this.name = names;
    }
}
