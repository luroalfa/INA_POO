//Realice un programa en C# en donde solicite al usuario ingresar una cantidad de MB,
//y se muestre en pantalla su equivalencia en bits, byte, kilobyte y Gigabytes.

using System;

class ConversionMegabytes
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de MB: ");
        double megabytes = double.Parse(Console.ReadLine());

        Console.WriteLine("Equivalencias de " + megabytes + " MB:");
        Console.WriteLine("Bits: " + (megabytes * 8 * 1024 * 1024));
        Console.WriteLine("Bytes: " + (megabytes * 1024 * 1024));
        Console.WriteLine("Kilobytes: " + (megabytes * 1024));
        Console.WriteLine("Gigabytes: " + (megabytes / 1024));
    }
}
