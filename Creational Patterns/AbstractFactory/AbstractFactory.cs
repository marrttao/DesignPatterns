public abstract class Button
{
    public abstract void Render();
}

public abstract class HealthBar
{
    public abstract void Show();
}

public class RadiantButton : Button
{
    public override void Render() => Console.WriteLine("Radiant Button Rendered");
}

public class DireButton : Button
{
    public override void Render() => Console.WriteLine("Dire Button Rendered");
}

public class RadiantHealthBar : HealthBar
{
    public override void Show() => Console.WriteLine("Radiant HealthBar Shown");
}

public class DireHealthBar : HealthBar
{
    public override void Show() => Console.WriteLine("Dire HealthBar Shown");
}

public interface IGameUIFactory
{
    Button CreateButton();
    HealthBar CreateHealthBar();
}
public class RadiantUIFactory : IGameUIFactory
{
    public Button CreateButton() => new RadiantButton();
    public HealthBar CreateHealthBar() => new RadiantHealthBar();
}

public class DireUIFactory : IGameUIFactory
{
    public Button CreateButton() => new DireButton();
    public HealthBar CreateHealthBar() => new DireHealthBar();
}
