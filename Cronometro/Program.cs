using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 1000000000;
            
            int currentTime = 0;

            while (time != currentTime)
            {
                currentTime++;
                Console.WriteLine(currentTime);
             }
        }
        
        

    }
}   