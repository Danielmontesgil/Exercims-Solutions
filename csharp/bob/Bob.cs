using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        if (!statement.Equals(statement.ToUpper()) || statement.Equals(statement.ToLower()))
        {
            return statement.EndsWith('?') ? "Sure." : "Whatever.";
        }

        return statement.EndsWith('?') ? "Calm down, I know what I'm doing!" : "Whoa, chill out!";
    }
    
    // Better performance
    // private static bool IsShout(string input) => input.Any(c => char.IsLetter(c)) && input.ToUpper() == input;
    //
    // public static string Response(string statement)
    // {
    //     var input = statement.TrimEnd();
    //     if (input == "")
    //         return "Fine. Be that way!";
    //
    //     switch ((input.EndsWith('?'), IsShout(input)))
    //     {
    //         case (true, true): return "Calm down, I know what I'm doing!";
    //         case (_, true): return "Whoa, chill out!";
    //         case (true, _): return "Sure.";
    //         default: return "Whatever.";
    //     }
    // }
}