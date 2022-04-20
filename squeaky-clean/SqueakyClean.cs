using System.Linq;

public static class Identifier
{
    private const char ControlChar = '\0';
    private const string ControlSubstitution = "CTRL";
    public static string Clean(string identifier)
    {
        return identifier.ConvertToCamel().CheckForLetters().HandleControlChar().HandleSpaces();
    }

    private static string ConvertToCamel(this string str)
    {
        var charArr = str.ToCharArray();

        if (charArr.All(c => c != '-')) return str;
        {
            for (var i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '-')
                {
                    charArr[i + 1] = char.ToUpperInvariant(charArr[i + 1]);
                }
            }

            var newChars = charArr.Where(c => c != '-').ToArray();

            return new string(newChars);
        }

    }

    private static string CheckForLetters(this string str)
    {
        var charArr = str.ToCharArray();

        if (!charArr.Any(char.IsLetter))
            return "";

        return str;
    }

    private static string HandleControlChar(this string str)
    {
        var charArr = str.ToCharArray();
        if (!charArr.Any(char.IsControl))
            return str;
        
        var index = str.IndexOf(ControlChar);
        var newStr = str.Insert(index, ControlSubstitution);

        return newStr.Remove(index + 4, 1);
    }

    private static string HandleSpaces(this string str)
    {
        return str.Replace(' ', '_');
    }
}
