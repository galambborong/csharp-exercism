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
        _identifier = new StringBuilder(identifier);

        for (var i = 0; i < _identifier.Length; i++)
        {
            var ch = _identifier[i];

            if (char.IsControl(ch))
            {
                _identifier.Remove(i, 1);
                _identifier.Insert(i, ControlSubstitution);
            }

            if (ch == ' ')
                _identifier.Replace(' ', '_');
        }


        return _identifier.ToString();
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

}
