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
        const int hourlyProductionRate = 221;
        var successRate = SuccessRate(speed);

        return hourlyProductionRate * speed * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var carsProducedPerHour = (int) ProductionRatePerHour(speed);

        return carsProducedPerHour / 60;
    }
}
 