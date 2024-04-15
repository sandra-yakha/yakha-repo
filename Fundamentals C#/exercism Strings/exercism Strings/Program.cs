using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int i = logLine.IndexOf(':') + 1;
        string result = logLine.Substring(i).Trim();
        return result;
    }

    public static string LogLevel(string logLine)
    {
        int a = logLine.IndexOf(':') - 2;
        string result = logLine.Substring(1, a).ToLower();
        return result;

    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
