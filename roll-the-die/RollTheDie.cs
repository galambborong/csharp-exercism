using System;

public class Player
{
    private readonly Random _rand = new Random();

    public int RollDie() => _rand.Next(1, 19);
    public double GenerateSpellStrength()
    {
        var strength = _rand.Next(0, 101);
        var modifier = _rand.NextDouble();

        return strength * modifier;
    }
}
