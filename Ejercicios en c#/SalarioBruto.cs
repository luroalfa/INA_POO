//Los empleados de una tienda reciben un salario base mensual, más un 10% por comisión sobre las ventas realizadas mensualmente.
//Realice un programa en C# que calcule el salario bruto del empleado.
using System;
class SalarioBruto
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el salario base mensual: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el monto de ventas mensuales: ");
        double ventasMensuales = double.Parse(Console.ReadLine());

        double salarioBruto = salarioBase + (ventasMensuales * 0.10);

        Console.WriteLine("El salario bruto del empleado es: " + salarioBruto);
    }
}
