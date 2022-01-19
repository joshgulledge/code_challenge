using System;

namespace DailyTraining
{
  public class SumOfDigits
  {
    public static int DigitalRoot(long n)
    {
      long root = 0;

      while (n > 0 || root > 9)
      {
        if (n==0)
        {
          n = root;
          root = 0;
        }
        root += n % 10;
        n /= 10;
      }
      return (int)root;
    }
  }
}