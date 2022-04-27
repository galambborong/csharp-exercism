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

        _identifier = _identifier.CheckForLetters();

        return _identifier.Replace(' ', '_').ToString();
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

    private static StringBuilder CheckForLetters(this StringBuilder str)
    {
        for (var i = 0; i < str.Length; i++)
        {
            var ch = str[i];
            if (!char.IsLetter(ch))
                return new StringBuilder();
        }

        return str;
    }

    private static StringBuilder HandleControlChar(this StringBuilder str)
    {
        int index = 0;
        for (var i = 0; i < str.Length; i++)
        {
            var ch = str[i];
            if (char.IsControl(ch))
            {
                index = i;
            }
        }

        return str.Insert(index, ControlSubstitution);
        
    }

    private static string HandleSpaces(this string str)
    {
        return str.Replace(' ', '_');
    }
}
