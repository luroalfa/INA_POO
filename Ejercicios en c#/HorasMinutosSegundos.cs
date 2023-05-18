//Realice un programa en C# que solicite al usuario una cantidad de segundos,
//el programa debe mostrar en pantalla cuantas horas, cuantos minutos y cuantos segundos existen.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        Console.WriteLine("Horas: " + (segundos / 3600));
        segundos %= 3600;
        Console.WriteLine("Minutos: " + (segundos / 60));
        segundos %= 60;
        Console.WriteLine("Segundos: " + segundos);
    }
}
