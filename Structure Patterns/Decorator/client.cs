namespace Structure_Patterns.Decorator;

public class client
{
    public void Run()
    {
        IHero juggernaut = new Juggernaut();
        juggernaut = new DoubleDamage(juggernaut);

        juggernaut.Attack();

    }
}