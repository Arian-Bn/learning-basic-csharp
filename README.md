# C# Learning Basics & Console Task Tracker

## Description
A structured console application designed to practice core C# programming concepts, data structures, algorithms, Object-Oriented Programming (OOP), and unit testing. The project features an interactive menu with robust input validation and a decoupled **Task Tracker** prototype.

## Features
- **Task Tracker (Full CRUD & LINQ):** Interactive task management system separated into a domain model (`TodoTask`) and a decoupled business logic layer (`TaskService`). Supports creating, viewing, filtering incomplete tasks, checking task completion status via LINQ (`Where`, `Any`), completing (`enum` status results), and deleting tasks.
- **Unit Testing (`xUnit`):** Dedicated `LearningBasics.Tests` project covering `TaskService` business logic and exception handling using the Arrange–Act–Assert (AAA) pattern.
- **Phone Book:** Object-oriented contact manager using `List<Contact>` with duplicate checking and search functionality.
- **Algorithms & Data Structures:** Practical implementations of Linear Search, Duplicate Detection (`O(N)` via `HashSet<T>` / `Dictionary`), and Valid Anagram frequency counters.
- **Core C# Fundamentals:** Interactive modules demonstrating array operations, `List<T>` collections, password validation, and safe user input parsing (`int.TryParse`).

## How to Run
1. Ensure you have the [.NET SDK](https://microsoft.com) installed on your machine (tested on Arch Linux).
2. Clone this repository:
   ```bash
   git clone https://github.com/Arian-Bn/learning-basic-csharp.git
   cd learning-basic-csharp
   ```
3. Run the console application:
   ```bash
   dotnet run
   ```
4. Run the unit tests:
   ```bash
   dotnet test
   ```

## Current Limitations
- **In-Memory Storage Only:** All tasks and contacts are stored in RAM (`List<T>`) and are lost when the application exits (database persistence with PostgreSQL/EF Core is planned for future stages).
- **Console Interface:** Currently operates strictly via a Command-Line Interface (CLI) without a web API or graphical UI.
- **Single-File Core Structure:** Domain models and services are currently located inside `Program.cs` for learning simplicity and will be separated into dedicated files and folders during upcoming refactoring.

## What I Learned
- **Object-Oriented Design & Decoupling:** Separating domain validation (`TodoTask` constructor), business logic (`TaskService`), and console UI (`Program.cs`) using strict return contracts (`bool`, `enum`, `Nullable`).
- **LINQ & Generics:** Filtering and querying collections declaratively (`Where`, `Select`, `FirstOrDefault`, `Any`, `OrderBy`) and writing type-safe generic code (`List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`).
- **Unit Testing (`xUnit`):** Structuring automated tests with Arrange–Act–Assert (`[Fact]`, `Assert.Throws<T>`) and managing multi-project solutions (`.slnx`).
- **Defensive Programming & Null Safety:** Enforcing `#nullable enable`, preventing runtime crashes using `int.TryParse`, `string.IsNullOrWhiteSpace`, guard clauses, and `try/catch` exception handling.
- **Developer Workflow:** Structuring clean Git commits (Conventional Commits), configuring `.gitignore`, and developing in a Linux environment.
