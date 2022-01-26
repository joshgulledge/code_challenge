using System;
using System.Collections.Generic;


namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {

        var testOne = Wave.DoTheWave("hello");
        foreach (var word in testOne)
        {
          Console.WriteLine(word);
        }

        var testTwo = Wave.DoTheWave("codewars");
        foreach (var word in testTwo)
        {
          Console.WriteLine(word);
        }

        var testThree = Wave.DoTheWave("two words");
        foreach (var word in testThree)
        {
          Console.WriteLine(word);
        }
      }      

    }
}

