namespace Structure_Patterns.Facade;

public class HeroSystem
{
    public void SpawnHeroes() => Console.WriteLine("Heroes spawned.");
}

public class MapSystem
{
    public void LoadMap() => Console.WriteLine("Map loaded.");
}

public class GameTimer
{
    public void Start() => Console.WriteLine("Timer started.");
}

public class GameFacade
{
    private HeroSystem _heroSystem = new();
    private MapSystem _mapSystem = new();
    private GameTimer _gameTimer = new();

    public void StartGame()
    {
        _mapSystem.LoadMap();
        _heroSystem.SpawnHeroes();
        _gameTimer.Start();
    }
}
