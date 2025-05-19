namespace Creational_Patterns.Builder;

public class Hero
{
    public string Name;
    public string Ability;
    public string Agility;
}

public class Builder
{
    private Hero _hero = new Hero();
    public Builder SetName(string name)
    {
        _hero.Name = name;
        return this;
    }
    public Builder SetAbility(string ability)
    {
        _hero.Ability = ability;
        return this;
    }
    public Builder SetAgility(string agility)
    {
        _hero.Agility = agility;
        return this;
    }
    public Hero Build()
    {
        return _hero;
    }
}