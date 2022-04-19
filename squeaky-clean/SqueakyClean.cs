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

        if (chars.Any(c => c == '-'))
        {
            for (var i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '-')
                {
                    chars[i + 1] = char.ToUpperInvariant(chars[i + 1]);
                }
            }

            var newChars = chars.Where(c => c != '-').ToArray();

            return new string(newChars);
        }

        handledIdentifer = identifier.Replace(' ', '_');

        return handledIdentifer;
    }
}
