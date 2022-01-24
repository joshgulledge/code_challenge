using System;
using System.Collections.Generic;


namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {
        var gunnersOne = new Dictionary<string, string>
          {
            {"Mike", "aye"},
            {"Joe", "aye"},
            {"Johnson", "aye"},
            {"Peter", "aye"}
          };

          var gunnersTwo = new Dictionary<string, string>
          {
            {"Mike", "aye"},
            {"Joe", "nay"},
            {"Johnson", "aye"},
            {"Peter", "aye"}
          };

        string testOne = PirateCannon.CannonsReady(gunnersOne);
        Console.WriteLine(testOne);

        string testTwo = PirateCannon.CannonsReady(gunnersTwo);
        Console.WriteLine(testTwo);

        
      }      

    }
}
