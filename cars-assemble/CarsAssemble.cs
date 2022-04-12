using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        0 => 0.0,
        < 5 => 1.0,
        < 9 => 0.9,
        9 => 0.8,
        10 => 0.77,
        _ => throw new ArgumentOutOfRangeException(nameof(speed), speed, null)
    };
    
    public static double ProductionRatePerHour(int speed)
    {
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
