using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear y llenar la pila
        Stack<int> pila = CrearPila();

        // Mostrar la pila antes de vaciarla
        MostrarPila(pila);
        Console.WriteLine($"Tamaño de la pila antes de vaciarla: {pila.Count}");

        // Vaciar la pila utilizando Pop()
        VaciarPila(pila);

        // Mostrar tamaño de la pila después de vaciarla
        Console.WriteLine($"Tamaño de la pila después de vaciarla: {pila.Count}");

        // Pausar la ejecución para que el usuario vea los resultados
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

  
    static Stack<int> CrearPila()
    {
        Stack<int> pila = new Stack<int>();
        int[] valores = { 10, 20, 30, 40, 50 };

        foreach (int valor in valores)
        {
            pila.Push(valor);
        }

        return pila;
    }

    static void MostrarPila(Stack<int> pila)
    {
        Console.Write("Elementos en la pila: ");
        foreach (int item in pila)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
    }


    static void VaciarPila(Stack<int> pila)
    {
        while (pila.Count > 0)
        {
            pila.Pop(); // Remueve el elemento en la cima de la pila
        }
    }
}

