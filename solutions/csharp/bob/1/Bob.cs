using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isAllUpper = !string.IsNullOrEmpty(statement) && statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper);

        bool endsWithQuestionMark = !string.IsNullOrWhiteSpace(statement) && statement.TrimEnd().EndsWith('?');
        
        if(statement.Contains('?') && isAllUpper)
            return "Calm down, I know what I'm doing!";
        if(endsWithQuestionMark)
            return "Sure.";
        if(isAllUpper)
            return "Whoa, chill out!";      
        if(string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";


        return "Whatever.";
    }
}