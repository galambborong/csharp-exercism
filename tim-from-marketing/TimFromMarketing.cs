using System;

static class Badge
{
    private const string Owner = "OWNER";

    public static string Print(int? id, string name, string? department)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));

        if (id is null)
        {
            if (string.IsNullOrEmpty(department))
                return $"{name} - {Owner}";

            return $"{name} - {department.ToUpper()}";
        }

        if (string.IsNullOrEmpty(department))
            return $"[{id}] - {name} - {Owner}";

        return $"[{id}] - {name} - {department.ToUpper()}";
    }
}