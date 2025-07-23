// Goal: Create a program that takes input from the user and performs simple calculations, e.g. HP = STR × 10.
// Specs:
//  - Prompt user for character's strength.
//  - Calculate hit points: HP = STR * 10.
//  - Display result.

int str;
int hp;
string? input;

Write("What is your Strength score? ");

while (!Int32.TryParse(ReadLine(), out str) || str < 1)
{
    Write("Please enter a positiv integer value!");
}

hp = 10 * str;

WriteLine($"HitPoints = 10 x {str} = {hp}");

