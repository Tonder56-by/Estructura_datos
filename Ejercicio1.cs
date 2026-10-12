using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
       
        Queue<int> nentrada = new Queue<int>();

        Console.WriteLine("=== EJERCICIO 1: ALMACENADOR DE NUMEROS ===");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingresa el numero {i}: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                nentrada.Enqueue(n);
            }
            else
            {
                Console.WriteLine("Entrada no valida, se guardara 0 por defecto.");
                nentrada.Enqueue(0);
            }
        }

        Console.WriteLine("\n--- Elementos en orden ---");

        while (nentrada.Count > 0)
        {
            int npros = nentrada.Dequeue();
            Console.WriteLine($"Numero ya ordenado: {npros}");
        }

        Console.WriteLine("\nTodos los nUmeros han sido procesados.");
    }
}
