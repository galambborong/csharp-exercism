using System;
using System.Linq;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var chars = identifier.ToCharArray();
        if (!chars.Any(char.IsLetter))
            return "";
        
        string handledIdentifer;

        if (chars.Any(char.IsControl))
        {
            var index = identifier.IndexOf('\0');

            var newIdentifier = identifier.Insert(index, "CTRL");

            handledIdentifer = newIdentifier.Remove(index + 4, 1);

            return handledIdentifer;
        }

        handledIdentifer = identifier.Replace(' ', '_');

        return handledIdentifer;
    }
}
