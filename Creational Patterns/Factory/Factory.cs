namespace Creational_Patterns.Factory;

public abstract class Creep
{
    public abstract void Attack();
}

public class MeleeCreep : Creep
{
    public override void Attack() => Console.WriteLine("Melee Creep attacks!");
}

public class RangedCreep : Creep
{
    public override void Attack() => Console.WriteLine("Ranged Creep attacks!");
}

public class CreepFactory
{
    public static Creep CreateCreep(string type)
    {
        return type switch
        {
            "melee" => new MeleeCreep(),
            "ranged" => new RangedCreep(),
            _ => throw new Exception("Unknown type")
        };
    }
}
