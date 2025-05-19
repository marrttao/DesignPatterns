namespace Structure_Patterns.Decorator;

public interface IHero
{
    void Attack();
}

public class Juggernaut : IHero
{
    public void Attack() => Console.WriteLine("Juggernaut attacks for 100 damage!");
}

public abstract class HeroDecorator : IHero
{
    protected IHero _hero;

    protected HeroDecorator(IHero hero)
    {
        _hero = hero;
    }

    public virtual void Attack() => _hero.Attack();
}

public class DoubleDamage : HeroDecorator
{
    public DoubleDamage(IHero hero) : base(hero) { }

    public override void Attack()
    {
        Console.WriteLine("Double Damage activated!");
        _hero.Attack();
        Console.WriteLine("Damage doubled!");
    }
}
