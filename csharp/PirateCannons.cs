using System;
using System.Collections.Generic;


namespace DailyTraining
{
  public class PirateCannon
  {
    public static string CannonsReady(Dictionary<string, string> gunners)
    {
      if (gunners.ContainsValue("nay"))
      {
        return "Shiver me timbers!";
      }
      return "Fire!";
    }
    
  }
}