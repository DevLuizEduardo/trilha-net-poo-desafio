using System.Text;
using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia ");
Smartphone nokia = new Nokia("1234","Nokia Tijolo","12345678945",64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pac-Man");

Console.WriteLine("---------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone ");
Smartphone iphone = new Iphone("5678","13","12154315164",128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


