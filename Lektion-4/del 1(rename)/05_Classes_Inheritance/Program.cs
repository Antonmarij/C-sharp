using _05_Classes_Inheritance.Models;
using _05_Classes_Inheritance.Services;

//var customer = new Customer()
//{
//    Id = Guid.NewGuid(),
//    Created = DateTime.Now,
//    Modified = DateTime.Now,
//    Email = "anton@domain.com"
//};

//var privateCustomer = new Private_customer()
//{
//    Id = Guid.NewGuid(),
//    FirstName = "Anton",
//    LastName = "M",
//    Email = "anton@domain.com",
//    PhoneNumber = "1234",
//    Modified = DateTime.Now,
//    Created = DateTime.Now,
//};

//var companyCustomer = new Company_Customer()
//{
//    Id = Guid.NewGuid(),
//    CompanyName = "Nackademin",
//    Email = "anton@domain.com",
//    PhoneNumber = "1234",
//    Modified = DateTime.Now,
//    Created = DateTime.Now,
//};

Console.Write("Vad för typ av kund vill du skapa (p = privatperson, f = företag): ");
var option = Console.ReadLine();

switch (option!.ToLower())
{
    case "p":
        CustomerService.CreatePrivateCustomer();
        break;

    case "f":
        CustomerService.CreateCompanyCustomer();
        break;

    default:
        break;

}