using System;

class Program
{
    static void Main()
    {
        // Arreglo de enteros ordenado
        int[] numeros = { 3, 8, 12, 17, 23, 34, 45, 56, 67, 78 };

        // Mostrar el arreglo
        Console.WriteLine("Arreglo ordenado: " + string.Join(", ", numeros));

        // Pedir al usuario el número a buscar
        Console.Write("Ingrese el número a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int objetivo))
        {
            // Realizar la búsqueda binaria
            int posicion = BusquedaBinaria(numeros, objetivo);

            // Mostrar resultado
            if (posicion != -1)
            {
                Console.WriteLine($"El número {objetivo} se encuentra en la posición {posicion} del arreglo.");
            }
            else
            {
                Console.WriteLine($"El número {objetivo} no se encuentra en el arreglo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero.");
        }
    }


    static int BusquedaBinaria(int[] arr, int objetivo)
    {
        int izquierda = 0;
        int derecha = arr.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = izquierda + (derecha - izquierda) / 2;

            if (arr[medio] == objetivo)
                return medio; // Se encontró el número en la posición 'medio'

            if (arr[medio] < objetivo)
                izquierda = medio + 1; // Buscar en la mitad derecha
            else
                derecha = medio - 1; // Buscar en la mitad izquierda
        }

        return -1; // El número no está en el arreglo
    }
}