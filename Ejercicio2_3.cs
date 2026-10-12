using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        Queue<string> fclientes = new Queue<string>();
        bool abierto = true;

        Console.WriteLine("=== SIMULACION DE ATENCION AL CLIENTE ===");

        while (abierto)
        {
            Console.WriteLine("\n--- Menu de Opciones ---");
            Console.WriteLine("1. Añadir cliente");
            Console.WriteLine("2. Atender siguiente cliente");
            Console.WriteLine("3. Ver cuantos clientes esperan");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    Console.Write("Ingresa el nombre del cliente: ");
                    string nvliente = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nvliente))
                    {
                        fclientes.Enqueue(nvliente);
                        Console.WriteLine($"Cliente '{nvliente}' añadido a la fila.");
                    }
                    else
                    {
                        Console.WriteLine("El nombre no puede estar vacío.");
                    }
                    break;

                case "2":

                    if (fclientes.Count > 0)
                    {
                        string clienteat = fclientes.Dequeue();
                        Console.WriteLine($"---> Atendiendo a: {clienteat}");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la fila.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Clientes en espera: {fclientes.Count}");
                    break;

                case "4":
                    abierto = false;
                    Console.WriteLine("Cerrando el sistema de atención...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }
}
