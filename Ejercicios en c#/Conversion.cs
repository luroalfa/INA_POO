//Conversión de horas, minutos y segundos a segundos.
//Solicite al usuario ingresar una cantidad de horas, una cantidad de minutos y una cantidad de segundos,
//y el programa debe indicar cuantos segundos representan los datos ingresados.
//Ejemplo: 1 hora, 26 minutos y 40 segundos,equivalen a 5200 segundos.

using System;

class Conversion
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de horas: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        Console.WriteLine("El total de segundos es: " + ((horas * 3600) + (minutos * 60) + segundos));
    }
}
