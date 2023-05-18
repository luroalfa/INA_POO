//Se tiene un terreno rectangular cuyas dimensiones de largo y ancho están en relación 2 a 1.
//Solicite el ancho del terreno al usuario.
//Para cercar con malla este terreno se colocan postes a lo largo del perímetro a una distancia de 2 m uno del otro.
//¿Cuántos postes son necesarios para cercar el terreno? 

using System;

class Postes
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el ancho del terreno: ");
        double anchoTerreno = double.Parse(Console.ReadLine());

        double perimetroTerreno = 2 * ((2 * anchoTerreno) + anchoTerreno);
        Console.WriteLine("La cantidad de postes es de: " + (int)(perimetroTerreno / 2));
    }
}
