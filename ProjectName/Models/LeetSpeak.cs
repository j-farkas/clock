using System;

namespace ProjectName
{
      public class LeetspeakTranslator
      {
          private string InputWords;

          public LeetspeakTranslator(string words)
          {
            char[] inputCharacters = words.ToCharArray();
            for (int i = 0; i < inputCharacters.Length; i++)
            {
              if (inputCharacters[i] == 's'){
                if(i == 0){

                }else if(inputCharacters[i-1] == ' ') {
                }else {
                  inputCharacters[i]=ReplaceLetter(inputCharacters[i]);
              }

              } else {
              inputCharacters[i]=ReplaceLetter(inputCharacters[i]);
              }
            }

            InputWords = string.Join("",inputCharacters);
          }

          public char ReplaceLetter(char characters)
          {
            if(characters == 'e') {
              return '3';
            }
            if(characters == 'o') {
              return '0';
            }
            if(characters == 'I') {
              return '1';
            }
            if(characters == 't') {
              return '7';
            }
            if(characters == 's') {
              return 'z';
            }
            return characters;
          }
        public void DisplayWords()
        {
          Console.WriteLine(InputWords);
        }
      }
  }
