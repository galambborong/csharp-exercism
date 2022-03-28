using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string logString, string subString)
    {
        if (logString is null)
            throw new ArgumentNullException(nameof(logString));

        var patternLength = subString.Length;
        var startIndex = logString.IndexOf(subString, StringComparison.Ordinal) + patternLength;

        return logString.Substring(startIndex);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string logString, string first, string last) => "";

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logString) => "";

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logString) => "";
}