namespace Structure_Patterns.FlyWeight;

public class SpellEffect
{
    private string _graphic;

    public SpellEffect(string graphic)
    {
        _graphic = graphic;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Показываем эффект '{_graphic}' в точке ({x},{y})");
    }
}

public class EffectFactory
{
    private Dictionary<string, SpellEffect> _cache = new();

    public SpellEffect GetEffect(string type)
    {
        if (!_cache.ContainsKey(type))
        {
            Console.WriteLine($"Создаём новый объект для типа {type}");
            _cache[type] = new SpellEffect(type);
        }

        return _cache[type];
    }
}
