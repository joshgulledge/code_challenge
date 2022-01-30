using System;
using System.Collections.Generic;


namespace DailyTraining
{
    class Program
    {
      static void Main(string[] args)
      {

        var testOne = YourOrder.Order("is2 Thi1s T4est 3a");
        Console.WriteLine(testOne);

        var testTwo = YourOrder.Order("4of Fo1r pe6ople g3ood th5e the2");
        Console.WriteLine(testTwo);

        var testThree = YourOrder.Order("");
        Console.WriteLine(testThree);

      }      

    }
}

