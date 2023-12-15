// See https://aka.ms/new-console-template for more information
using SchoolGame;

Console.WriteLine("Hello, World!");


Cavaliere cavRosso1= new Cavaliere();
cavRosso1.PuntiSalute = 100;

Cavaliere cavVerde1 = new Cavaliere();
cavVerde1.PuntiSalute = 100;


cavRosso1.Attacca(cavVerde1, 20);

Console.WriteLine($"Cav verde ha ora {cavVerde1.PuntiSalute} punti salute");