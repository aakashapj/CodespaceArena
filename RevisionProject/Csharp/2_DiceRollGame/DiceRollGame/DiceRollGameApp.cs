
using DiceRollGameApp.UserCommunication;
using DiceRollGameApp.Game;

namespace DiceRollGameApp;

class DiceRollGame
{
    public static void Main(string[] args)
    {
        var random = new Random();
        var dice = new Dice(random);
        var userInteraction = new UserInteraction();

        GameResult gameResult = new GuessingGame(dice, userInteraction).Play();

        Console.WriteLine(gameResult == GameResult.Win ? "You Win" : "You Loss");

    }
}


