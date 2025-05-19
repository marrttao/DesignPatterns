namespace Structure_Patterns.Bridge;

public interface IHeroSkin
{
    void Render(string heroName);
}

public class ArcanaSkin : IHeroSkin
{
    public void Render(string heroName) => Console.WriteLine($"{heroName} with Arcana Skin");
}

public class DefaultSkin : IHeroSkin
{
    public void Render(string heroName) => Console.WriteLine($"{heroName} with Default Skin");
}


public class Hero
{
    protected IHeroSkin Skin;
    protected string Name;

    public Hero(string name, IHeroSkin skin)
    {
        Name = name;
        Skin = skin;
    }

    public virtual void Display()
    {
        Skin.Render(Name);
    }
}
