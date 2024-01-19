// See https://aka.ms/new-console-template for more information
using BikeRental;

Console.WriteLine("Hello, World!");



Bike Bike1 = new Bike(2020, "Toyota", "Yellow", 29182831);
Bike Bike2 = new Bike(2018, "Mile", "Green", 32181881);
Bike Bike3 = new Bike(2002, "Clatter", "White", 28173681);
Bike Bike4 = new Bike(2002, "Clatter", "White", 28173747);
Bike Bike5 = new Bike(2018, "Mile", "Green", 321818817);
Bike Bike6 = new Bike(2018, "Mile", "Green", 321812323);





Console.WriteLine(Bike1);
Console.WriteLine(Bike2);
Console.WriteLine(Bike3);

Console.ReadLine();
BikeKatalog bikeliste = new BikeKatalog();


bikeliste.Add(Bike1);
bikeliste.Add(Bike2);
bikeliste.Add(Bike3);
bikeliste.Add(Bike4);
bikeliste.Add(Bike5);
bikeliste.Add(Bike6);


try
{
    bikeliste.Add(Bike3);
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Error: {ex}");
}
Console.ReadLine();

List<Bike> Bikes = bikeliste.HentAlleBike();    

foreach (var item in Bikes)
{
    Console.WriteLine(item);
}
Console.ReadLine();
Console.WriteLine(bikeliste.SearchBike(23));


Console.ReadLine();



Ebike ecykel1 = new Ebike("10 W", 1999, "Lars Motor service", "halvt sort", 102);
Ebike ecykel2 = new Ebike("50 W", 1820, "Jonny Motor service", "halv hvid", 190);

Console.WriteLine(ecykel1);
Console.WriteLine(ecykel2);
Console.ReadLine();
bikeliste.Add(ecykel1);
bikeliste.Add(ecykel2);


foreach (var item in Bikes)
{
    Console.Write("item: ");
    Console.WriteLine(item);

}
Console.ReadLine();

bikeliste.Remove(190);
Console.ReadLine();
foreach (var item in Bikes)
{
    Console.Write("item: ");
    Console.WriteLine(item);

}

Console.ReadLine();

List<Bike> resultatbikes = bikeliste.SearchBikesOfModel("");

foreach (var item in resultatbikes)
{
    Console.WriteLine(item);
}


bikeliste.DeleteBikesOfModel("Mile");

foreach (var item in Bikes)
{
    Console.Write("item: ");
    Console.WriteLine(item);

}
