// See https://aka.ms/new-console-template for more information
using BikeRental;

Console.WriteLine("Hello, World!");


Bike Bike1 = new Bike(2020, "Toyota", "Yellow", 29182831);
Bike Bike2 = new Bike(2018, "Mile", "Green", 32181881);
Bike Bike3 = new Bike(2002, "Clatter", "White", 28173681);


Console.WriteLine(Bike1);
Console.WriteLine(Bike2);
Console.WriteLine(Bike3);

Console.ReadLine();
BikeKatalog bikeliste = new BikeKatalog();

bikeliste.Add(Bike1);
bikeliste.Add(Bike2);
bikeliste.Add(Bike3);

List<Bike> Bikes = bikeliste.HentAlleBike();

foreach (var item in Bikes)
{
    Console.WriteLine(item);
}

Console.WriteLine(bikeliste.SearchBike(23));

