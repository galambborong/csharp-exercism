using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string logString, string subString)
    {
        if (string.IsNullOrEmpty(logString))
            throw new ArgumentNullException(nameof(logString));

        if (string.IsNullOrEmpty(subString))
            throw new ArgumentNullException(nameof(subString));
        
        var patternLength = subString.Length;
        var startIndex = logString.IndexOf(subString, StringComparison.Ordinal) + patternLength;

        return logString.Substring(startIndex);
    }

    public static string SubstringBetween(this string logString, string first, string last)
    {
        if (string.IsNullOrEmpty(logString))
            throw new ArgumentNullException(nameof(logString));
        
        if (string.IsNullOrEmpty(first))
            throw new ArgumentNullException(nameof(first));

        if (string.IsNullOrEmpty(last))
            throw new ArgumentNullException(nameof(last));

        var stringAfterFirst = logString.SubstringAfter(first);
        
        var lastIndex = stringAfterFirst.IndexOf(last, StringComparison.Ordinal);

        return stringAfterFirst.Substring(0, lastIndex);
    }

    public static string Message(this string logString)
    {
        if (string.IsNullOrEmpty(logString))
            throw new ArgumentNullException(nameof(logString));

        return logString.SubstringAfter(": ");
    }

    public static string LogLevel(this string logString)
    {
        if (string.IsNullOrEmpty(logString))
            throw new ArgumentNullException(nameof(logString));

        return logString.SubstringBetween("[", "]");
    }
}