using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Please enter a secret code: ");
      string secretMessage = Console.ReadLine();
      char[] msgArray = secretMessage.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];

        int letterPos = Array.IndexOf(alphabet, letter);
        int newLetterPos = (letterPos + 3) % alphabet.Length;

        char encryptedChar = alphabet[newLetterPos];

        msgArray[i] = encryptedChar;
      }

      string encodedString = String.Join("", msgArray);
      Console.WriteLine(encodedString);
    }
  }
}