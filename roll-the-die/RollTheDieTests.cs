using System.Collections.Generic;
using System.Linq;
using Xunit;
using Exercism.Tests;

public class RollTheDieTests
{
    [Fact]
    [Task(1)]
    public void RollDie()
    {
        var hitsOnNums = new Dictionary<int, int>();

        for (var i = 1; i < 19; i++)
        {
            hitsOnNums.Add(i, 0);
        }
        
        var player = new Player();
        for (var i = 0; i < 200; i++)
        {
            var dice = player.RollDie();
            hitsOnNums[dice] += 1;
            Assert.InRange(dice, 1, 18);
        }

        Assert.True(hitsOnNums.Values.All(n => n > 0));
    }

    [Fact]
    [Task(2)]
    public void GenerateSpellStrength()
    {
        var player = new Player();
        var strength = player.GenerateSpellStrength();
        Assert.InRange(strength, 0.0, 100.0);
    }
}
