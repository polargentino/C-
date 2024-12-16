// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Generar un número aleatorio entre 1 y 100
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Genera un número entre 1 y 100
        int intentos = 0;
        bool adivinado = false;

        Console.WriteLine("¡Bienvenido al juego de Adivina el Número!");
        Console.WriteLine("He pensado un número entre 1 y 100. ¿Puedes adivinar cuál es?");

        // Ciclo del juego
        while (!adivinado)
        {
            Console.Write("Introduce tu respuesta: ");
            string entrada = Console.ReadLine();
            int numeroUsuario;

            // Verificar si la entrada es válida
            if (int.TryParse(entrada, out numeroUsuario))
            {
                intentos++; // Incrementar intentos

                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor. ¡Intenta otra vez!");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es menor. ¡Intenta otra vez!");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                    adivinado = true; // Salir del bucle
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }
}


