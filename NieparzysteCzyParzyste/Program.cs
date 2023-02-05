using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NieparzysteCzyParzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy podana przez Ciebie liczba jest " +
                "parzysta czy nieparzysta. \nPodaj liczbe:");

            while (true)
            {
                var number = GetNumber();

                if (number % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta." +
                        "\nJeżeli chcesz wyjść wciśnij Q lub podaj kolejną liczbę.");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta." +
                        "\nJeżeli chcesz wyjść wciśnij Q lub podaj kolejną liczbę.");
                }
            }
            Console.ReadKey();
        }
        private static int GetNumber()
        {
            var exit = Console.ReadLine();
            if (exit.ToUpper() == "Q")
                Environment.Exit(0);

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num))

                {
                    Console.WriteLine("Wprowadziłeś błędne dane. Sprbuj ponownie.");
                    continue;
                }
                return num;
                
            }

        }
    }
}

