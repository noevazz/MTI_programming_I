using System;

namespace Clases
{
    class Program
    {
        class Matematicas
        {
            int a, b;
            float c, d;
            public Matematicas(int x, int y)
            {
                a = x;
                b = y;
            }
            public Matematicas(float x, float y)
            {
                c = x;
                d = y;
            }
            public Matematicas()
            {
                a = 0;
                b = 0;
                c = 0;
                d = 0;
            }
            public int IntSumar()
            {
                return a + b;
            }
            public float FloatSumar()
            {
                return c + d;
            }
            public int IntRestar()
            {
            return a-b;
            }
        }
        static void Main(string[] args)
        {
            Matematicas o=new Matematicas((float)2.0,(float)2.0);
            Console.WriteLine(o.IntSumar());
            Console.WriteLine(o.FloatSumar());
        }
    }
}