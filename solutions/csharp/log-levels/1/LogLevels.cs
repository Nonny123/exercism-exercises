using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int start = logLine.IndexOf(": ")+2;

       return logLine.Replace("\t", "").Trim().Substring(start).TrimStart();
    }

    public static string LogLevel(string logLine)
    {
        int first = logLine.IndexOf("[")+1;
        int last = logLine.LastIndexOf("]");

       return logLine.Substring(first, last - first).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine)+ " ("+LogLevel(logLine)+")";
    }
}
