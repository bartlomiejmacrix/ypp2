
using Microsoft.VisualBasic;

namespace Exercise_5._3._1.API
{
    public class TimePrintingService : ITimePrintingService
    {
        public void PrintTime(DateTime time)
        {
            Console.WriteLine($"Long date string:  \"{time.ToLongDateString()}\"\n");
            Console.WriteLine($"Short date string:  \"{time.ToShortDateString()}\"\n");
        }
    }
}
