namespace Structure_Patterns.Proxy;

public class client
{
    public void Run()
    {
        IHeroModel hero = new HeroModelProxy();
        Console.WriteLine("Открытие героя...");
        hero.Display();
        hero.Display();

    }
}