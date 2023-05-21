namespace ESA5;

public class Character
{
    protected Character(Weapon weapon, string name = "Character", int id = 0, int health = 1)
    {
        Id = id;
        Name = name;
        Health = health;
        CurrentWeapon = weapon;
    }

    protected Character()
    {
        throw new NotImplementedException();
    }

    private int Id { get; set; }
    private string Name { get; set; }
    private int Health { get; set; }
    private int TargetId { get; set; }
    private Weapon CurrentWeapon { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
    public void SelectNewTarget(int targetId)
    {
        TargetId = targetId;
    }
}

public class Weapon
{
    private int WeaponDamage { get; set; }
    private int WeaponTypeId { get; set; }
    
    public int DealDamage()
    {
        return WeaponDamage * WeaponTypeId;
    }
}

public class Player : Character
{
    public void SpeakToTarget()
    {
        //
    }
}

public class NonPlayer : Character
{
    public string giveNextQuest()
    {
        return "QuestTitle";
    }
}