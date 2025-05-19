namespace Creational_Patterns.Singleton;

public class ClientRunner
{
    public static void Main()
    {
        GameManager.Instance.PauseGame();
        Console.WriteLine("Match time: " + GameManager.Instance.MatchTime);
    }
}