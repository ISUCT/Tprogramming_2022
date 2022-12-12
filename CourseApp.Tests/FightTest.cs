namespace CourseApp.Tests;

using CourseApp.Effects;
using CourseApp.Players;
using Xunit;

[Collection("Sequential")]
public class FightTest
{
    [Theory]
    [InlineData(30, 40)]
    [InlineData(20, 50)]
    [InlineData(10, 5)]
    public void AttackTest(int strength, int health)
    {
        // Arrange
        IPlayer firstPlayer = new Archer("Мax", strength, 40, "Лучник");
        IPlayer secondPlayer = new Mage("Nikita", 20, health, "Маг");
        var healthUnderAttack = secondPlayer.Health;
        var result = false;

        // Act
        firstPlayer.AttackEnemy(secondPlayer);

        if (secondPlayer.Health < healthUnderAttack)
        {
            result = true;
        }

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void UltimateTest()
    {
        // Arrange
        IPlayer firstPlayer = new Archer("Мax", 30, 40, "Лучник");
        IPlayer secondPlayer = new Mage("Nikita", 20, 40, "Маг");
        IPlayer thirdPlayer = new Knight("Kevin", 20, 40, "Рыцарь");

        // Act
        firstPlayer.Ultimate(firstPlayer, secondPlayer, 1);
        secondPlayer.Ultimate(secondPlayer, firstPlayer, 1);
        secondPlayer.Ultimate(secondPlayer, thirdPlayer, 1);

        // Assert
        Assert.NotEmpty(firstPlayer.MyEffects);
        Assert.NotEmpty(secondPlayer.MyEffects);
        Assert.NotEmpty(thirdPlayer.MyEffects);
    }

    [Fact]
    public void StunTest()
    {
        // Arrange
        IPlayer firstPlayer = new Archer("Мax", 30, 40, "Лучник");
        IPlayer secondPlayer = new Mage("Nikita", 20, 40, "Маг");
        var result = false;

        // Act
        secondPlayer.Ultimate(secondPlayer, firstPlayer, 1);
        if (firstPlayer.MyEffects[0] is Stun)
        {
            result = true;
        }

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void EffectTest()
    {
        // Arrange
        IPlayer firstPlayer = new Archer("Мax", 30, 40, "Лучник");
        IPlayer secondPlayer = new Mage("Nikita", 20, 40, "Маг");
        IPlayer thirdPlayer = new Knight("Kevin", 20, 40, "Рыцарь");

        int[] firstPlayerUnderUltimate = { firstPlayer.Health, firstPlayer.Strength };
        int[] secondPlayerUnderUltimate = { secondPlayer.Health, secondPlayer.Strength };
        int[] thirdPlayerUnderUltimate = { thirdPlayer.Health, thirdPlayer.Strength };

        firstPlayer.Ultimate(firstPlayer, secondPlayer, 1);
        secondPlayer.Ultimate(secondPlayer, thirdPlayer, 1);
        thirdPlayer.Ultimate(thirdPlayer, firstPlayer, 1);

        var firstResult = false;
        var secondResult = false;
        var thirdResult = false;

        // Act
        firstPlayer.Effect(firstPlayer);
        secondPlayer.Effect(secondPlayer);
        thirdPlayer.Effect(thirdPlayer);

        if (firstPlayer.Strength < firstPlayerUnderUltimate[0] || firstPlayer.Health > firstPlayerUnderUltimate[1])
        {
            firstResult = true;
        }

        if (secondPlayer.Strength < secondPlayerUnderUltimate[0] || secondPlayer.Health > secondPlayerUnderUltimate[1])
        {
            secondResult = true;
        }

        if (thirdPlayer.Strength < thirdPlayerUnderUltimate[0] || thirdPlayer.Health > thirdPlayerUnderUltimate[1])
        {
            thirdResult = true;
        }

        // Assert
        Assert.True(firstResult);
        Assert.True(secondResult);
        Assert.True(thirdResult);
    }
}