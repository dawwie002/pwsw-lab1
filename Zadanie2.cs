using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zadanie2
    {
        public static void zad2()
        {
            // hashset przechowuje tylko unikalne wartosci, jest idealna struktura do wykorzystania przy realizacji tego zadania.
            // <string> - hashset bedzie przechowywal wartosci typu string, co nie ogranicza uzytkownika do wpisywania jedynie liczb
            HashSet<string> uniqueValues = new HashSet<string>();
            do
            {
                //komunikat i pobranie wartosci
                Console.Write("Give value: ");
                string input = Console.ReadLine();

                //dopisanie wartosci pobranej od uzytkownika do hashset'a
                uniqueValues.Add(input);

                //wypisanie wszystkich wartosci w hashset'cie
                Console.WriteLine("Unique values given by user: ");
                foreach(string i in uniqueValues)
                {
                    Console.Write(i+", ");
                }

                //wypisanie liczby unikalnych wartosci w hashset'cie - wlasciwosc .Count
                Console.WriteLine("\n\nCount of unique values given by user: "+uniqueValues.Count);
                Console.WriteLine("---------------------------------------------------------\n");

            } while (true);

            Console.WriteLine("Press any key to close the program.\n");
            Console.ReadKey();
        }
    }
}