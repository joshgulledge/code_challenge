using System;

namespace DailyTraining
{
  public class YourOrder
  {
    public static string Order(string words)
    {
      string[] singleWords = words.Split(' ');
      string[] answer = new string[singleWords.Length];
      for (var w = 0; w < singleWords.Length; w++)
      {
        for (var i = 0; i < singleWords[w].Length; i++)
        {
          if (singleWords[w][i] == ' ') continue;
          if (Char.IsDigit(singleWords[w][i]))
          {
            var position = int.Parse(singleWords[w][i].ToString());
             answer[position-1] = singleWords[w];
          }
        }
      }
      return string.Join(" ", answer);
    }
  }
}