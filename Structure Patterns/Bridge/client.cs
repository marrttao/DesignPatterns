namespace Structure_Patterns.Bridge;

public class client
{
    public void Run()
    {
        Hero hero1 = new Hero("Juggernaut", new ArcanaSkin());
        Hero hero2 = new Hero("Invoker", new DefaultSkin());

        hero1.Display();
        hero2.Display();

    }
}