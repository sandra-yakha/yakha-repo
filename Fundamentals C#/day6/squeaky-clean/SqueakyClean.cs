using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = Regex.Replace(identifier, @"\s", "_");
        identifier = Regex.Replace(identifier, @"\0", "CTRL");
        identifier = Regex.Replace(identifier, @"-\D", new MatchEvaluator(ToCamelCase));
        return identifier = Regex.Replace(identifier, @"[α-ω]|\W|\d", "");
    }

    private static string ToCamelCase(Match match)
    {
        return match.Value[1].ToString().ToUpper();
    }
}