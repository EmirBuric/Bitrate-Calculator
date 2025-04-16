// See https://aka.ms/new-console-template for more information
using Bitrate_Calculator.Models;
using Bitrate_Calculator.Services;
using System.Globalization;


JsonMethods jsonMethods = new JsonMethods();
DataStrings itemStrings=jsonMethods.LoadJson();

DeviceData items= jsonMethods.ManualParse(itemStrings);

Console.WriteLine($"Device: {items.Device}");
Console.WriteLine($"Model: {items.Model}");

Console.WriteLine($"Descrition: {items.NIC[0].Description}");    
Console.WriteLine($"MAC Adress: {items.NIC[0].MAC}");

Calculator calculatorTx = new Calculator();
Calculator calculatorRx = new Calculator();

for (int i = 1;i< items.NIC.Count;i++)
{
    string currentTime =items.NIC[i].Timestamp.ToString("dd.MM.yyyy. HH:mm:ss.fff");
    Console.WriteLine($"Current time: {currentTime}");
    Console.WriteLine("Tx bitrate: ");
    calculatorTx.Calc(items.NIC[i - 1].Tx, items.NIC[i].Tx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
    Console.WriteLine("Rx bitrate: ");
    calculatorRx.Calc(items.NIC[i - 1].Rx, items.NIC[i].Rx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
}



