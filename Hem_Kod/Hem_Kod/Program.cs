/* Program hemma
 ----------------
*/

List<string> tasks = new List<string>();

while (true)
{
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter a new task: ");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            Console.WriteLine("Task added!");
            break;

        case 2:
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}"); // Fix the typo here, add closing curly brace and quotes.
            }
            break;

        case 3:
            Console.WriteLine("Exiting...");
            return;

        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
}
