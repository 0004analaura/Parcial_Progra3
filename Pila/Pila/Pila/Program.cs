using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una cola y agregar elementos
        Queue<int> cola = new Queue<int>();
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);
        cola.Enqueue(40);
        cola.Enqueue(50);

        // Mostrar tamaño de la cola antes de vaciarla
        Console.WriteLine("Tamaño de la cola antes de vaciarla: " + cola.Count);

        // Vaciar la cola utilizando Dequeue()
        VaciarCola(cola);

        // Mostrar tamaño de la cola después de vaciarla
        Console.WriteLine("Tamaño de la cola después de vaciarla: " + cola.Count);
    }


    static void VaciarCola(Queue<int> cola)
    {
        while (cola.Count > 0)
        {
            cola.Dequeue(); // Remueve el primer elemento de la cola
        }
    }
}

