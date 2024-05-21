using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        }
    }
}