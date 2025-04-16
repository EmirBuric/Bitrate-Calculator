using BitrateCalculator.Interfaces;
using BitrateCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Services
{
    public class WriteData : IWriteData
    {
        public void Write()
        {
            JsonMethods jsonMethods = new JsonMethods();
            DataStrings itemStrings = jsonMethods.LoadJson();

            DeviceData items = jsonMethods.ManualParse(itemStrings);

            Console.WriteLine($"Device: {items.Device}");
            Console.WriteLine($"Model: {items.Model}");

            Console.WriteLine($"Descrition: {items.NIC[0].Description}");
            Console.WriteLine($"MAC Adress: {items.NIC[0].MAC}");

            Calculator calculatorTx = new Calculator();
            Calculator calculatorRx = new Calculator();

            for (int i = 1; i < items.NIC.Count; i++)
            {
                string currentTime = items.NIC[i].Timestamp.ToString("dd.MM.yyyy. HH:mm:ss.fff");
                Console.WriteLine($"Current time: {currentTime}");
                Console.WriteLine("Tx bitrate: ");
                calculatorTx.Calc(items.NIC[i - 1].Tx, items.NIC[i].Tx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
                Console.WriteLine("Rx bitrate: ");
                calculatorRx.Calc(items.NIC[i - 1].Rx, items.NIC[i].Rx, items.NIC[i - 1].Timestamp, items.NIC[i].Timestamp);
                if (i < items.NIC.Count - 1)
                {
                    ClearCurrentData();
                }

            }
        }
        private static void ClearCurrentData()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor - 5);
            Thread.Sleep(1000);
        }
    }
}
