using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundos | 1s = 1 segundo" );
            Console.WriteLine("M = minutos | 1m = 1 minuto");
            Console.WriteLine("0= Sair do Stopwatch");
            Console.WriteLine("Quanto tempo deseja contar?");


            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }   

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Gooo...");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Start(int time)
        {
            
            
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
             }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
        }
        
        

    }
}   