Random blows = new Random();

int heroHealth = 10;
int monsterHealth = 10;
int attack = 0;

do
{
    if (heroHealth > 0)
    {
        attack = blows.Next(1, 10);
        monsterHealth -= attack;
        Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    }

    if (monsterHealth > 0)
    {
        attack = blows.Next(1, 10);
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }
} while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins" : "Monster wins");