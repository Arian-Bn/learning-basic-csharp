using System;

while (true)
{
    Console.WriteLine("Enter your choice(-1 to exit):");
    Console.WriteLine("1. Show the message");
    Console.WriteLine("2. Show the sum");

    string? choiceFirst = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(choiceFirst))
    {
        Console.WriteLine("\nYot entered nothing! Please select an option.\n");
        continue;
    }
    
    if (!int.TryParse(choiceFirst, out int choice))
    {
        Console.WriteLine("\nInvalid input! Please enter a valid number.\n");
        continue;
    }

    switch (choice)
    {
        case -1:
            Console.WriteLine("\nYou have exited! Have a good day");
            return;
        case 1:
            PrintInf();
            break;
        case 2:
            MultiFun();
            break;
    
        default:
            Console.WriteLine("\nInvalid choice! Try again.\n");
            break;
    }
}

void PrintInf()
{
    Console.WriteLine("\n\nProject Name: Learning Basics C#");
    Console.WriteLine("Current Topic: C# Basics and Types\n\n\n");
}

void MultiFun()
{
    int x1 = 20;
    int x2 = 30;
    Console.WriteLine($"\n\nCalculation Result ({x1} * {x2}) = {x1 * x2}\n\n");
}