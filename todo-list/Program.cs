using System;

class Program
{
    static void Main(string[] args)
    {
        var todoList = new ToDoList();

        while (true)
        {
            Console.WriteLine("\nTo-Do List App");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Print List");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a new item: ");
                    string newItem = Console.ReadLine();
                    todoList.AddItem(newItem);
                    break;

                case "2":
                    // Add code for removing an item
                    break;

                case "3":
                    todoList.PrintList();
                    break;

                case "4":
                    Environment.Exit(0); // Exit the program gracefully
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
