// milk taski




using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] milkarr = new Milk[0];

            string c = "";

            do
            {
                Milk milk = new();

                Console.Write("Adi daxil edin: ");
                milk.Name = Console.ReadLine();
                Console.Write("Qiymeti Daxil edin: ");
                milk.Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hecmi daxil edin: ");
                milk.Volume = Convert.ToDecimal(Console.ReadLine());
                Console.Write("YAgliligi daxil edin: ");
                milk.FatRate = Convert.ToInt32(Console.ReadLine());

                string empty = " ";

                if (milk.Name != empty && milk.Price > 0 && milk.Volume > 0 && milk.FatRate > 0)
                {
                    Array.Resize(ref milkarr, milkarr.Length + 1);
                    milkarr[milkarr.Length - 1] = milk;

                }
                else
                {
                    Console.WriteLine("sehv oldu");
                }

                Console.WriteLine("yeni sud elave etmek isteyirsizniz? yox/he");
                c = Console.ReadLine();

            } while (c == "y0x");

            for (int i = 0; i < milkarr.Length; i++)
            {
                
                Console.WriteLine($"Name: {milkarr[i].Name}\nPrice: {milkarr[i].Price}$\nVolume: {milkarr[i].FatRate}%");
                
            }
        }
    }
}