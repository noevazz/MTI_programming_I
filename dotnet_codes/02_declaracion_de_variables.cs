using System;

namespace EntradasySalidas
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            try
            {
                Console.WriteLine("Valor uno:");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Valor dos:");
                b = float.Parse(Console.ReadLine());

                float c = a + b;
                Console.WriteLine(a + "+" + b + "=" + c);
            }
            catch
            {
                Console.WriteLine("Error en los datos!!");
            }
        }
    }
}