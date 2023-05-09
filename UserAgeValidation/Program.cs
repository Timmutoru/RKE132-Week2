// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt
//"Welcom, Mr. [kasutaja perekonnanimi] / Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please select you gender (m/f): ");

char userGender = Char.Parse(Console.ReadLine()); //loeb kosoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else //Kui eelnevad kaks tingimust pole täidetud, kukub valik antud käsule
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
