using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Queue<string> colaFrases = new Queue<string>();

        Console.WriteLine("=== EJERCICIO 2: GESTION DE FRASES ===");
        Console.WriteLine("Escribe frases. Presiona Enter vacio para terminar el programa.\n");

        while (true)
        {
            Console.Write("Ingresa una frase: ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
            {
                break;
            }

            colaFrases.Enqueue(entrada);
        }

        Console.WriteLine("\n--- Frases almacenadas ---");

        foreach (string frase in colaFrases)
        {
            Console.WriteLine($"- {frase}");
        }

        Console.WriteLine($"\nTotal de frases registradas: {colaFrases.Count}");
    }
}
