namespace Creational_Patterns.Prototype;

public abstract class NeutralUnitPrototype
{
    public int Health;
    public int Damage;

    public abstract NeutralUnitPrototype Clone();
}

public class Satyr : NeutralUnitPrototype
{
    public Satyr() { Health = 200; Damage = 20; }

    public override NeutralUnitPrototype Clone() => (NeutralUnitPrototype)this.MemberwiseClone();
}
