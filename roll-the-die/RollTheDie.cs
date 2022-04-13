using System;

public class Player
{
    public int RollDie()
    {
        var rand = new Random();

        return rand.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
