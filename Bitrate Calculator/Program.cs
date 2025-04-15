// See https://aka.ms/new-console-template for more information
using Bitrate_Calculator;


JsonMethods jsonMethods = new JsonMethods();
DeviceData items=jsonMethods.LoadJson();

Console.WriteLine($"Device: {items.Device}");
Console.WriteLine($"Model: {items.Model}");

Console.WriteLine($"Descrition: {items.NIC[0].Description}");    
Console.WriteLine($"MAC Adress: {items.NIC[0].MAC}");


for (int i = 1;i< items.NIC.Count;i++)
{
    Calculator calculatorTx = new Calculator(items.NIC[i-1].Tx, items.NIC[i].Tx);
    Calculator calculatorRx = new Calculator(items.NIC[i-1].Rx, items.NIC[i].Rx);
    Console.WriteLine("Tx bitrate: ");
    calculatorTx.Calc();
    Console.WriteLine("Rx bitrate: ");
    calculatorRx.Calc();
}



