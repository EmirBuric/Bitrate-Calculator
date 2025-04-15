// See https://aka.ms/new-console-template for more information
using Bitrate_Calculator;


JsonMethods jsonMethods = new JsonMethods();
DeviceData items=jsonMethods.LoadJson();

Console.WriteLine($"Device: {items.Device}");
Console.WriteLine($"Model: {items.Model}");

for (int i = 0;i<items.NIC.Count;i++)
{
    Console.WriteLine($"Descrition: {items.NIC[i].Description}");    
    Console.WriteLine($"MAC Adress: {items.NIC[i].MAC}");      
}