// See https://aka.ms/new-console-template for more information
using Bitrate_Calculator.Models;
using Bitrate_Calculator.Services;


JsonMethods jsonMethods = new JsonMethods();
DeviceData items=jsonMethods.LoadJson();

Console.WriteLine($"Device: {items.Device}");
Console.WriteLine($"Model: {items.Model}");

Console.WriteLine($"Descrition: {items.NIC[0].Description}");    
Console.WriteLine($"MAC Adress: {items.NIC[0].MAC}");

Calculator calculatorTx = new Calculator();
Calculator calculatorRx = new Calculator();

for (int i = 1;i< items.NIC.Count;i++)
{
    Console.WriteLine("Tx bitrate: ");
    calculatorTx.Calc(items.NIC[i - 1].Tx, items.NIC[i].Tx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
    Console.WriteLine("Rx bitrate: ");
    calculatorRx.Calc(items.NIC[i - 1].Rx, items.NIC[i].Rx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
}



