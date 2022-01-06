using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {
          string testOne = SolutionClass.EvenOrOdd(2);
          string testTwo = SolutionClass.EvenOrOdd(7);
          string testThree = SolutionClass.EvenOrOdd(-42);
          Console.WriteLine(testOne);
          Console.WriteLine(testTwo);
          Console.WriteLine(testThree);


      }

      public static (string color, long position) RedKnight(int knight, long pawn)
      {
        // Your solution goes here
        int knight_horizontal = 0;
        int knight_vertical = knight;

        while(knight_horizontal != pawn)
        {
          pawn++;
          knight_horizontal += 2;
          knight_vertical = (knight_vertical == 1) ? 0 : 1;
        }
        string pawn_color = (knight_vertical == 1) ? "Black" : "White";

        return (pawn_color, pawn);
      }

      public static (string color, long position) RedKnightTwo(int knight, long pawn)
      {
        // Your solution goes here
        string pawn_color = (((knight + (int)pawn) % 2) == 0) ? "White" : "Black";
        return (pawn_color, pawn*2);
      }

    }
}
