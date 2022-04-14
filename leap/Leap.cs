public static class Leap
{
    public static bool IsLeapYear(int year) =>
        (year % 4, year % 100, year % 400) switch
        {
            (0, 0, 0) => true,
            (0, 0, _) => false,
            (0, _, _) => true,
            _ => false
        };
}