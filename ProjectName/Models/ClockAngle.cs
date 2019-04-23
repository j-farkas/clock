using System;

namespace ProjectName
{
      public class Clock
      {


        public double AngleDifference(double hours, double mins)
        {
          hours = hours % 12;
          double hoursAngle = (hours * 30) + (mins * 0.5);
          double minsAngle = (mins * 6);
          hoursAngle = Math.Abs(hoursAngle - minsAngle);
          if(hoursAngle > 180)
          {
            hoursAngle = 360 - hoursAngle;
          }

          return hoursAngle;
        }



  }
}
