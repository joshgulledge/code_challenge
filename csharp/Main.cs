using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {
        int testOne = SumOfDigits.DigitalRoot(16);
        Console.WriteLine(testOne); // should return 7

        int testTwo = SumOfDigits.DigitalRoot(942);
        Console.WriteLine(testTwo); // should return 6
      }      

    }
}
