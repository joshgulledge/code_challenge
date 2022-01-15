using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {

        var testOne = FindOddInt.find_it(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }); //should return 5
        Console.WriteLine(testOne);

        var testTwo = FindOddInt.find_it(new[] { 1,1,2,-2,5,2,4,4,-1,-2,5 }); //should return -1
        Console.WriteLine(testTwo);

        var testThree = FindOddInt.find_it(new[] { 1,1,1,1,1,1,10,1,1,1,1 }); //should return 10
        Console.WriteLine(testThree);

          // var testOne = RedKnightClass.RedKnight(0,8); //should return ["White", 16]
          // Console.WriteLine(testOne);
          // var testTwo = RedKnightClass.RedKnight(0,7); //should return ["Black", 14]
          // Console.WriteLine(testTwo);

          // string testOne = SolutionClass.EvenOrOdd(2);
          // string testTwo = SolutionClass.EvenOrOdd(7);
          // string testThree = SolutionClass.EvenOrOdd(-42);
          // Console.WriteLine(testOne);
          // Console.WriteLine(testTwo);
          // Console.WriteLine(testThree);

      }      

    }
}
