namespace Structure_Patterns.Facade;

public class client
{
    public void Run()
    {
        var game = new GameFacade();
        game.StartGame();

    }
}