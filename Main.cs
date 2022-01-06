using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {
          var testOne = RedKnightClass.RedKnight(0,8); //should return ["White", 16]
          Console.WriteLine(testOne);
          var testTwo = RedKnightClass.RedKnight(0,7); //should return ["Black", 14]
          Console.WriteLine(testTwo);

          // string testOne = SolutionClass.EvenOrOdd(2);
          // string testTwo = SolutionClass.EvenOrOdd(7);
          // string testThree = SolutionClass.EvenOrOdd(-42);
          // Console.WriteLine(testOne);
          // Console.WriteLine(testTwo);
          // Console.WriteLine(testThree);

      }      

    }
}
