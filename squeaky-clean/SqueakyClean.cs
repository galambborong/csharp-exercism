using System.Linq;

public static class Identifier
{
    private const char ControlChar = '\0';
    private const string ControlSubstitution = "CTRL";
    public static string Clean(string identifier)
    {
        return identifier.HandleControlChar().HandleSpaces();
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
