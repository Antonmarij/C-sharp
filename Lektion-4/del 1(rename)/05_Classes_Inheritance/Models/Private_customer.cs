using System.Security.Cryptography.X509Certificates;

namespace _05_Classes_Inheritance.Models;

internal class Private_customer : Customer 
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; } 


}
