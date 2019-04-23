using System;
using System.Collections.Generic;

namespace ProjectName{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to be translated into LeetSpeak:");
      string sentence = Console.ReadLine();
      LeetspeakTranslator userInput = new LeetspeakTranslator(sentence);

      userInput.DisplayWords();
    }
  }
}
