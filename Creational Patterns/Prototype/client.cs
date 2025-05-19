namespace Creational_Patterns.Prototype;

public class client
{
    public void run()
    {
        Satyr original = new Satyr();
        NeutralUnitPrototype clone1 = original.Clone();
        NeutralUnitPrototype clone2 = original.Clone();

        Console.WriteLine("Satyr cloned with HP: " + clone1.Health);

    }
}