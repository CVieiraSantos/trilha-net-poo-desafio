using DesafioPOO.Models;
using DesafioPOO.Interfaces;

IServico servicoNokia = new Nokia();
IServico servicoIphone = new Iphone();

Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia(numero: "1234", modelo: "ModeloNokia", imei: "11111", memoria: 64);
servicoNokia.ReceberLigacao();
servicoNokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
var iPhone = new Iphone(numero: "2345678", modelo: "ModeloIphone", imei: "88888888", memoria: 64);
servicoIphone.ReceberLigacao();
servicoIphone.Ligar();
iPhone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone