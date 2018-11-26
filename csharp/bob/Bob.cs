using System;

public static class Bob
{
    public static string Response(string statement)
    {
        string[] responses = {"Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!", "Fine. Be that way!", "Whatever."};

        string allCaps = statement.ToUpper();

        if (statement.EndsWith("?")) return responses[0];
        if (statement.EndsWith("!")) return responses[1];
        if (statement == allCaps && statement.EndsWith("?")) return responses[2];
        if (statement == " ") return responses[3];


        return responses[4];
    }
}