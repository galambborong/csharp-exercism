using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        var logLevelEndIndex = logLine.IndexOf(':') + 2;

        return logLine.Substring(logLevelEndIndex).Trim();
    }

    public static string LogLevel(string logLine)
    {
        var logLevelEndIndex = logLine.IndexOf(':');
        var rawLogLevel = logLine[..logLevelEndIndex];

        var formattedLogLevel = string.Concat(rawLogLevel.Where(char.IsLetter)).ToLower();

        return formattedLogLevel;
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine).CapitaliseFirstCharacter();
        var logLevel = LogLevel(logLine);

        return $"{message} ({logLevel})";
    }

    private static string CapitaliseFirstCharacter(this string str)
    {
        var firstChar = str[0];
        var remainingChars = str[1..];

        return $"{firstChar}{remainingChars}";
    }
}