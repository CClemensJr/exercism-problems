using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        string[] responses = {"Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!", "Fine. Be that way!", "Whatever."};

        string allCaps = statement.ToUpper();
        string pattern = @"[a-zA-Z]+";
        Match hasLetters = Regex.Match(statement, pattern);

        if (hasLetters.Success)
        {
            if (statement == allCaps && statement.EndsWith("?")) return responses[2];
            if (statement.EndsWith("?")) return responses[0];
            if (statement == allCaps) return responses[1];
            if (statement == " ") return responses[3];

            return responses[4];
        }
        else
        {
            return responses[4];
        }
    }
}