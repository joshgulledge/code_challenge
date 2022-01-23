using System;

namespace DailyTraining
{
  public class ReverseString
  {
    public static string Solution(string str)
    {
      char[] charArr = str.ToCharArray();
      Array.Reverse(charArr);
      return new string(charArr);
    }
    
  }
}