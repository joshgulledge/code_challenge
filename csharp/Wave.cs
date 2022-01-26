using System;
using System.Collections.Generic;


namespace DailyTraining
{
  public class Wave
  {
    /*
    loop through the OG string
    for each letter we make a new word 
    at the position of the loop make that char capital
    */
    public static List<string> DoTheWave(string str)
        {
          List<string> answer = new List<string>();

          for(int i = 0; i < str.Length; i++)
          {
            if (str[i] == ' ')
            {
              continue;
            }

            char[] charArr = new char[str.Length];
            for (int x = 0; x < str.Length; x++)
            {
              if (x == i)
              {
                charArr[x] = Char.ToUpper(str[x]);
              }
              else
              {
                charArr[x] = str[x];
              }
            }
            string word = new string(charArr);
            answer.Add(word);
          }
          return answer;
        }
  }
}