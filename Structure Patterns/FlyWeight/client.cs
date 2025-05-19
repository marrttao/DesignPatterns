namespace Structure_Patterns.FlyWeight;

public class client
{
    public void Run()
    {
        var factory = new EffectFactory();

        var fire1 = factory.GetEffect("Fire");
        fire1.Display(10, 20);

        var fire2 = factory.GetEffect("Fire");
        fire2.Display(30, 40);

        var ice = factory.GetEffect("Ice");
        ice.Display(50, 60);
    }
}