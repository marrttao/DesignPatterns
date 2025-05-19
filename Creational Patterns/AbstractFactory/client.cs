namespace Creational_Patterns.AbstractFactory;

public class client
{
    public void run()
    {
        IGameUIFactory factory = new RadiantUIFactory(); // can change to DireUIFactory

        Button button = factory.CreateButton();
        HealthBar healthBar = factory.CreateHealthBar();

        button.Render();
        healthBar.Show();

    }
}