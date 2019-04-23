using System;

namespace ProjectName
{
      public class Queen
      {

          public bool QueenAttack(int qx, int qy, int ox, int oy)
          {
              if(qx == ox)
              {
                return true;
              }
              if(qy == oy)
              {
                return true;
              }
              int difference = 0;
              if(qy > oy)
              {
                difference = qy - oy;
                if (Math.Abs(qx - ox) == difference)
                {
                  return true;
                }
              }else{
                difference = oy  - qy;
                if (Math.Abs(ox - qx) == difference)
                {
                  return true;
                }
              }
            return false;
          }


  }
}
