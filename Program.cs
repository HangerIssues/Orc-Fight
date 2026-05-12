using OrcFight;

Console.WriteLine("Welcome to the Arena! What is your name? ");
string? playerName = Console.ReadLine() ?? "John Smith";
Console.WriteLine("How strong are you? (Enter a number for your health) ");
int playerHealth = int.Parse(Console.ReadLine() ?? "20");

Player player = new Player(playerName, playerHealth);
Orc orc = new Orc();

Console.WriteLine($"{player.Name} enters the arena with {player.Health} health and a {player.weapon}!");
Console.WriteLine($"{player.Name} is challenging {orc.name}, the {orc.weapon} weilding orc, today! ");
Console.WriteLine("With both fighters ready, let the battle begin!");

while (player.Health > 0 && orc.health > 0)
{
    Console.WriteLine("Press Enter to start the round...");
    Console.ReadKey();
    if (player.Health > 0)
    {
        player.Attack(orc);
    }
    if (orc.health > 0)
    {
        orc.Attack(player);
    }
}

if (orc.health <= 0)
{
    Console.WriteLine($"{player.Name} has defeated {orc.name}! They are the new champion of this arena!");
}
else
{
    Console.WriteLine($"{orc.name} has defeated {player.Name}! Better luck next time!");
}