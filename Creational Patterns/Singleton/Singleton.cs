namespace Creational_Patterns.Singleton;

public class GameManager
{
    private static GameManager _instance;
    public static GameManager Instance => _instance ??= new GameManager();

    public int MatchTime { get; private set; } = 0;
    private GameManager() { }

    public void PauseGame() => Console.WriteLine("Game paused!");
}
