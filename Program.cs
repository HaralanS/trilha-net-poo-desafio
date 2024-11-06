using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("95412634", "Nokia 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Clash of CLans");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("95412497", "Iphone 13", "2222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Plants vs Zombies");