using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zadanie3
    {
        public static void zad3()
        {
            
            do
            {
                bool isCorrect = true;
                bool isHole = false;
                int holeCount = 0;
                Console.Write("Give binary number [only 0's and 1's]: ");
                string input = Console.ReadLine();

                // sprawdzenie czy uzytkownik wpisal cokolwiek
                if (input != "")
                {
                    // sprawdzenie czy podane znaki to ciag 0 i 1
                    foreach(char chr in input)
                    {
                        if(!(chr == '0' || chr == '1'))
                        {
                            Console.WriteLine("You have provided a string with characters other than 0's and 1's");
                            isCorrect = false;
                            break;
                        }
                    }
                    // jesli sa inne znaki niz 0 i 1 - uzytkownik musi podac inna wartosc
                    if (!isCorrect) continue;

                    //usuniecie/przyciecie zer z konca i poczatku zmiennej string
                    string trimmed = input.Trim('0');
                    
                    // sprawdzanie i zliczanie dziur binarnych
                    foreach (char chr in trimmed)
                    {
                        if (chr == '0' && isHole == false)
                        {
                            holeCount++;
                            isHole = true;
                        }
                        if (chr == '1' && isHole == true)
                        {
                            isHole = false;
                        }
                    }

                    // komunikat zwrotny
                    Console.WriteLine("For sequence"+input+" there are " + holeCount+" binary holes.");
                }


                // jeśli uzytkownik nic nie poda
                else
                {
                    Console.Write("You didn't provide anything!\n\n");
                }
            } while (true);
            
            Console.WriteLine("Press any key to close the program.\n");
            Console.ReadKey();
        }
    }
}
