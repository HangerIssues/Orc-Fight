using OrcFight;

Console.WriteLine("Welcome to the Arena! What is your name? ");
string? playerName = Console.ReadLine() ?? "John Smith";
Console.WriteLine("How strong are you? (leave blank for default) ");
int playerHealth = int.Parse(Console.ReadLine() ?? "20");

Player player = new Player(playerName, playerHealth);
Orc orc = new Orc();

Console.WriteLine($"{player.Name} enters the arena with {player.Health} health and a {player.weapon}!");
Console.WriteLine($"{player.Name} is challenging {orc.name}, the {orc.weapon} weilding orc, today! ");
Console.WriteLine("With both fighters ready, let the battle begin!");
