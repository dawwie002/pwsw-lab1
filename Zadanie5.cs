using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zadanie5
    {
        public static void zad5()
        {
            do
            {
                int y;
                bool isPrime=true;
                // pobranie wartosci
                Console.Write("Give number [Type 'x' to end]: ");
                string input = Console.ReadLine();
                // jesli uzytkownik wpisze 'x' program sie zakonczy
                if (input == "x")
                {
                    break;
                }

                // konwersja danych wejsciowych na typ int
                if (int.TryParse(input, out y))
                {
                    // sprawdzanie czy liczba jest pierwsza dla [2,3,4,...,sqrt(y)]
                    double n = Math.Sqrt(y);

                    // jedynka nie jest liczba pierwsza
                    if (y == 1)
                    {
                        Console.WriteLine("Is " + y + " a prime number?: " + false);
                        continue;
                    }

                    for (int i = 2; i <= n; i++)
                    {
                        // jesli reszta z dzielenia == 0, to liczba nie jest pierwsza - false
                        if (y % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    Console.WriteLine("Is "+y+" a prime number?: "+isPrime);
                }   
                else
                {
                    Console.WriteLine("Value provided is not an integer!");
                }
            }while(true);

            Console.WriteLine("Press any key to close the program.\n");
            Console.ReadKey();
        }
    }
}
