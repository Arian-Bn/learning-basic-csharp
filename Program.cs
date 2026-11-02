using System;
using System.Collections.Generic;
using System.Data;

while (true)
{
    Console.WriteLine("=== C# LEARNING BASICS MENU ===");
    Console.WriteLine("1. Show Project Info");
    Console.WriteLine("2. Run Calculation (Multiplication)");
    Console.WriteLine("3. Run Password Analyzer");
    Console.WriteLine("4. Run Array Operation (Sum & Max)");
    Console.WriteLine("5. Run List<T> Demonstration");
    Console.WriteLine("6. Run Array input");
    Console.WriteLine("-1. Exit program");
    Console.WriteLine("\nEnter your choice: ");
    
    string? input = Console.ReadLine();

    // Validation: check for empty input
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("\n[ERROR] You entered nothing! Please select an option.\n");
        continue;
    }

    // Validation: check if the input is a valid number   
    if (!int.TryParse(input, out int choice))
    {
        Console.WriteLine("\n[ERROR] Invalid input! Please enter a valid number.\n");
        continue;
    }

    // Menu selection handling
    switch (choice)
    {
        case -1:
            Console.WriteLine("\nYou have exited the program! Have a great day.");
            return;
        case 1:
            ShowProjectInfo();
            break;
        case 2:
            ExecuteMultiplication();
            break;

        case 3:
            RunPasswordAnalyzer();
            break;

        case 4:
            RunArrayOperations();
            break;

        case 5:
            RunListDemo();
            break;

        case 6:
            RunArrayInput();
            break;
    
        default:
            Console.WriteLine("\n[ERROR] Invalid choice! Please try again.\n");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

// --- SEPARATE STRUCTURED METHODS ---

void ShowProjectInfo()
{
    Console.WriteLine("\n--- PROJECT INFORMATION ---");
    Console.WriteLine("Project Name: Learning Basic C#");
    Console.WriteLine("Current Topics: Syntax Basic, Methods, Arrays, Lists");
}

void ExecuteMultiplication()
{
    int number1 = 20;
    int number2 = 30;

    Console.WriteLine($"\n--- CALCULATION ---");
    Console.WriteLine($"Multiplication Result ({number1} * {number2}) = {number1 * number2}");
}

void RunPasswordAnalyzer()
{
    Console.WriteLine("\n--- PASSWORD ANALYZER ---");
    string[] testPasswords = {"", "123", "ValidPassword123"};

    for (int i = 0; i < testPasswords.Length; i++)
    {
        string password = testPasswords[i];
        Console.Write($"Password [{password}]: ");

        if (string.IsNullOrWhiteSpace(password))
        {
            Console.WriteLine("FAIL -> Password cannot be empty!");
        }
        else if (password.Length < 6)
        {
            Console.WriteLine("FAIL -> Password is too short!");
        }
        else
        {
            Console.WriteLine("SUCCESS -> Password accepted!");
        }
    }
}

void RunArrayOperations()
{
    Console.WriteLine("\n--- ARRAY OPERATIONS ---");
    int[] numbers = {50, -10, 0, -25, 30};

    int max = numbers[0];
    int sum = 0;

    Console.Write("Array elements: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}\t");
        if (numbers[i] > max) max = numbers[i];
        sum += numbers[i];
    }

    Console.WriteLine($"\nMaximum value: {max}");
    Console.WriteLine($"Sum of elements: {sum}");
}

void RunListDemo()
{
    Console.WriteLine("\n--- LIST<T> DEMO ---");
    List<string> tasks = new List<string> {"Learn C#", "Review resume", "Buy milk"};

    Console.WriteLine($"List size: {tasks.Count} element(s).");
    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"Task [{i + 1}]: {tasks[i]}");
    }
}

void RunArrayInput()
{
    int size;

    Console.Write("Please enter the size of the array: ");
    if (!int.TryParse(Console.ReadLine(), out size) || size < 0)
    {

        Console.WriteLine("[ERROR] Invalid input. Size must be a non-negative integer.");
        return;
    }

    int[] inputElements = new int[size];

    Console.WriteLine("Please enter the elements:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{i + 1}]: ");
        
        if (!int.TryParse(Console.ReadLine(), out inputElements[i]))
        {
            Console.WriteLine("[ERROR] Invalid number. Setting element to 0.");
            inputElements[i] = 0;
        }
    }

    Console.Write("Sum of elements in the array is: ");
    Console.WriteLine(CalculateSum(inputElements));
}

int CalculateSum(int[] numbers)
{
    // 1. Check for null input
    if (numbers == null)
    {
        Console.WriteLine("[WARN] Array is null.");
        return 0;
    }

    // 2. Check for an empty array
    if (numbers.Length == 0)
    {
        return 0;
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum;
}