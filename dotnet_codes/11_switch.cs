using System;

namespace UsodeSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("(A)ltas");Console.WriteLine("(B)ajas");
                Console.WriteLine("(C)onsultas");Console.WriteLine("(S)alir");
               ch = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (Char.ToUpper(ch))
                {
                    case 'A':
                        {
                            Console.WriteLine("Seleccionastes Altas");
                            break;
                        }
                    case 'B':
                        {
                            Console.WriteLine("Seleccionastes Bajas");
                            break;
                        }
                    case 'C':
                        {
                            Console.WriteLine("Seleccionastes Consultas");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No seleccionastes ninguna de las del menu");
                            break;
                        }
                }
                } while (Char.ToUpper(ch)!='S');
        }
    }
}