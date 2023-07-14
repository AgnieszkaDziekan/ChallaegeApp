using System.ComponentModel.Design;

var name = "Agnieszka";
var age = 23;
bool isFemale = true;

if (isFemale)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta przed 30.");
    }
    else if (age == 33 && name == "Agnieszka")
    {
        Console.WriteLine("Agnieszka, 33 lata");
    }
}
else
{
    if (age < 18)

    {
        Console.WriteLine("Niepełnoletni mężczyna");
    }
}