using System;
using System.Collections.Generic;

namespace ProjectName{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your hour:");
      double hours = double.Parse(Console.ReadLine());
      Console.WriteLine("Enter your minutes:");
      double mins = double.Parse(Console.ReadLine());

      Clock angleBetween = new Clock();

      double answer = angleBetween.AngleDifference(hours, mins);

      Console.WriteLine(answer);
    }
  }
}
