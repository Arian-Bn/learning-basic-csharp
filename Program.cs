using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

while (true)
{
    Console.WriteLine("=== C# LEARNING BASICS MENU ===");
    Console.WriteLine("1. Show Project Info");
    Console.WriteLine("2. Run Calculation (Multiplication)");
    Console.WriteLine("3. Run Password Analyzer");
    Console.WriteLine("4. Run Array Operation (Sum & Max & Search)");
    Console.WriteLine("5. Run List<T> Demonstration");
    Console.WriteLine("6. Run Array input");
    Console.WriteLine("7. Run Shopping List");
    Console.WriteLine("8. Run Phone Book");
    Console.WriteLine("9. Run Chracter Frequency Count");
    Console.WriteLine("10. Run Object Phone Book (List<Contact>)");
    Console.WriteLine("11. Run Task Tracker");
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

        case 7:
            RunShoppingList();
            break;

        case 8:
            RunPhoneBook();
            break;

        case 9:
            RunCountCharacterFrequency();
            break;

        case 10:
            RunObjPhoneBook();
            break;

        case 11:
            RunTaskTrackerDemo();
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
    string[] testPasswords = { "", "123", "ValidPassword123" };

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
    int[] numbers = { 50, -10, 0, -25, 30 };

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

    Console.Write("\nEnter a number to find its index: ");
    if (!int.TryParse(Console.ReadLine(), out int target))
    {
        Console.WriteLine("[ERROR] Invalid number.");
        return;
    }

    int foundIndex = FoundElementIndex(numbers, target);
    if (foundIndex == -1)
    {
        Console.WriteLine($"Element {target} not found in the array.");
    }
    else
    {
        Console.WriteLine($"Element {target} found at index: {foundIndex}");
    }
}

void RunListDemo()
{
    Console.WriteLine("\n--- LIST<T> DEMO ---");
    List<string> tasks = new List<string> { "Learn C#", "Review resume", "Buy milk" };

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

int FoundElementIndex(int[] numbers, int target)
{
    if (numbers == null) return -1;

    if (numbers.Length == 0) return -1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target) return i;
    }

    return -1;
}

void RunShoppingList()
{
    List<string> shoppingList = new List<string>();

    while (true)
    {
        Console.WriteLine("\n--- SHOPPING LIST MENU ---");
        Console.WriteLine("1. View list");
        Console.WriteLine("2. Add item");
        Console.WriteLine("3. Delete item");
        Console.WriteLine("4. Return to Main Menu");
        Console.Write("Select an action: ");

        if (!int.TryParse(Console.ReadLine(), out int action))
        {
            Console.WriteLine("[ERROR] Invalid choice. Please enter a number.");
            continue;
        }

        if (action == 4) break;

        switch (action)
        {
            case 1:
                Console.WriteLine("\n--- YOUR SHOPPING LIST ---");
                if (shoppingList.Count == 0)
                {
                    Console.WriteLine("Your list is empty");
                }
                else
                {
                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {shoppingList[i]}");
                    }
                }
                break;

            case 2:
                Console.Write("Enter item name to add: ");
                string? itemToAdd = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(itemToAdd))
                {
                    Console.WriteLine("[ERROR] Item name cannot be empty.");
                }
                else
                {
                    shoppingList.Add(itemToAdd);
                    Console.WriteLine($"{itemToAdd}  successfully added.");
                }
                break;

            case 3:
                Console.WriteLine("\n--- DELETE ITEM ---");

                if (shoppingList.Count == 0)
                {
                    Console.WriteLine("[ERROR] Nothing to delete. List is empty.");
                    break;
                }

                Console.Write("Enter the item number to delete: ");
                if (!int.TryParse(Console.ReadLine(), out int displayIndex))
                {
                    Console.WriteLine("[ERROR] Please enter a valid number.");
                    break;
                }

                // Convert user 1-based index index back to C# 0-based index
                int actualIndex = displayIndex - 1;

                if (actualIndex < 0 || actualIndex >= shoppingList.Count)
                {
                    Console.WriteLine($"[ERROR] Invalid index. Choose a number between 1 and {shoppingList.Count}.");
                }
                else
                {
                    string removeItem = shoppingList[actualIndex];
                    shoppingList.RemoveAt(actualIndex);
                    Console.WriteLine($"'{removeItem}' successfully removed.");
                }
                break;

            default:
                Console.WriteLine("[ERROR] Invalid choice. Please try again.");
                break;

        }


    }

}

void RunPhoneBook()
{
    // Initialize an empty dictionary where Key is Name and Value is Phone Number
    Dictionary<string, string> PhoneBook = new Dictionary<string, string>() { };

    while (true)
    {
        Console.WriteLine("\n--- PHONE BOOK MENU ---");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Find contact");
        Console.WriteLine("3. Exit");
        Console.Write("Select an action: ");

        string? choiceClient = Console.ReadLine();
        int choiceNum;

        // Validate: check for empty input or failed parsing
        if (string.IsNullOrWhiteSpace(choiceClient) || !int.TryParse(choiceClient, out choiceNum))
        {
            Console.WriteLine("[ERROR] Invalid choise. Try again(1 or 2 or 3).");
            continue;
        }

        if (choiceNum == 3) break;

        switch (choiceNum)
        {
            case 1:
                Console.Write("Please enter name of contact: ");
                string? name = Console.ReadLine();

                // Validation name and prevent duplicate keys
                if (string.IsNullOrWhiteSpace(name) || PhoneBook.ContainsKey(name))
                {
                    Console.WriteLine("[ERROR] Invalid name or contact already exists.");
                    break;
                }

                Console.Write("Enter phone number: ");
                string? phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    Console.WriteLine("[Error] Invalid phone number.");
                    break;
                }

                // Safely add the unique pair to the dictionary
                if (PhoneBook.TryAdd(name, phoneNumber))
                {
                    Console.WriteLine("Contact added to phone book!");
                }
                else
                {
                    Console.WriteLine("[ERROR] Contact could not be added.");
                }
                break;

            case 2:
                Console.Write("Enter name of contact to search: ");
                string? nameSearch = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameSearch))
                {
                    Console.WriteLine("[ERROR] Invalid name.");
                    break;
                }

                // Safely retrieve value by key using TryGetValue to prevent crashes
                if (PhoneBook.TryGetValue(nameSearch, out string? numberSearch))
                {
                    Console.WriteLine($"Found -> {nameSearch}: {numberSearch}");
                }
                else
                {
                    Console.WriteLine($"Contact '{nameSearch}' does not exist.");
                }
                break;

            default:
                Console.WriteLine("[ERROR] Invalid choice. Please select 1, 2, or 3.");
                break;
        }

    }
}

void RunCountCharacterFrequency()
{
    Console.WriteLine("\n--- CHARACTER FREQUENCY COUNT ---");
    Console.Write("Enter a string: ");
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("[ERROR] Input cannot be empty.");
        return;
    }

    // 1. Initialize the dictionary
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    // 2. Loop through each character in the string
    foreach (char ch in input)
    {
        if (charCount.ContainsKey(ch))
        {
            charCount[ch]++;
        }
        else
        {
            charCount.TryAdd(ch, 1);
        }
    }

    // 3. Print the results
    Console.WriteLine("\nCharacter frequencies: ");
    foreach (var pair in charCount)
    {
        Console.WriteLine($"[{pair.Key}]: {pair.Value} time(s)");
    }
}

void RunObjPhoneBook()
{
    List<Contact> objPhoneBook = new List<Contact>();

    while (true)
    {
        Console.WriteLine("\n--- PHONE BOOK MENU ---");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Show all contacts");
        Console.WriteLine("3. Find contact");
        Console.WriteLine("4. Exit");
        Console.Write("Select an action: ");

        string? choice = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(choice) || !int.TryParse(choice, out int input))
        {
            Console.WriteLine($"[ERROR] Invalid choise. Try again(1 or 2 or 3 or 4).");
            continue;
        }

        if (input == 4) break;

        switch (input)
        {
            case 1:
                Console.Write("Please enter name of contact: ");
                string? name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("[ERROR] Invalid name.");
                    break;
                }


                bool foundName = false;
                foreach (var nameSearch in objPhoneBook)
                {
                    if (nameSearch.Name == name)
                    {
                        Console.WriteLine("[Error] Name contacts alreade existed!");
                        foundName = true;
                        break;
                    }
                }

                if (foundName) break;


                Console.Write("Enter phone number: ");
                string? phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    Console.WriteLine("[ERROR] Invalid phone number.");
                    break;
                }

                Contact newContact = new(name, phoneNumber);
                objPhoneBook.Add(newContact);
                Console.WriteLine("New contact was added successfully.");
                break;

            case 2:
                if (objPhoneBook.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                    break;
                }

                foreach (var contact in objPhoneBook)
                {
                    Console.WriteLine($"{contact.Name}: {contact.PhoneNumber}");
                }

                break;

            case 3:
                Console.Write("Enter name of contact: ");
                string? nameContact = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameContact))
                {
                    Console.WriteLine("[ERROR] Invalid name.");
                    break;
                }

                bool found = false;
                foreach (var nameSearch in objPhoneBook)
                {
                    if (nameSearch.Name == nameContact)
                    {
                        Console.WriteLine($"Number: {nameSearch.PhoneNumber}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"\"{nameContact}\" is not found!");
                }

                break;
        }
    }
}

void RunTaskTrackerDemo()
{
    TaskService tasks = new TaskService();

    while (true)
    {
        Console.WriteLine("\n--- TASK SERVICE ---");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Show All");
        Console.WriteLine("3. Complete Task");
        Console.WriteLine("4. Delete Task");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");

        string? inputSt = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputSt) || !int.TryParse(inputSt, out int input))
        {
            Console.WriteLine("[ERROR] Invalid input.");
            continue;
        }

        if (input == 5) break;

        switch (input)
        {
            case 1:
                Console.Write("Enter Id: ");
                string? idTask = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(idTask) || !int.TryParse(idTask, out int id))
                {
                    Console.WriteLine("[ERROR] Invalid Id.");
                    break;
                }

                Console.Write("Enter task: ");
                string? textTask = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(textTask))
                {
                    Console.WriteLine("[ERROR] input is empty.");
                    break;
                }

                tasks.AddTask(id, textTask);
                break;

            case 2:
                var allTasks = tasks.GetAllTasks();

                if (allTasks.Count == 0)
                {
                    Console.WriteLine("List is empty!");
                    break;
                }

                foreach (var i in allTasks)
                {
                    Console.WriteLine($"Id: {i.Id}\tTask: {i.Title}\tStatus: {i.IsCompleted}");
                }
                break;

            case 3:
                Console.Write("Enter Id: ");

                string? idCopm = Console.ReadLine();
                if (string.IsNullOrEmpty(idCopm) || !int.TryParse(idCopm, out int taskId))
                {
                    Console.WriteLine("[ERROR] Invalid Id!");
                    break;
                }

                tasks.CompleteTask(taskId);
                break;

            case 4:
                Console.Write("Enter Id: ");

                string? idDel = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idDel) || !int.TryParse(idDel, out int delId))
                {
                    Console.WriteLine("[ERROR] Invalid id!");
                    break;
                }

                tasks.DeleteTask(delId);
                break;

            default:
                Console.WriteLine("[ERROR] Invalid input!");
                break;
        }
    }
}

class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(string name, string phoneNumber)
    {
        this.Name = name;
        this.PhoneNumber = phoneNumber;
    }
}

class TodoTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; } = false;

    public TodoTask(int id, string title)
    {
        Id = id;

        if (!string.IsNullOrWhiteSpace(title))
        {
            Title = title;
        }
        else
        {
            throw new ArgumentException("Title cannot be empty");
        }
    }
}

class TaskService
{
    private List<TodoTask> _tasks = new List<TodoTask>();

    public void AddTask(int id, string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("[ERROR] Task title cannot be empty!");
        }
        else if (FindById(id) != null)
        {
            Console.WriteLine($"[ERROR] Task with Id {id} already exists!");
        }
        else
        {
            _tasks.Add(new TodoTask(id, name));
            Console.WriteLine("Task was added successfully!");
        }
    }

    public List<TodoTask> GetAllTasks()
    {
        return _tasks;
    }
    public TodoTask? FindById(int id)
    {
        foreach (var i in _tasks)
        {
            if (i.Id == id)
            {
                return i;
            }
        }

        return null;
    }

    public void CompleteTask(int id)
    {
        TodoTask? searchTask = FindById(id);
        if (searchTask == null)
        {
            Console.WriteLine($"Task with Id {id} not found!");
            return;
        }
        else if (searchTask.IsCompleted)
        {
            Console.WriteLine($"Task with Id {id} is already done!");
            return;
        }
        else
        {
            searchTask.IsCompleted = true;
            Console.WriteLine($"Task with Id {id} is done!");
            return;
        }
    }

    public void DeleteTask(int id)
    {
        var resDel = FindById(id);
        if (resDel != null)
        {
            _tasks.Remove(resDel);
            Console.WriteLine($"Task with Id {id} was deleted successfully!");
        }
        else
        {
            Console.WriteLine($"Task with Id {id} does not exist!");
        }
    }
}