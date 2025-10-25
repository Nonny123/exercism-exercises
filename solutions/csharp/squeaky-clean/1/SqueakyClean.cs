using System;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = Regex.Replace(identifier, @"\s", "_"); //replace any spaces with underscores
        identifier = Regex.Replace(identifier, "\\0", "CTRL");// replace control characters with the upper case string "CTRL"
        identifier = Regex.Replace(identifier, @"-\D", new MatchEvaluator(ConvertToCamelCase)); //convert kebab-case to camelCase - à-ḃç" => "àḂç"
        return Regex.Replace(identifier, @"[α-ω]|\d|\W", "");//remove non-letters and Greek letters in the range  'α' to 'ω'
    }


    private static string ConvertToCamelCase(Match mt)
	{
		return mt.Value[1].ToString().ToUpper();
	}

}