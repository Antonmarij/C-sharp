//enradskommentar
/*
 * kommentar flera rader
 * 
 * 
 * C# Standard datatyper som används
 * --------------------------------------------------------------
 * string   (text)              string_name="Anton"; V
 * int      (heltal)            int age = 39; V
 * long     (heltal)            long age = 39;
 * decimal  (decimaltal)        decimal length = 164.5m; V
 * double   (decimaltal)        double length = 164.5;
 * float    (decimaltal)        float length = 164.5f;
 * bool     (true/false)        bool isHuman = true; V
 * char     (enskilt tecken)    char gender = 'm';
 * dynamic  (vad somhelst)      dynamic lastName = "Marijanovic";
 *                              dynamic weight = 82,5;
 * Guid     (globalt unikt id)  Guid id = Guid.NewGuid(); V
 * byte                         byte = 0;
 * null     (void/ingenting)
 * object
 */

/*
 * Deklarera variabler i C#
 * --------------------------------------------
 * Hur skriver vi variabel namn:
 * 
 * camelCase        firstName       string firstName = "Anton";
 * Pascal           FirstName       string FirstName = "Anton";
 * kebab-case       first-name      string first-name = "Anton";
 * snake_case       first_name      string first_name = "Anton";
 * 
 * C# använder Pascal och ibland camelCase
 * 
 * korrekt sätt att deklarera:          string firstName = "Anton";
 * latmanssättet att deklarera:         var firstName = "Anton";
 * 
 */

/*
 *  String - textbaserade värden
 *  -------------------------------------------
 *  
string firstName = "Anton";
var lastName = "Marijanovic";

string sentence_1 = "Det här är en mening";
string sentence_2 = "Det här är en \"mening\"";

string url_1 = "c:\\skola\\C-sharp\\Exercises";
string url_2 = @"c:\skola\C-sharp\Exercises";

string placeholder_1 = "Hej jag heter" + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0} {1}", firstName, lastName);
 *  
 *  
 *  
 * 
 */
List<string> tasks = new List<string>();

while (true) {
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice) {
        case 1:
            Console.Write("Enter a new task: ");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            Console.WriteLine("Task added!");
            break;

        case 2:
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++) {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
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



    
