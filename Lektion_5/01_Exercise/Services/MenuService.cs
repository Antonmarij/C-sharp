using _01_Exercise.Interfaces;
using _01_Exercise.Models;

namespace _01_Exercise.Services;

internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}


internal class MenuService : IMenuService
{
    private readonly IUserService _userService = new UserService();



    public void MainMenu()
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Create new user");
            Console.WriteLine("2. Show specific user");
            Console.WriteLine("3. Show all users");
            Console.WriteLine("0. Exit");
            Console.Write("Choose one of the options above (0-4): ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateMenu();
                    break;
                    
                case "2":
                    ListSpecificMenu();
                    break;

                case "3":
                    ListAllMenu();
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    break;
            }
        }
        while (exit == false);
    }



    public void CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("Create a new user");
        Console.WriteLine("------------------");

        var user = new UserCreateRequest();

        Console.Write("First name: ");
        user.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Last name: ");
        user.LastName = Console.ReadLine()!.Trim();

        Console.Write("Email: ");
        user.Email = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Password: ");
        user.Password = Console.ReadLine()!.Trim();

        _userService.CreateUser(user);
        Console.WriteLine("A new user has been created!");
        Console.ReadKey();


    }

    public void ListAllMenu()
    {
        Console.Clear();
        Console.WriteLine("All users");
        Console.WriteLine("-----------------------------------------------------");

        foreach(var user in _userService.GetUsers())
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");

        Console.ReadKey();
    }

    public void ListSpecificMenu()
    {
        Console.Clear();
        Console.WriteLine("Specific user");
        Console.WriteLine("-----------------------------------------------------");
        Console.Write("Email: ");
        var email = Console.ReadLine()!.Trim().ToLower();
        var user = _userService.GetUser(user => user.Email == email);

        if (user != null)
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
        else
            Console.WriteLine($"Could not find a user with the given email {email}");
        Console.ReadKey();
    }


}