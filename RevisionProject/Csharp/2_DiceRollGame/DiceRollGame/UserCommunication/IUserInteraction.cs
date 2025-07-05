

namespace DiceRollGameApp.UserCommunication;

public interface IUserInteraction
{
    public int GetInput(string message);
    public void ShowMessage(string message);
}
