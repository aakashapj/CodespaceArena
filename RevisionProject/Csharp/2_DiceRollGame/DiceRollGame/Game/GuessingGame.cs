using DiceRollGameApp.UserCommunication;

namespace DiceRollGameApp.Game;

public class GuessingGame
{
    private int maxNumberOfChances = 3;
    IDice _dice;
    IUserInteraction _UserInteraction;
    public GuessingGame(IDice dice, IUserInteraction userInteraction)
    {
        _dice = dice;
        _UserInteraction = userInteraction;
    }

    public GameResult Play()
    {
        var diceRolledNumber = _dice.Roll();
        _UserInteraction.ShowMessage("Dice rolled. Guess what number it shows in 3 tries.");


        while (maxNumberOfChances > 0)
        {
            int userGuess = _UserInteraction.GetInput($"You have {maxNumberOfChances} chance");

            if (IsGuessCorrect(diceRolledNumber, userGuess))
            {
                return GameResult.Win;
            }

            _UserInteraction.ShowMessage("Wrong Number");
            maxNumberOfChances -= 1;
        }

        return GameResult.Loss;

    }

    private static bool IsGuessCorrect(int randomNumber, int guessedNumber)
    {
        if (randomNumber == guessedNumber)
        {
            return true;
        }

        return false;
    }
}