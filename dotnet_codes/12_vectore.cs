using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Cuantos elementos quieres capturar:");
            n = int.Parse(Console.ReadLine());
            int[] x= new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Teclea el valor para x[{0}]:", i);
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Se almacenaron {0} elementos, los cuales son:", x.Length);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[{0}]={1}", i,x[i]);
            }
        }
    }
}