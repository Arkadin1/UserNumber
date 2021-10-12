using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNumber
{
    class Program
    {
        static void Main()
        {         
                var number = UserNumber();
                CheckNumber(number);
            
        }

        private static int UserNumber()
        {

            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą");
                if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
                {
                    Console.WriteLine("Podano błędne dane");
                    Console.WriteLine("Aby wpisać dane jeszcze raz, kliknij enter");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    return number;

                }

            }
        }

        private static void CheckNumber(int checkNumber)
        {
            if (checkNumber % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");

            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");

            }
        }
    }
}

