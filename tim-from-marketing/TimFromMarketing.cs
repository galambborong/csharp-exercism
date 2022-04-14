static class Badge
{
    private const string Owner = "OWNER";

    public static string Print(int? id, string name, string? department)
    {
        var dept = (department ?? Owner).ToUpper();

        return id switch
        {
            null => $"{name} - {dept}",
            _ => $"[{id}] - {name} - {dept}"
        };
    }
}