using System;

while (true)
{
    Console.WriteLine("Enter your choice(-1 to exit):");
    Console.WriteLine("1. Show the message");
    Console.WriteLine("2. Show the sum");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case -1:
            Console.WriteLine("\nYou have exited! Have a good day");
            return;
        case 1:
            Console.WriteLine("\n\nProject Name: Learning Basics C#");
            Console.WriteLine("Current Topic: C# Basics and Types\n\n\n");
            break;
        case 2:
            int x1 = 20;
            int x2 = 30;
            Console.WriteLine($"\n\nCalculation Result ({x1} * {x2}) = {x1 * x2}\n\n");
            break;
    
        default:
            Console.WriteLine("\nInvalid choice! Try again.\n");
            break;
    }
}
