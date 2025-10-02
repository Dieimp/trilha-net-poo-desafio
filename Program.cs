using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia! ");
Nokia nokia = new Nokia("9999999999", "Tijolao", "45354534", 36);
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();


Console.WriteLine("Iphone! ");
Iphone iphone = new Iphone("9999999998", "iphone15", "455653678898", 36);
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();