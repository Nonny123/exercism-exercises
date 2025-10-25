using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder sb = new StringBuilder();
         
		char[] lowercaseAlphabet = new char[]
         {
          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
          'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
         };

        foreach (char c in text)
        {
		  char lowerChar = char.ToLower(c);
          int index = Array.IndexOf(lowercaseAlphabet, lowerChar);
          if (index != -1) // make sure the character exists in the array
          {
			int newIndex = (index + shiftKey)  % lowercaseAlphabet.Length;
            
			  char item = lowercaseAlphabet[newIndex];
			
			 if(char.IsUpper(c))
			 {
				 item = char.ToUpper(item);
			 }
			  
             sb.Append(item);
          }
		  else
		  {
			 sb.Append(c);
		  }
			
        }
		
		return sb.ToString();
    }
}