using System;

namespace ProjectName
{
      public class LeetspeakTranslator
      {
          private string InputWords;

          public LeetspeakTranslator(string words)
          {
            InputWords = words;
            char[] inputCharacters = words.ToCharArray();
            for (int i = 0; i < inputCharacters.Length; i++)
            {
              inputCharacters[i]=ReplaceLetter(inputCharacters[i]);
            }
          }

          public char ReplaceLetter(char characters)
          {
            if(characters == 'e') {
              return '3';
            }
            if(characters == 'o') {
              return '0';
            }

            return characters;
          }


      }


  }
