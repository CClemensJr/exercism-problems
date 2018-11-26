using System;

public static class Bob
{
    public static string Response(string statement)
    {
        string[] responses = {"Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!", "Fine. Be that way!", "Whatever."};

        return responses[4];
    }
}