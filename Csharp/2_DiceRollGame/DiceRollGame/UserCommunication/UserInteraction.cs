

namespace DiceRollGameApp.UserCommunication;

public class UserInteraction : IUserInteraction
{
    public int GetInput(string message)
    {
        int userInput;

        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out userInput));

        return userInput;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
