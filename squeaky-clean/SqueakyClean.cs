using System.Linq;
using System.Text;

public static class Identifier
{
    private const char SnakeCaseSeparator = '-';
    private const char ControlChar = '\0';
    private const string ControlSubstitution = "CTRL";

    private static StringBuilder _identifier;
    public static string Clean(string identifier)
    {
        var controls = new char[] { ControlChar };
        var controlString = string.Concat(controls);
        _identifier = new StringBuilder(identifier);

        return _identifier.Replace(' ', '_').Replace(controlString, ControlSubstitution).ToString();
    }

    private static string ConvertToCamel(this string str)
    {
        var chars = str.ToCharArray();

        if (!chars.Any(c => c == SnakeCaseSeparator))
            return str;

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == SnakeCaseSeparator)
            {
                chars[i + 1] = char.ToUpperInvariant(chars[i + 1]);
            }
        }

        var newChars = chars.Where(c => c != '-').ToArray();

        return string.Concat(newChars);

    }

    private static string CheckForLetters(this string str)
    {
        var chars = str.ToCharArray();

        return !chars.Any(char.IsLetter) ? "" : str;
    }

    private static string HandleControlChar(this string str)
    {
        var controls = new char[] { ControlChar };
        var controlString = string.Concat(controls);

        var result = str.Replace(controlString, ControlSubstitution);
        return result;
    }

    private static string HandleSpaces(this string str)
    {
        return str.Replace(' ', '_');
    }
}
