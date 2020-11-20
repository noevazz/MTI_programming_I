using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un primer valor:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame un segundo valor:");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("{0}={1}", a, b);
            else
                if(a>b)
                Console.WriteLine("{0}>{1}", a, b);
            else
                Console.WriteLine("{1}>{0}", a, b);

        }
    }
}