static class LogLine
{
    public static string Message(string logLine)
    {
        string message = logLine.Split("]: ")[1].Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[");
        int end = logLine.IndexOf("]");
        return logLine.Substring(start + 1, end - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
    }
}
