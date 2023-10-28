using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("61999999999", "Nokia Realme 11", "916577062629365", 256);
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Iphone");
Iphone iphone = new Iphone("61999999999", "Iphone 13", "936591657706262", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
