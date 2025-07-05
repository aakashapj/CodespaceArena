

namespace DiceRollGameApp.Game;
public interface IDice
{
    int Roll();
}


public class Dice : IDice
{
    Random _random;
    int numberOfSides = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, numberOfSides + 1);
}


