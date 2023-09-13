using _03_classes_Constructors.Models;

var customer_one = new Customer();

var customer_1 = new Customer
{
    Id = 1,
    Name = "Anton",
    Email = "anton@domain.com",
    PhoneNumber = "1234567890"
};

var customer_2 = new Customer();
customer_2.Id = 2;
customer_2.Name = "Pelle";
customer_2.Email = "pelle@domain.com";


var customer_3 = new Customer("Anton M", "anton@domain.com");

var c4 = new Customer();
