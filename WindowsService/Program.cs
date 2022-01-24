//See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
StarWarAPI.Core.StarWarApiService obj = new StarWarAPI.Core.StarWarApiService();
Console.WriteLine(DateTime.Now);
var Starships = obj.GetAllStarships();
Console.WriteLine(Starships.Count());
Console.WriteLine(DateTime.Now);
Console.ReadLine();
