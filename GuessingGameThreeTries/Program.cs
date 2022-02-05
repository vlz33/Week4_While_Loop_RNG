using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 -10;
            //kasutaja peab selle ära arvama;
            //kui kasutaja suutis selle ära arvata, siis on kasutaja mängu võitnud;
            //kasutajal on kolm katset, kui numberit ära ei arvata, siis mängu võidab arvuti;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta arv 1 ja 10 vahel");
                int randomNumber = Convert.ToInt32(Console.ReadLine());
                
                if (randomNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, arvasid numbri ära!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale vastus, proovi uuesti. {3 - i} katset jäänud.");
                }

            }
            Console.WriteLine($"Kas mängime veel?");

            
        }
    }
}
