using System;

namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {
          // var answerOne = RedKnight(0, 8); // should return ("white", 16)
          // Console.WriteLine(answerOne);
          // var answerTwo = RedKnight(0, 7); // should return ("Black", 14)
          // Console.WriteLine(answerTwo);
          // var answerThree = RedKnight(1, 6); // should return ("Black", 12)
          // Console.WriteLine(answerThree);
          // var answerFour = RedKnight(1, 5); // should return ("White", 10)
          // Console.WriteLine(answerFour);

          var answerOne = RedKnightTwo(0, 8); // should return ("white", 16)
          Console.WriteLine(answerOne);
          var answerTwo = RedKnightTwo(0, 7); // should return ("Black", 14)
          Console.WriteLine(answerTwo);
          var answerThree = RedKnightTwo(1, 6); // should return ("Black", 12)
          Console.WriteLine(answerThree);
          var answerFour = RedKnightTwo(1, 5); // should return ("White", 10)
          Console.WriteLine(answerFour);
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
