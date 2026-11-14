# C# Learning Basics & Console Task Tracker

## Description
A structured console application designed to practice core C# programming concepts, data structures, algorithms, and Object-Oriented Programming (OOP). The project features an interactive menu with robust input validation and a modular **Task Tracker** prototype.

## Features
- **Task Tracker (Full CRUD):** Interactive task management system separated into a data model (`TodoTask`) and business logic layer (`TaskService`). Supports creating, viewing, completing, and deleting tasks with duplicate ID protection and input validation.
- **Phone Book:** Object-oriented contact manager using `List<Contact>` with duplicate checking and search functionality.
- **Algorithms & Data Structures:** Practical implementations of Linear Search, Duplicate Detection (`O(N)` via `Dictionary`), and Valid Anagram frequency counters.
- **Core C# Fundamentals:** Interactive modules demonstrating array operations, `List<T>` collections, password validation, and safe user input parsing (`int.TryParse`).

## How to Run
1. Ensure you have the [.NET SDK](https://microsoft.com) installed on your machine (tested on Arch Linux).
2. Clone this repository:
   ```bash
   git clone <your-repository-url>
   ```
3. Navigate to the project directory and run the application:
   ```bash
   dotnet run
   ```

## Current Limitations
- **In-Memory Storage Only:** All tasks and contacts are stored in RAM (`List<T>`) and are lost when the application exits (database persistence with PostgreSQL/EF Core is planned for future stages).
- **Console Interface:** Currently operates strictly via a Command-Line Interface (CLI) without a web API or graphical UI.
- **Single-File Structure:** Models and services are currently located inside `Program.cs` for learning simplicity and will be separated into dedicated files and folders during refactoring.

## What I Learned
- **Object-Oriented Design:** How to separate responsibilities between data models (`TodoTask`) and service classes (`TaskService`), and protect internal state using encapsulation (`private` collections).
- **Collections & Time Complexity:** The trade-offs between `List<T>` (`O(N)` linear search) and `Dictionary<TKey, TValue>` (`O(1)` hash-based lookup).
- **Defensive Programming:** Preventing runtime crashes using `int.TryParse`, `string.IsNullOrWhiteSpace`, guard clauses, and `try/catch` exception handling.
- **Memory & Bounds:** How zero-based indexing works in arrays and strings (`Length - 1`) and how to avoid `IndexOutOfRangeException`.
- **Developer Workflow:** Structuring clean Git commits (Conventional Commits), configuring `.gitignore`, and debugging in a Linux environment.
