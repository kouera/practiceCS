using OOP.Models;

List<Participant> participants = new List<Participant>();

Console.WriteLine("Förnamn: ");
var firsName = Console.ReadLine();

Console.WriteLine("Efternamn: ");
var lastName = Console.ReadLine();

Console.WriteLine("E-postadress: ");
var email = Console.ReadLine();

Console.WriteLine("Specielle Önskmål: ");
var specialRequest = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine($"Deltagarens namn: {firsName} {lastName}");
Console.WriteLine($"Deltagarens email: {email}");
Console.WriteLine($"Specielle Önskmål { specialRequest}");







