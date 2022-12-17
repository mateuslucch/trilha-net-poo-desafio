using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("55 81165555", "Tijolão", "6666699", 64000);
Iphone iphone1 = new Iphone("555 66666", "Oquecustaumrim4Pro", "777882", 128000);

nokia1.Ligar();
nokia1.InstalarAplicativo("Zapzap");
nokia1.ReceberLigacao();

Console.WriteLine("\n");

iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("DioApp");