using System;

namespace genericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find maximum numbers");
            int output = findMaximumNumbers.findMaximumNumbersCheck(11, 22, 33);
            Console.WriteLine(output);
            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(11.7, 26.47, 70.56);
            //Console.WriteLine(doubleoutput);
            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("apple", "mango", "grapes");
            //Console.WriteLine(strigoutput);

            int[] intArray = { 11, 3442, 4032, 55, 68 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 1.2, 340.4, 44.36, 51.55, 67.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadKey();
        }
    }
}
        
    

