using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zadanie4
    {
        public static void zad4()
        {
            //deklaracje zbiorów
            HashSet<string> setA = new HashSet<string>();
            HashSet<string> setB = new HashSet<string>();
            HashSet<string> setResult = new HashSet<string>();

            //pobranie wartosci
            Console.Write("How many values for set A?: ");
            getHashSetValues(setA);
            Console.Write("How many values for set B?: ");
            getHashSetValues(setB);

            //wyswietlenie wartosci ze zbiorow
            Console.WriteLine("Values of set A: ");
            showHashSetValues(setA);
            Console.WriteLine("Values of set B: ");
            showHashSetValues(setB);

            //suma, konwersja na HashSet -> union zwraca IEnumerable<string> a nie HashSet
            setResult = setA.Union(setB).ToHashSet();
            Console.WriteLine("Union of sets A and B: ");
            showHashSetValues(setResult);

            //roznica
            setResult = setA.Except(setB).ToHashSet();
            Console.WriteLine("Except of sets A and B: ");
            showHashSetValues(setResult);

            //czesc wspolna
            setResult = setA.Intersect(setB).ToHashSet();
            Console.WriteLine("Intersection of sets A and B: ");
            showHashSetValues(setResult);

            //r. symetryczna - .ToHashSet nie działa, trzeba odjac czesc wspolna od isniejacego set'u
            setResult = setA;
            setResult.SymmetricExceptWith(setB);
            Console.WriteLine("Symmetric difference of sets A and B: ");
            showHashSetValues(setResult);

            Console.WriteLine("Press any key to close the program.\n");
            Console.ReadKey();
        }



        // metoda przyjmujaca od uzytkownika wartosci do zapisania w odpowiednim zbiorze.
        internal static void getHashSetValues(HashSet<string> set)
        {
            while (true)
            {
                int countOfValues;
                string input = Console.ReadLine();
                // pobranie pierwszej wartosci jako liczba
                if (int.TryParse(input, out countOfValues))
                {
                    // pobranie tylu elementow ile wskazal uzytkownik
                    for (int i = 0; i < countOfValues; i++)
                    {
                        // wskazanie ktory element aktualnie podaje uzytkownik
                        Console.Write("Provide value #" + (i + 1) + " of set: ");
                        set.Add(Console.ReadLine());
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You have given values that are not an integer");
                    continue;
                }
            }
        }

        // metoda wyswietlajaca zawartosc zbiorów.
        internal static void showHashSetValues(HashSet<string> set)
        {
            // wypisanie kazdego elementu setu po przecinku
            foreach(string value in set) { 
                Console.Write(value+", "); 
            }
            Console.Write("\n\n");
        }
    }
}
