using System;
using System.Collections.Generic;

namespace ProjectName{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Your Queen's y-coordinate:");
      int qy = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Your Queen's x-coordinate:");
      int qx = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Your Other Piece's y-coordinate:");
      int oy = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Your Queen's y-coordinate:");
      int ox = int.Parse(Console.ReadLine());
      Queen inputtedPositions = new Queen();
      bool canAttack = inputtedPositions.QueenAttack(qx,qy,ox,oy);

      Console.WriteLine(canAttack);
    }
  }
}
