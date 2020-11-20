using System;

namespace CicloCondicionalDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i <= 100);

            Console.WriteLine("En reversa");
            i = 100;
            do
            {
                Console.WriteLine(i);
                i--;

            } while (i >=0);
            Console.WriteLine("Ciclo Anidado");

            i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, (i * j));
                    j++;
                } while (j <= 10);
                i++;
            } while (i <= 10);

        }
    }
}