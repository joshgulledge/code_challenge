using System;

namespace DailyTraining
{
  public class HighestLowest
  {
    public static string HighAndLow(string numbers)
    {
      int highest = Int32.MinValue;
      int lowest = Int32.MaxValue;
      
      string[] newArr = numbers.Split(" ");

      for (int i=0; i< newArr.Length; i++)
      {
        int current = Int32.Parse(newArr[i]);
        // Console.WriteLine($"{current} {highest} {lowest}");
        if (current > highest)
        {
          highest = current;
        }
        if (current < lowest)
        {
          lowest = current;
        }
      }

      return $"{highest} {lowest}";
    }
  }
}