namespace Structure_Patterns.Proxy;

public interface IHeroModel
{
    void Display();
}

public class RealHeroModel : IHeroModel
{
    public RealHeroModel()
    {
        Console.WriteLine("Загрузка 3D модели героя...");
    }

    public void Display()
    {
        Console.WriteLine("Показ 3D модели героя.");
    }
}

public class HeroModelProxy : IHeroModel
{
    private RealHeroModel _realModel;

    public void Display()
    {
        if (_realModel == null)
        {
            Console.WriteLine("Создаём модель через Proxy...");
            _realModel = new RealHeroModel();
        }

        _realModel.Display();
    }
}
