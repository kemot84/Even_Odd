using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć. Witaj w programie określającym podaną liczbę jako parzystą lub nie. Jak będziesz gotowa/y wciśnij ENTER.");
            Console.ReadLine();
            Console.WriteLine("Podaj liczbę: ");

            while (true)
            {
                int number = GetValue();

                if (number % 2 == 0) 
                    Console.WriteLine("\nPodana liczba jest parzysta!");
                else
                    Console.WriteLine("\nPodana liczba jest nieparzysta!");

                Console.WriteLine("\nPodaj kolejną liczbę: ");
            }
        }
        private static int GetValue()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("\nPodałeś nieprawidłową wartość. Spróbuj ponownie: ");
                    continue;
                }
                return number;
            }
        }
    }
}
