using System;

namespace ProjectName
{
      public class PingPong
      {
          private string[] Arr;

          public PingPong(int number)
          {
            Arr = new string[number];
            for(int i = 0;i<number;i++)
            {
              Arr[i] = ReplaceNumber(i+1);
            }
          }

          public string ReplaceNumber(int number)
          {
            if(number%15 == 0){
              return "ping-pong";
            }
            if(number%3 == 0){
              return "ping";
            }
            if(number%5 == 0){
              return "pong";
            }
            return number.ToString();
          }

          public void DisplayString()
          {
            foreach (string arrayNumber in Arr){
              Console.WriteLine(arrayNumber);
            }
          }
      }


  }
