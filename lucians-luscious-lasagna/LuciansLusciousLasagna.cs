public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven)
    {
        return ExpectedMinutesInOven() - minutesInOven;
    }

    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 1;

    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
    {
        return PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
    }
}
