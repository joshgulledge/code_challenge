using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {

        string testOne = HighestLowest.HighAndLow("1 2 3 4 5");
        Console.WriteLine(testOne); // should return "5 1"

        string testTwo = HighestLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
        Console.WriteLine(testTwo); // return "42 -9"

        string testThree = HighestLowest.HighAndLow("1 9 3 4 -5");
        Console.WriteLine(testThree); // should return "9 -5"
      }      

    }
}
