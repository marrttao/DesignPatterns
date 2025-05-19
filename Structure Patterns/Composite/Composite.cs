namespace Structure_Patterns.Composite;

public abstract class UIComponent
{
    public abstract void Render();
}

// abs comppponent
public class Icon : UIComponent
{
    private string _name;

    public Icon(string name)
    {
        _name = name;
    }

    public override void Render()
    {
        Console.WriteLine($"Rendering Icon: {_name}");
    }
}

// list
public class Panel : UIComponent
{
    private readonly string _name;
    private readonly List<UIComponent> _children = new();

    public Panel(string name)
    {
        _name = name;
    }

    public void Add(UIComponent component)
    {
        _children.Add(component);
    }

    public override void Render()
    {
        Console.WriteLine($"Rendering Panel: {_name}");
        foreach (var child in _children)
            child.Render();
    }
}
