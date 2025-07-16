// Optional Parameters are used for defining default values for parameters in a function definition
/* 
Must come last in the parameter list.

You can have multiple optional parameters, but once you start — all the rest must be optional too.

You can mix with named parameters for clarity. 
*/


void SayHello(string name = "Traveler")
{
    Console.WriteLine($"Hello, {name}!");
}

SayHello("Plea");      // Output: Hello, Plea!
SayHello();            // Output: Hello, Traveler!


void SpawnEnemy(string type = "Goblin", int level = 1, bool isBoss = false)
{
    Console.WriteLine($"Spawning {type} (Level {level}) Boss: {isBoss}");
}

SpawnEnemy();                      // Goblin, 1, false
SpawnEnemy("Orc");                 // Orc, 1, false
SpawnEnemy("Dragon", 10, true);    // Dragon, 10, true
SpawnEnemy(level: 5);              // Goblin, 5, false - this one is named parameter - used for skipping other params
