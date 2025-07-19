// Goal: Build a minimal console app that asks for user name and greets them.
// Skills: Setting up projects, running code in Visual Studio/VS Code.
// Specs:
//  - User inputs their name.
//  - App displays “Hello, {name}!Welcome to.NET 9!”
//  - Run via terminal/command line.

string? name;

Write("What is your name? ");
name = ReadLine();

WriteLine($"Hello, {name}! Welcome to .NET 9!");

