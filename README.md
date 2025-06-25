# Book 1 - C# 13 and .NET 9 – Modern Cross-Platform Development Fundamentals
Training projects from ChatGPT

## Chapter 1: Hello, C#! Welcome, .NET!
- [X] Project 1: Console "Hello World" Customizer
    - Goal: Build a minimal console app that asks for user name and greets them.
    - Skills: Setting up projects, running code in Visual Studio/VS Code.
    - Specs:
        - User inputs their name.
        - App displays “Hello, {name}! Welcome to .NET 9!”
        - Run via terminal/command line.

## Chapter 2: Speaking C#
- [ ] Project 2: Number Guessing Game
    - Goal: Practice variables, data types, console input/output, and conditionals.
    - Specs:
        - Program generates a random number (1–100).
        - User guesses until correct.
        - Display hints (higher/lower).
        - Track number of attempts and display them at the end.

## Chapter 3: Flow, Type Conversion, and Exception Handling
- [ ] Project 3: Simple Console Calculator
    - Goal: Practice type conversion, switch statements, error handling.
    - Specs:
        - Accept two numbers and an operator.
        - Support +, -, *, /.
        - Use try-catch for invalid inputs.
        - Validate division by zero.

## Chapter 4: Functions, Debugging, and Unit Testing
- [ ] Project 4: Tip Calculator
    - Goal: Use functions for code reuse, practice debugging.
    - Specs:
        - Input bill total and tip percentage.
        - Function to calculate tip and total.
        - Unit tests to verify calculation function.

## Chapter 5: OOP — Classes, Fields, Methods
- [ ] Project 5: Personal Library Manager
    - Goal: Learn object-oriented design, classes, methods, and properties.
    - Specs:
        - Define a Book class (Title, Author, Year, ISBN).
        - Add, list, and remove books from a collection.
        - Use a console menu to navigate actions.

## Chapter 6: Inheritance and Interfaces
- [ ] Project 6: Banking System Simulation
    - Goal: Implement interfaces, inheritance, and events.
    - Specs:
        - Base Account class (Deposit, Withdraw, Balance).
        - Derived classes: SavingsAccount, CheckingAccount.
        - Interface IAccountOperations.
        - Raise events on low balance or large withdrawals.

## Chapter 7: Packaging and Distribution
- [ ] Project 7: Math Utilities Library
    - Goal: Build a reusable class library, publish as NuGet package.
    - Specs:
        - Class library with math utilities: factorial, GCD, LCM.
        - Publish to a local NuGet feed.
        - Consume from a console app.

## Chapter 8: Common .NET Types
- [ ] Project 8: Contact Directory
    - Goal: Work with collections, string manipulations, pattern matching.
    - Specs:
        - Add, search, and list contacts.
        - Validate email and phone formats with regex.
        - Display contacts alphabetically.

## Chapter 9: Files, Streams, and Serialization
- [ ] Project 9: Logbook Manager
    - Goal: File I/O, text encoding, JSON serialization.
    - Specs:
        - Save logs to a text file.
        - Serialize log entries to JSON.
        - Load logs from file at startup.

## Bonus Project A (Chapters: 2, 3, 4, 5, 9)
- [ ] Bonus Project A: Budget Tracker App
    - Console app for tracking expenses:
        - Categories, amounts.
        - Persist data to JSON.
        - Show total expenses per category.
        ◦ LINQ for aggregations.

## Chapter 10: Entity Framework Core
- [ ] Project 10: Northwind Orders Console
    - Goal: Use EF Core to query and update a SQLite database.
    - Specs:
        - Load Northwind sample DB.
        - List customer orders.
        - Add new orders.
        - Filter orders by date and status.

## Chapter 11: LINQ Data Queries
- [ ] Project 11: Movie Rating App
    - Goal: Practice LINQ operations.
    - Specs:
        - Manage movie records (title, genre, rating).
        - Filter, sort, group, and count movies.
        - Average ratings by genre.

## Chapter 12: ASP.NET Core Web Development Basics
- [ ] Project 12: Product Catalog API
    - Goal: Create a Minimal API for products.
    - Specs:
        - CRUD endpoints for products.
        - GET by category.
        - POST new product.
        - Validate product data.

## Chapter 13: ASP.NET Core Websites
- [ ] Project 13: Employee Directory Website
    - Goal: ASP.NET Core MVC/Blazor SSR for listing employees.
    - Specs:
        - Employee profiles (name, position, photo).
        - Search by department.
        - Blazor Server-Side Rendering for pages.
        - Static asset optimization.

## Chapter 14: Interactive Web Components (Blazor)
- [ ] Project 14: Blazor To-Do List
    - Goal: Build dynamic web UI with Blazor.
    - Specs:
        - Add, complete, and delete to-do items.
        - State management via local storage or in-memory.
        - Use components for task items and forms.

## Chapter 15: Web Services
- [ ] Project 15: Weather Forecast API
    - Goal: Create and consume a REST web service.
    - Specs:
        - ASP.NET Core Minimal API returning fake weather data.
        - Swagger/OpenAPI documentation.
        - Console client app to call the API using HttpClient.

## Bonus Project B (Chapters: 6, 13, 15)
- [ ] Bonus Project B: Chat Server
    - ASP.NET Core SignalR WebSocket service.
        - Real-time message delivery.
        - Web and console clients.
        - User connection events.

























