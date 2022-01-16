using System;

namespace DailyTraining
{
  public class FindOddInt
  {
    public static int find_it(int[] seq) 
      {
        int count = 0;
        int oddNumber = 0;

        for (int i = 0; i < seq.Length; i++)
        {
          for (int x = 0; x < seq.Length; x++)
          {
            bool doTheyMatch = seq[i] == seq[x];

            if (doTheyMatch)
            {
              count++;
            }

          }

          bool isOddNumber = count % 2 != 0;

          if (isOddNumber)
          {
            oddNumber = seq[i];
          }
          count = 0;
        }
        
        return oddNumber;
      }
  }
}