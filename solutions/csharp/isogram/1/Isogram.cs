public static class Isogram
{
   
    public static bool IsIsogram(string word)
    {
	   var lowerCased = word.ToLower();
		
       for(int i = 0; i < lowerCased.Length; i++)
		{
			char currentLetter = lowerCased[i];
			if(char.IsLetter(currentLetter))
			{
				string result = lowerCased.Remove(i, 1);
				if(result.Contains(currentLetter))
			  	return false;
			}
		}
				
		return true;
    }
}
