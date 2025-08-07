using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: "32GB");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.EspecificacoesDoModelo();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "987654321098765", memoria: "128GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.EspecificacoesDoModelo();