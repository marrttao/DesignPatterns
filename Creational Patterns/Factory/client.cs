namespace Creational_Patterns.Factory;

public class client
{
    public void Run()
    {
        Creep creep1 = CreepFactory.CreateCreep("melee");
        Creep creep2 = CreepFactory.CreateCreep("ranged");

        creep1.Attack();
        creep2.Attack();
    }
}