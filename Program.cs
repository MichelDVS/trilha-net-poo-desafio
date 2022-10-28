using DesafioPOO.Models;
//IMPLEMENTADO

Smartphone nokia = new Nokia(numero: "98888-8888", modelo: "xc4562", imei: "1234567890", memoria: 128);

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Nokia modelo: {nokia.Modelo} com imei número: {nokia.Imei} de {nokia.Memoria} Gb de memória");
Console.WriteLine($"Número da linha: {nokia.Numero}");

nokia.Ligar();

nokia.ReceberLigacao();

nokia.InstalarAplicativo("emulador do Iphone");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "91234-1234", modelo: "Iphone30", imei: "0987654321", memoria: 256);

Console.WriteLine($"Smartphone Iphone modelo: {iphone.Modelo} com imei número: {iphone.Imei} de {iphone.Memoria} Gb de memória");
Console.WriteLine($"Número da linha: {iphone.Numero}");

iphone.Ligar();

iphone.ReceberLigacao();

iphone.InstalarAplicativo("emulador do Nokia");

Console.WriteLine("\n");