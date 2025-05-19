namespace Creational_Patterns.Builder;

public class client
{
    public int run()
    {
        var hero = new Builder()
            .SetName("Invoker")
            .SetAbility("Quas-Wex-Exort")
            .SetAgility("Intelligence")
            .Build();

        Console.WriteLine($"Hero: {hero.Name ?? "Unknown"}, Ability: {hero.Ability ?? "Unknown"}, Agility: {hero.Agility ?? "Unknown"}");
        return 0;
    }
}