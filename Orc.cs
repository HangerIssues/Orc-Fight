namespace OrcFight;

public class Orc
{
    public string name = "Grog";
    public int health = 20;
    public string weapon = "Club";

    public bool Attack(Player player)
    {
        Random attackRoll = new Random();
        Random damageRoll = new Random();
        int attack = attackRoll.Next(1, 21);
        if (attack >= 10)
        {
            Console.WriteLine($"{name} attacks with their {weapon}!");
            int damage = damageRoll.Next(3, 10);
            if (attack == 20)
            {
                damage *= 2;
                Console.WriteLine("Critical hit!");
                player.TakeDamage(damage);
            }
            else
            {
                player.TakeDamage(damage);
            }
            return true;
        }
        else
        {
            Console.WriteLine($"{name} attacks {player.Name}. They miss!");
            return false;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"{name} takes {damage} damage! Remaining health: {health}");
    }
}