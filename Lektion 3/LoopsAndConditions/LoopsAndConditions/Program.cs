/* Operander
 
-----------------------------------------
    ==  lika med
    !=  inte lika med
    <   mindre än
    >   större än
    <=  mindre eller lika med
    >=  större eller lika med
    &&  och
    ||  eller
    !   inte
    ??  om första värdet är null välj det andra
*/

/* Arrays
-------------------------------------------------
    En array är en statiskt lista med fixerat antal platser
    som man varken kan lägga till nya eller ta bort men det
    går att byta ut informationen i en specifik plats.

    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Jeanette" };
    string[] names = new string[10];
    names[0] = "Hans";
    names[1] = "Tommy";
    names[3] = "Jeanette";
*/

/*  IF-Satser
 ---------------------------------------------
    if (statement) {}

    if (statement) {} else {}
    
    if (statement) {} else if (statement) {} else {}

    (statement) ? do_this : else_do_this;
*/
/*
string firstName = "Anton";
string lastName = null!;

if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
    Console.WriteLine("Some of the values are null!");
}
*/
/*
string firstName = null;

if (!string.IsNullOrEmpty(firstName))
{
    Console.WriteLine("Now we are doing something with our first name");
}
else
{
    Console.WriteLine("There is no first name.");
}
*/
/*
string key = "pink";

if (key == "blue")
{
    Console.WriteLine("Unlock blue door");
}
else if (key == "orange")
{
    Console.WriteLine("Unlock orange door");
}
else
{
    Console.WriteLine("You have no key that fits these doors!");
}
*/

//  SWITCH
//----------------------------------------------------------------
/* string key = "pink";

switch(key)
{
    case "blue":
        Console.WriteLine("Unlock blue door");
        break;

    case "orange":
        Console.WriteLine("Unlock orange door");
        break;

    case "gray":
        Console.WriteLine("Unlock gray door");
        break;

    case "black":
        Console.WriteLine("Unlock black door");
        break;

    default:
        Console.WriteLine("You have no key that fits these doors");
        break;
}
*/

/* FOR-LOOP
 --------------------------------------------------------------------
    Vi loopar igenom en lista eller gör något ett givet antal gånger
    for (initialize value; condition; increment initizialized value)
    {
    }

    for (int = 0; i < 10; i++)
    {
        Console.WriteLine($"i: {i}");
    }

    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Jeannette" };

    names[2] = "Tommy";

    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine(names[i]);
    }

*/

/* FOREACH-LOOP
 --------------------------------------------------------------
    Vi loopar igenom alla objekt i en lista

    foreach (var object in list)
    {
    }

    string[] names = new string[] {"Hans", "Tommy", "Joakim", "Jeanette"};

    names[2] = "Tommy";

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }
*/

/*  DO-WHILE LOOP
 -------------------------------------------------------
    gör loopen minst en gång sen kollar den tillståndet

    do
    {   
    } while (statement);

    int number = 0;

    do
    {
        Console.WriteLine(number);
        number++;

    } while(number<10);

*/