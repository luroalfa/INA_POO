
//Dados 12 salarios de un trabajador, determine cuál es el monto de aguinaldo que le corresponde.

using System;
class Aguinaldo
{
    static void Main(string[] args)
    {
        double[] salarios = new double[12];
        double sumaSalarios = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.Write("Ingrese el salario " + (i + 1) + ": ");
            salarios[i] = double.Parse(Console.ReadLine());
        }
        
        foreach (double salario in salarios)
        {
            sumaSalarios += salario;
        }
        
        Console.WriteLine("El aguinaldo es de: " + (sumaSalarios / 12));
    }
}
