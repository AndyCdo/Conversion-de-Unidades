using System;

namespace Conversion_de_Unidades
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Ingrese el valor que quiere convertir: ");
             double valoraConvertir= Convert.ToInt32(Console.ReadLine());
             double pulgada= valoraConvertir / 2.5;

            Console.WriteLine("El resultado es " + pulgada.ToString());
        }
    }
}
