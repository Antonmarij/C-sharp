using _02_classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();


//set - sätt ett värde
customer.FirstName = "Anton ";
customer.LastName = "M";

//get - hämta värdet
var name = customer.FullName;


var user = new User();
user.FirstName = "Anton";
user.LastName = "M";
user.Email = " Anton.m@domain.com";


user.SetSecurePassword("ChangeMe123!");

var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"Password: {password}");
Console.ReadKey();

