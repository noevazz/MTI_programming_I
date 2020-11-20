using System;

namespace EntradasSalidasCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            Char Sexo;
            Byte Edad;
            Console.WriteLine("Cual es tu nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Cuale es tu sexo (M)asculino,(F)emenino,(O)tros:");
            Sexo = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEdad:");
            Edad = byte.Parse(Console.ReadLine());
            
            Console.WriteLine("Hola "+Nombre+"\nSexo="+Sexo);
            Console.Write("Edad={0}\n", Edad);
            

        }
    }
}