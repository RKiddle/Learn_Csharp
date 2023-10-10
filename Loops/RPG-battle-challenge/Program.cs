// RPG Battle Challenge
// author: Richard Kiddle
// date: 2023-10-10

/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int heroHealth = 10;
int monsterHealth = 10;
int heroAttack = 0;
int monsterAttack = 0;
int round = 0;

while (heroHealth > 0 && monsterHealth > 0)
{
    round++;
    Console.WriteLine($"Round {round}");
    heroAttack = new Random().Next(1, 11);
    monsterHealth -= heroAttack;
    Console.WriteLine($"The hero attacks the monster for {heroAttack} damage. The monster's health is now {monsterHealth}.");
    if (monsterHealth > 0)
    {
        monsterAttack = new Random().Next(1, 11);
        heroHealth -= monsterAttack;
        Console.WriteLine($"The monster attacks the hero for {monsterAttack} damage. The hero's health is now {heroHealth}.");
    }
}

if (heroHealth > 0)
{
    Console.WriteLine("The hero wins!");
}
else
{
    Console.WriteLine("The monster wins!");
}


