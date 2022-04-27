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

        var hasLetter = false;

        for (var i = 0; i < _identifier.Length; i++)
        {
            var ch = _identifier[i];

            if (char.IsControl(ch))
            {
                _identifier.Remove(i, 1).Insert(i, ControlSubstitution);
            }

            if (ch == ' ')
                _identifier.Replace(' ', '_');

            if (char.IsLetter(ch))
                hasLetter = true;
        }

        if (!hasLetter)
            return "";
        
        return _identifier.ToString();
    }
}
