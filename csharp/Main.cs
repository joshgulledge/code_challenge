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

        int testThree = SumOfDigits.DigitalRoot(132189);
        Console.WriteLine(testThree); // should return 6

        int testFour = SumOfDigits.DigitalRoot(493193);
        Console.WriteLine(testFour); // should return 2
      }      

    }
}
