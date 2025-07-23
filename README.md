# Book 1 - C# 13 and .NET 9 – Modern Cross-Platform Development Fundamentals
Training projects from ChatGPT

## Index
- [Chapter 1](#chapter-1-hello-c-welcome-net)
- [Chapter 2](#chapter-2-speaking-c)
- [Chapter 3](#chapter-3-flow-type-conversion-and-exception-handling)
- [Chapter 4](#chapter-4-functions-debugging-and-unit-testing)
- [Chapter 5](#chapter-5-oop-classes-fields-methods)
- [Chapter 6](#chapter-6-inheritance-and-interfaces)
- [Chapter 7](#chapter-7-packaging-and-distribution)
- [Chapter 8](#chapter-8-common-net-types)
- []()
- []()
## Chapter 1: Hello, C#! Welcome, .NET!
- [x] Project 1A: Console "Hello World" Customizer
   - Goal: Build a minimal console app that asks for user name and greets them.
   - Skills: Setting up projects, running code in Visual Studio/VS Code.
   - Specs:
     - User inputs their name.
     - App displays “Hello, {name}! Welcome to .NET 9!”
     - Run via terminal/command line.
   - *Comments*
     - *I run the program from terminal with `dotnet run` while inside the project folder*
     - *I Need to get into the habit of using a `GlobalUsing.cs` file containing all the libraries I'm using in my project. I could also do it by adding a ItemGroup/Using in the project-file, but I have a hard time remembering the way to write this.*  
     


- [x] Project 1B: ”Hello Adventurer” 
   - Goal: Make a simple "Hello, adventurer!" program that outputs a name and a randomly generated starting attribute.
   - Specs:
     - Ask for adventurer's name.
     - Randomly assign a starting Strength/Intelligence/Dexterity attribute (1–20).
     - Display a message: "Hello, {name} the adventurer! You start with {attribute} strength."
     - Could use Random class.
   - *Comments*
     - *To include all three attributes I used the longer text "Hello, \{name\} the adventurer! You start with \{strength\} Strength, \{intelligence\} Intelligence and \{dexterity\} Dexterity."*
     - *`Random.Next()` created the three values between 1 and 20*


## Chapter 2: Speaking C#
- [ ] Project 2A: Number Guessing Game
  - Goal: Practice variables, data types, console input/output, and conditionals.
  - Specs:
    - Program generates a random number (1–100).
    - User guesses until correct.
    - Display hints (higher/lower).
    - Track number of attempts and display them at the end.

- [ ] Project 2B
    - Goal: Create a program that takes input from the user and performs simple calculations, e.g. HP = STR × 10.
    - Specs:
      - Prompt user for character's strength.
      - Calculate hit points: HP = STR * 10.
      - Display result.

- [ ] Project 2C
  - Goal:Check the probability of succeeding at different target values (difficulties) if difficulty levels are 2D6, 3D6, 4D6, etc. Display a nice console table.
  - Specs:
    - Simulate rolling n dice (2D6, 3D6…)
    - For each possible target value, calculate probability of rolling equal to or higher than that value.
    - Display as a formatted table in console using Console.WriteLine.

- [ ] Chapter 2 AI
    - Create a free OpenAI account


## Chapter 3: Flow, Type Conversion, and Exception Handling
- [ ] Project 3A: Simple Console Calculator
    - Goal: Practice type conversion, switch statements, error handling.
    - Specs:
      - Accept two numbers and an operator.
      - Support +, -, *, /.
      - Use try-catch for invalid inputs.
      - Validate division by zero.
      - Menu med while-loop

- [ ] Project 3B
    - Goal: Build a simple menu with switch-case allowing the user to choose between different adventures.
    - Specs:
      - Present options like:
      ```
        1. Go to the forest
        2. Enter the dungeon
        3. Visit the market
      ```
     - Use while loop for menu repetition.
     - Use switch to handle choice.

- [ ] Chapter 3 AI
  - Test OpenAI Playground


## Chapter 4: Functions, Debugging, and Unit Testing
- [ ] Project 4A: Tip Calculator
  - Goal: Use functions for code reuse, practice debugging.
  - Specs:
    - Input bill total and tip percentage.
    - Function to calculate tip and total.
    - Unit tests to verify calculation function.

- [ ] Project 4B
  - Goal: Write functions to create characters, roll dice (D20, D6 etc.), and calculate battle points.
  - Specs:
    - Function for dice rolls: RollDice(int sides)
    - Character generator with random stats
    - Simple battle simulator: total battle points = Strength + Weapon Damage + Dice roll.

- [ ] Chapter 4 AI
  - Use Copilot or ChatGPT to generate if/switch and method-structures.
  - Ask AI to write unit-tests for my functions.



## Chapter 5: OOP — Classes, Fields, Methods
- [ ] Project 5A: Personal Library Manager
  - Goal: Learn object-oriented design, classes, methods, and properties.
  - Specs:
    - Define a Book class (Title, Author, Year, ISBN).
    - Add, list, and remove books from a collection.
    - Use a console menu to navigate actions.

- [ ] Project 5B
  - Goal: Define classes for Character, Monster, and Item.
  - Specs:
    - Character class: Name, HP, Attack, Defense
    - Monster class inherits from Character
    - Item class: Name, Effect, Value
    - Add a method Attack(Monster m) or similar.

- [ ] Project 5C
  - Goal: Text-based Memory-game
  - Specs:
    - List words in random order.
    - Match pairs by index.
    - Timer and score.
    - List of string pairs.
    - Shuffle and display numbered positions.
    - Player selects two numbers.
    - Check for match.

- [ ] Chapter 5 AI
  - Use Copiliot or ChatGPT to generate a simple quest-class in C#


## Chapter 6: Inheritance and Interfaces
- [ ] Project 6A: Banking System Simulation
  - Goal: Implement interfaces, inheritance, and events.
  - Specs:
    - Base Account class (Deposit, Withdraw, Balance).
    - Derived classes: SavingsAccount, CheckingAccount.
    - Interface IAccountOperations.
    - Raise events on low balance or large withdrawals.

- [ ] Project 6B
  - Goal: Create an interface IAttackable implemented by both Character and Monster.
  - Specs:
    - Interface IAttackable with TakeDamage(int amount)
    - Both Character and Monster implement it.

- [ ] Chapter 6 AI
  - Let AI generate the classes Hero, Enemy and NPC with attributes and methods.


## Chapter 7: Packaging and Distribution
- [ ] Project 7A: Math Utilities Library
  - Goal: Build a reusable class library, publish as NuGet package.
  - Specs:
    - Class library with math utilities: factorial, GCD, LCM.
    - Publish to a local NuGet feed.
    - Consume from a console app.

- [ ] Project 7B
  - Create a simple NuGet package with your dice-rolling function.
    - Class library DiceUtility
    - Method RollDice(int sides)
    - Package and publish locally.


## Chapter 8: Common .NET Types
- [ ] Project 8A: Contact Directory
  - Goal: Work with collections, string manipulations, pattern matching.
  - Specs:
    - Add, search, and list contacts.
    - Validate email and phone formats with regex.
    - Display contacts alphabetically.

- [ ] Project 8B
  - Handle and format dates for an adventure schedule.
    - Use DateTime to store quest start times.
    - Display formatted schedule: "Quest 'Dragon Hunt' starts at 2025-07-16 14:00"

- [ ] Chapter 8 AI
  - Use AI to write DateTime-manipulations and string-functions


## Chapter 9: Files, Streams, and Serialization
- [ ] Project 9A: Logbook Manager
  - Goal: File I/O, text encoding, JSON serialization.
  - Specs:
    - Save logs to a text file.
    - Serialize log entries to JSON.
    - Load logs from file at startup.

- [ ] Project 9B: Save and load characters to/from JSON.
  - Character class with Name, Level, Attributes
  - Serialize list to JSON using System.Text.Json
  - Load on startup

- [ ] Chapter 9 AI
  - Let AI create JSON-schema and serialization-methods.


## Bonus Project
- [ ] Bonus Project A: Budget Tracker App
  - Chapters: 2, 3, 4, 5, 9
  - Console app for tracking expenses:
    - Categories, amounts.
    - Persist data to JSON.
    - Show total expenses per category.
    - LINQ for aggregations.


## Chapter 10: Entity Framework Core
- [ ] Project 10A: Northwind Orders Console
  - Goal: Use EF Core to query and update a SQLite database.
  - Specs:
    - Load Northwind sample DB.
    - List customer orders.
    - Add new orders.
    - Filter orders by date and status.

- [ ] Project 10B: Create a SQLite database with characters and items.
  - EF Core models: Character, Item
  - Relationships: Character has a List`<Item>`
  - Migrations and database creation


## Chapter 11: LINQ Data Queries
- [ ] Project 11A: Movie Rating App
  - Goal: Practice LINQ operations.
  - Specs:
    - CRUD for movies
    - Manage movie records (title, genre, rating).
    - Filter, sort, group, and count movies.
    - Filter on genre and rating
    - Average ratings by genre.

- [ ] Projekt 11B: Find the strongest character, sum all items, etc.
  - Use LINQ to sort characters by strength.
  - Aggregate total value of items.
  - Filter items by type.

- [ ] Project 11C: Contact Manager with List och LINQ
  - Add, delete, and search contacts
  - Save/load to JSON
  - Class Contact
  - List`<Contact>`
  - LINQ for search and filtering.
      
- [ ] Chapter 11 AI
  - AI-generate EF Core-migrationcode and LINQ-queryexample

## Portfolioproject

- [ ] Portfolioproject 1 - QuestLog WebAPI
  - Purpose: REST API to manage RPG quests.
  - Requirements:
    - CRUD endpoints: GET /quests, GET /quests/{id}, POST, PUT, DELETE
    - Quest model with Name, Description, Difficulty, XP, Status
    - Database via EF Core + SQLite
    - Model validation via DataAnnotations
    - Swagger/OpenAPI
    - LINQ filtering (e.g. quests per status)
  - Teknik: ASP.NET Core WebAPI, EF Core, SQLite, LINQ, Swagger
  - Portfolio-mervärde: Backend, REST-API, databas och validering.
  - AI: använd AI för controller-metoder, DTO:er och API-konventioner


## Chapter 12: ASP.NET Core Web Development Basics
- [ ] Project 12A: Product Catalog API
  - Goal: Create a Minimal API for products.
  - Specs:
    - CRUD endpoints for products.
    - GET by category.
    - POST new product.
    - Validate product data.

- [ ] Project 12B
  - Unit converter WebAPI
    - Minimal API with endpoints for cm→m, kg→lb etc
    - Swagger documentation
    - Minimal API project.
    - GET endpoints like /convert/cm-to-m/{value}
    - Use query parameters for flexibility.

- [ ] Chapter 12 AI
  - Use AI to build a first Minimal API, including routing and endpoint-signatures.


## Chapter 13: ASP.NET Core Websites
- [ ] Project 13A: Employee Directory Website
  - Goal: ASP.NET Core MVC/Blazor SSR for listing employees.
  - Specs:
    - Employee profiles (name, position, photo).
    - Search by department.
    - Blazor Server-Side Rendering for pages.
    - Static asset optimization.


## Chapter 14: Interactive Web Components (Blazor)
- [ ] Project 14A: Blazor To-Do List
  - Goal: Build dynamic web UI with Blazor.
  - Specs:
    - Add, complete, and delete to-do items.
    - State management via local storage or in-memory.
    - Use components for task items and forms.

- [ ] Chapter 14 AI
  - AI-generate Blazor component structure and a simple character list.
    - Blazor WASM or Server
    - Character List Component
    - Character Form Component
    - XP progress bar
    - LocalStorage service

## Portfolioproject
- [ ] Portfolioproject 2 - RPG Character Manager (Blazor)
  - Syfte: Skapa och hantera karaktärer via webbläsare.
  - Krav:
    - Blazor WebAssembly-app
    - Karaktärsmodell med namn, ras, klass, styrka, smidighet
    - Form för att skapa ny karaktär
    - Lista karaktärer med filter
    - ProgressBar för XP
    - LocalStorage för spara/läsa lokalt
    - Möjlighet att synka mot WebAPI
  - Teknik: Blazor WASM, C#, LocalStorage, ASP.NET API
  - Portfolio-mervärde: Modern frontend i .NET-miljö.


## Chapter 15: Web Services
- [ ] Project 15A: Weather Forecast API
  - Goal: Create and consume a REST web service.
  - Specs:
    - ASP.NET Core Minimal API returning fake weather data.
    - Swagger/OpenAPI documentation.
    - Console client app to call the API using HttpClient.

- [ ] Project 15B
  - Build a web interface for your character generator. 

## Bonusproject
- [ ] Bonus Project B: Chat Server
  - Chapters: 6, 13, 15
    - ASP.NET Core SignalR WebSocket service.
      - Real-time message delivery.
      - Web and console clients.
      - User connection events.

## Portfolioproject
- [ ] Portfolioproject 3 - RPG Inventory System (Unity + WebAPI)
  - Purpose: Inventory system in a game environment connected to a backend.
  - Requirements:
    - Unity project with inventory UI
    - Item class: Name, Type, Value
    - Add/remove items
    - Save inventory via ASP.NET Core WebAPI
    - JSON serialization
    - Console admin app to create item templates
  - Teknik: Unity C#, ASP.NET Core WebAPI, JSON
  - Portfolio-mervärde: Full integration Unity ↔ .NET backend.



