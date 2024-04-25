using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class LogParser
{
    static string linePattern = "^\\[(TRC|DBG|INF|WRN|ERR|FTL)\\]";
    static string splitPattern = "<[\\^*=-]+>";
    static string pwPattern = "\".*(password).*\"";
    static string endoflinePattern = @"end-of-line\d+";
    static string badPassword = @"password\w+";
    
    public bool IsValidLine(string text)
    {
        Regex testLine = new Regex(linePattern);
        if (testLine.IsMatch(text))
            return true;
        else 
            return false;
    }

    public string[] SplitLogLine(string text)
    {
        Regex splitPoint = new Regex(splitPattern);        
        string[] substrings = splitPoint.Split(text);
        return substrings;
    }

    public int CountQuotedPasswords(string lines)
    {
        int quotedPW = 0;
        
        foreach (Match match in Regex.Matches(lines, pwPattern, RegexOptions.IgnoreCase))
            quotedPW += 1;
        
        return quotedPW;
     }

    public string RemoveEndOfLineText(string line)
    {
        string newLine = Regex.Replace(line, endoflinePattern, "");
        return newLine;
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        List<string> linesList = new List<string>();
         
        foreach (string line in lines)   
        {
            Match pwMatch = Regex.Match(line, badPassword, RegexOptions.IgnoreCase);
            if (pwMatch.Success)
                linesList.Add($"{pwMatch.Value}: {line}");
            else
                linesList.Add($"--------: {line}");
        }
        return linesList.ToArray();
    }
}
