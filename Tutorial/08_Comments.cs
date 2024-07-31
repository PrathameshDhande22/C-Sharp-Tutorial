using System;

class _08_Comments
{

    static void Main(string[] args)
    {
        // Single Line Comments


        /*
         Multiline Line Comments

                Multiline Comments




         */
        SampleClass sample = new SampleClass();

    }

}
// Documentation Comments
/// <summary>
/// These the Sample Created by me
/// <code>
/// int a=100;
/// Console.WriteLine(a);
/// 
/// </code>
/// </summary>
public class SampleClass
{
    public int Id()
    {
        return 2;
    }
}