using System;
using System.Linq;

namespace _03.Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNumber = numbers[i];

                try
                {
                    if (currentNumber.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(currentNumber));
                    }
                    else
                    {
                        Console.WriteLine(smartphone.Call(currentNumber));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                string currentUrl = urls[i];

                try
                {
                    Console.WriteLine(smartphone.Browse(currentUrl));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
