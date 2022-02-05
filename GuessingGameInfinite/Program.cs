using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja arvas numbri ära, siis on ta mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;


            while (loopActive)
            {
                Console.WriteLine("Sisesta arv 1 ja 10 vahel");
                int randomNumber = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, arvasid numbri ära!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine($"Vale vastus, proovi uuesti.");
                    i++;
                    Console.WriteLine($"Oled proovinud {i} korda:)");
                }

            }


        }
    }
}
