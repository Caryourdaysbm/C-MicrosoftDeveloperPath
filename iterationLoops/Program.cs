// FizzBuzz Challenge
for (int i = 1; i <= 100;  i++){
    if (i % 3 == 0 && i % 5 != 0){
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0 && i % 3 != 0) {
        Console.WriteLine($"{i} - Buzz");
    } else if ( i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine($"{i} - FizzBuzz");
    } else Console.WriteLine(i);
}

// Do While Loop

Random random = new Random();
int current = 0;

do {
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while ( current != 7);

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// do while challenge
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

