namespace Structure_Patterns.Adapter;

public class client
{
    public void Run()
    {
        IController controller = new KeyboardControllerAdapter(new KeyboardController());
        controller.Move();

    }
}