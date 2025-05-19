namespace Structure_Patterns.Adapter;

public interface IController
{
    void Move();
}

public class KeyboardController
{
    public void ArrowMove() => Console.WriteLine("Moving with arrows!");
}

public class KeyboardControllerAdapter : IController
{
    private readonly KeyboardController _keyboard;

    public KeyboardControllerAdapter(KeyboardController keyboard)
    {
        _keyboard = keyboard;
    }

    public void Move()
    {
        _keyboard.ArrowMove();
    }
}