using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teclea un valor numerico:");
            int n = int.Parse(Console.ReadLine());

            if ((n % 2) == 0)
                Console.WriteLine("{0} es par", n);
            else
                Console.WriteLine("{0} es impar", n);

        }
    }
}