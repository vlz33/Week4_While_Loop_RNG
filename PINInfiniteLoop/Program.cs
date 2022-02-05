using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN kood;
            //programm võrdleb sisestatud koodi arvuga 1234;
            //kui sisestatud kood on 1234, siis konsool kuvab "Tere tulemast!;
            //kui sisestatud kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!";
            //katsete arv on piiramatu;
            //programm genereerib numbrit ühe korra;

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast.");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN, proovi uuesti.");
                    Console.WriteLine($"Oled vale koodi sisestand {i} korda");
                }
            }
            Console.WriteLine("Kena päeva.");
        }
    }
}
