Console.WriteLine("Ingrese precio por pelicula");
string numpeli = Console.ReadLine();

Console.WriteLine("Ingrese cantidad de peliculas");
string cantpeli = Console.ReadLine();


Console.WriteLine("Ingrese precio de Disco");
string numDisco = Console.ReadLine();

Console.WriteLine("Ingrese cantidad de Discos");
string cantdisco = Console.ReadLine();


float numpeli = float.Parse(numpeli);
float cantpeli = float.Parse(cantpeli);

float numdisco = float.Parse(numdisco);
float cantdisco = float.Parse(cantdisco);


float resultadofresco = numfrescof * cantfrescof;
float resultadopanes = numpanesf * cantpanesf;

float total = resultadofresco + resultadopanes;
Console.WriteLine("Total a pagar");

Console.WriteLine("De fresco: "+resultadofresco);
Console.WriteLine("De panes: "+resultadopanes);
Console.WriteLine(total);
