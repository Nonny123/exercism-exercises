public static class Pangram
{
    public static bool IsPangram(string input)
    {
         if(input.Length < 26)
            return false;

       char[] alphabet = new char[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
		
		int count = 0;

        foreach (char letter in alphabet)
        {
            if(input.ToLower().Contains(letter))
			  count++;			
        }
		
		if(count == 26)
		  return true;
		
		return false;
       
    }
}
