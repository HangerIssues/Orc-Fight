namespace OrcFight;

public class Player
{
    public string Name { get; private set;}
    public int Health { get; private set; }
    public string weapon = "Sword";

    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public bool Attack(Orc orc)
    {
        Random attackRoll = new Random();
        Random damageRoll = new Random();
        int attack = attackRoll.Next(1, 21);
        if (attack >= 10)
        {
            Console.WriteLine($"{Name} attacks with their {weapon}!");
            int damage = damageRoll.Next(3, 10);
            if (attack == 20)
            {
                damage *= 2;
                Console.WriteLine("Critical hit!");
                orc.TakeDamage(damage);
            }
            else
            {
                orc.TakeDamage(damage);
            }
            return true;
        }
        else
        {
            Console.WriteLine($"{Name} attacks the orc. They miss!");
            return false;
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage! Remaining health: {Health}");
    }
}