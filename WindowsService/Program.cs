//See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Swapi.Core.SwapiTools obj = new Swapi.Core.SwapiTools();
Console.WriteLine(DateTime.Now);
var people = obj.GetAllPersons();
Console.WriteLine(people.Count());
Console.WriteLine(DateTime.Now);
Console.ReadLine();
