using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        string[] responses = {"Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!", "Fine. Be that way!", "Whatever."};
        char[] trimmings = {' '};

        string allCaps = statement.ToUpper();
        string trimString = statement.TrimEnd(trimmings);

        string letterPattern = @"[a-zA-Z]+";
        string allWhiteSpacePattern = @"^\s*$";

        Match hasLetters = Regex.Match(statement, letterPattern);
        Match hasWhiteSpaceOnly = Regex.Match(statement, allWhiteSpacePattern);

        if (hasLetters.Success)
        {
            if (statement == allCaps && statement.EndsWith("?")) return responses[2];
            if (trimString.EndsWith("?")) return responses[0];
            if (statement == allCaps) return responses[1];

            return responses[4];
        }
        else
        {
            if (statement.EndsWith("?")) return responses[0];
            if (hasWhiteSpaceOnly.Success) return responses[3];

            return responses[4];
        }
    }
}