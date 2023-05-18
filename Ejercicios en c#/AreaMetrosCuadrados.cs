//Realice un programa en C# para determinar el área en metros cuadrados de un terreno rectangular cuyo frente y fondo se dan en pies.
//Solicite los datos de frente y fondo, el sistema debe mostrar el área en m2.

using System;

class AreaMetrosCuadrados
{
    static void Main(string[] args)
    {
        double p2m = 0.092903; //Pies cuadrados a metros

        Console.Write("Ingrese el frente del terreno en pies: ");
        double frenteP = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el fondo del terreno en pies: ");
        double fondoP = double.Parse(Console.ReadLine());

        double result = frenteP * fondoP * p2m;

        Console.WriteLine("El área del terreno es de: " + result + " metros cuadrados");
    }
}
