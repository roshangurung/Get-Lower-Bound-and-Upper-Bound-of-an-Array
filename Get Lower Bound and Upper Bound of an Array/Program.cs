using System;

namespace Get_Lower_Bound_and_Upper_Bound_of_an_Array
{
    class Program
    {
        static void Main(string[] args)////In this C# program, using setvalue() function create an object for string Array. For loop is used assign the coefficient element values of an array. Here the GetLowerBound and GetUppperBound methods return the lower and upper bounds of an array respectively. Print the lower bound and upper bound of an array.////
        {
            Array stringArray = Array.CreateInstance(typeof(String), 6);
            stringArray.SetValue("Mango", 0);
            stringArray.SetValue("Orange", 1);
            stringArray.SetValue("Apple", 2);
            stringArray.SetValue("Grape", 3);
            stringArray.SetValue("Cherry", 4);
            stringArray.SetValue("WaterMelon", 4);
            Console.WriteLine("The Lower Bound of the Array : {0}",
                              stringArray.GetLowerBound(0).ToString());
            Console.WriteLine("The Upper Bound of the Array : {0}",
                              stringArray.GetUpperBound(0).ToString());
            Console.ReadLine();

        }
    }
}
////Ouput
////The Lower Bound of the Array is 0
////The Upper Bound of the Array is 4
