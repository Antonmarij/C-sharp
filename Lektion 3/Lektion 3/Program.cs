var firstName = "Anton";
var lastName = "Marijanovic";

//string sentence = "Jag är \"bäst\" i hela världen";

string firstNameAndLastName = $"Hej jag heter {firstName} {lastName}";

//Stora bokstäver/små bokstäver genom att använda ToUpper och ToLower
//----------------------------------------------------------------------


//string email = "anton_m00@hotmail.com";
//Console.WriteLine($"Original: {email}");
//Console.WriteLine($"ToUpper: {email.ToUpper()}");
//Console.WriteLine($"ToLower: {email.ToLower()}");
//Console.WriteLine();


//Console.WriteLine($"{firstName} {lastName}");
//Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");
//Console.WriteLine();

//Byta ut valfria tecken med hjälp av .Replace
//----------------------------------------------

//string sentence = "Här har vi en text om är på svenska.";
//Console.WriteLine(sentence.Replace("ä", "a"));
//Console.WriteLine();

//string name = "anton_m00";
//string domain = "hotmail com";
//string email = $"{name}@{domain}";
//Console.WriteLine(email);
//email = email.Replace(" ", ".").ToLower();
//Console.WriteLine(email);


/* 
 INTEGRALS & FLOATING PONTS
------------------------------------------------------------------------

    Type    Bits    Range(min,max)
-------------------------------------------------
    byte    8       0                        255
    sbyte   8       -128                    127
    short   16      -32768                  32767
    ushort  16      0                       65535
    int     32      -2147483648             2147483647 
    uint    32      0                       4294967295
    long    64      -9223372036854775808    9223372036854775807
    ulong   64      0                       18446744073709551615

    int age = 39;
    long age = 39;

    Type    Bytes   Decimal-Range   Suffix
----------------------------------------------
    float   4       6-9 digits      f & F
    double  8       15-16 digits    inget/ d & D
    decimal 16      28-29 digits    m & M
*/

//    float floatValue = 0.1f + 0.1f + 0.1f;
//Console.WriteLine(floatValue);

//double doubleValue = 0.1 + 0.1 + 0.1;
//Console.WriteLine(doubleValue);

//decimal DecimalValue = 0.1m + 0.1m + 0.1m;
//Console.WriteLine(DecimalValue);

/*
    BOOLEAN - True/False

    TYPE        Bits
----------------------------------------------------------------------------------
    bool        0/1         false/true

    bool isEnabled = false;
    bool isActive = true;
*/

/*
    GUID/UUID (Globally Unique Identifier)
---------------------------------------------------------------------------------------
    Guid        16 bytes        Guid.NewGuid();    188e334e-a983-49eb-8712-349bb3293bfd

Guid userId = Guid.NewGuid();
    Console.WriteLine(userId);
*/