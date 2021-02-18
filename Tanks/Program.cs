using System;
using Tanks;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            tank[] VIN = new tank[5];
            tank[] T34 = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                VIN[i] = new tank();
            }
            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            }
            tank[] pantera = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                pantera[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "pantera");
            }
            for (int i = 0; i < 5; i++)
            {
                T34[i].Print();
                pantera[i].Print(); ;
                VIN[i] = T34[i] * pantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                VIN[i].Print();
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}