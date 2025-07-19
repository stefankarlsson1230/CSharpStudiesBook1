// Goal: Make a simple "Hello, adventurer!" program that outputs a name and a randomly generated starting attribute.
// Specs:
//  - Ask for adventurer's name.
//  - Randomly assign a starting Strength/Intelligence/Dexterity attribute (1–20).
//  - Display a message: "Hello, {name} the adventurer! You start with {attribute} strength."
//  - Could use Random class.

Random die = new();

int strength = die.Next(1, 21);
int intelligence = die.Next(1, 21);
int dexterity  = die.Next(1, 21);

Write("What is your name adventurer? ");
string? name = ReadLine();

WriteLine($"Hello, {name} the adventurer! You start with {strength} Strength, {intelligence} Intelligence and {dexterity} Dexterity.");

