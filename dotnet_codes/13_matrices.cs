using System;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de columnas:");
            int n = int.Parse(Console.ReadLine());            
            Console.WriteLine("Numero de renglones:");
            int m = int.Parse(Console.ReadLine());
            int[,] x = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.WriteLine("Teclea el elemento x[{0},{1}]:", i, j);
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Los elementos almacenados en la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Teclea el elemento x[{0},{1}]={2}", i, j,x[i,j]);
                }
            }
        }
    }
}