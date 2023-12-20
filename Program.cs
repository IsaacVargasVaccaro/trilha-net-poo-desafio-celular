using System.Runtime.InteropServices;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia(numero: "46136951", modelo: "modelo-XT", imei: "4232161", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine();


Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone (numero: "462462", modelo: "modelo-15", imei: "123456789", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Google");