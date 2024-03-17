using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zadanie1
    {
        // generator liczb losowych
        static Random rnd = new Random();

        // deklaracje zmiennych - x = metoda .next losujaca liczbe z przedzialu 1-10
        static int x=rnd.Next(1,11);
        static int y;

        public static void zad1()
        {
            // komunikat w konsoli
            Console.WriteLine("You're playing \"Guess the number\"");            
            do // petla do while (true) - break konczy dzialanie petli
            {
                Console.Write("Give number: ");
                // pobranie wartosci od uzytkownika
                string input = Console.ReadLine();
                // konwersja danych ze strumienia wejsciowego na typ int
                if(int.TryParse(input,out y))
                {
                    // jesli w przedziale od 1 do 10.
                    if (y >= 1 && y <= 10)
                    {
                        // jesli wieksze od Y wieksze od X
                        if (y>x)
                        {
                            Console.WriteLine("Your guess is higher than the X number.\n");
                        }
                        // jesli wieksze od X wieksze od Y
                        else if (y<x)
                        {
                            Console.WriteLine("Your guess is lower than the X number.\n");
                        }
                        // jesli Y rowne X
                        else if (y == x)
                        {
                            Console.WriteLine("Bravo, you've correctly guessed the number!");
                            // po wytypowaniu liczby przerwanie petli i koniec programu.
                            break;
                        }
                    }
                    //komunikat o wpisaniu liczby spoza przedzialu 1-10
                    else
                    {
                        Console.WriteLine("Your number is not between 1 and 10.\n");
                    }
                }
                // komunikat o wpisaniu wartosci ktora nie jest liczba calkowita
                else
                {
                    Console.WriteLine("You gave a value that is not a number.\n");
                }
            } while(true);

            //oczekiwanie na wcisniecie przycisku zeby zakonczyc program
            //pozwala to na zobaczenie ostatniej wiadomosc przed zakonczeniem programu
            Console.WriteLine("Press any key to close the program.\n");
            Console.ReadKey();

        }
    }
}