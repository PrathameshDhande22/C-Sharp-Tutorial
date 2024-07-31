using System;


class _05_Nullable_Types
{
    public static void Main(string[] args)
    {

        // Defining the null values to the variable
        string name = null;
        Console.WriteLine(name);

        // Defining the null value to the integer datatype
        int? no = null;
        Console.WriteLine(no);

        // Same for the boolean datatype
        bool? isHuman = null;
        isHuman = true;
        Console.WriteLine(isHuman.Value);  // Throws exception if got the nullable object

        // Null Coalescing Operator
        int? rainPercent = null;
        //rainPercent = 10;
        //int raintoFallinMM = rainPercent; we can't directly assign the nullable value to the non-nullable variable to handle such we need to use these operator else you can also use .Value variable but it will throws exception if he got the nullable value
        int raintofallinMM = rainPercent * 10 ?? 0;

        Console.WriteLine(raintofallinMM);
    }

}