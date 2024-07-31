using System;


class _34_Delegates
{

    // Declaring Delegates
    public delegate void TrainModel(int modelNo);

    static void Main(string[] args)
    {
        // Creating the instance of Delegate Function
        TrainModel tml = new TrainModel(FoodPredictionModel);

        // Calling the delegate Function
        tml(6778);

       
    }

    // Declaring function similar to delegate signature
    public static void FoodPredictionModel(int ModelNo)
    {
        Console.WriteLine("Food Prediction Model with Model No {0}", ModelNo);
    }

}

