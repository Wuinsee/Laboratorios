// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== LABORATORIO 7 =====");
            Console.WriteLine("1. Suma controlada por contador");
            Console.WriteLine("2. Conversión de unidades");
            Console.WriteLine("3. Juego: Adivina el número");
            Console.WriteLine("4. PIN de acceso");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    SumaContador();
                    break;

                case 2:
                    ConversionUnidades();
                    break;

                case 3:
                    AdivinarNumero();
                    break;

                case 4:
                    PinAcceso();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }

    // EJERCICIO 1
    static void SumaContador()
    {
        Console.WriteLine("\n--- SUMA CONTROLADA ---");

        Console.Write("¿Cuántos números desea sumar?: ");
        int N = int.Parse(Console.ReadLine());

        // Validación
        while (N <= 0)
        {
            Console.Write("Número inválido. Ingrese uno mayor que 0: ");
            N = int.Parse(Console.ReadLine());
        }

        int contador = 0;
        double suma = 0;

        while (contador < N)
        {
            Console.Write("Ingrese número " + (contador + 1) + ": ");
            double numero = double.Parse(Console.ReadLine());

            suma += numero;
            contador++;
        }

        double promedio = suma / N;

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }

    // EJERCICIO 2
    static void ConversionUnidades()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ DE CONVERSIONES ---");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + f.ToString("F2") + " °F");
                    break;

                case 2:
                    Console.Write("Ingrese Fahrenheit: ");
                    double fa = double.Parse(Console.ReadLine());
                    double ce = (fa - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + ce.ToString("F2") + " °C");
                    break;

                case 3:
                    Console.Write("Ingrese kilómetros: ");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine("Resultado: " + millas.ToString("F2") + " millas");
                    break;

                case 4:
                    Console.WriteLine("Regresando al menú principal...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }

    // EJERCICIO 3
    static void AdivinarNumero()
    {
        Console.WriteLine("\n--- ADIVINA EL NÚMERO ---");

        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 101);
        int intento = 0;
        int numero;

        do
        {
            Console.Write("Ingrese un número entre 1 y 100: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 100)
            {
                Console.WriteLine("Número fuera de rango.");
                continue;
            }

            intento++;

            if (numero < numeroSecreto)
                Console.WriteLine("Más alto");
            else if (numero > numeroSecreto)
                Console.WriteLine("Más bajo");

        } while (numero != numeroSecreto);

        Console.WriteLine("¡Correcto!");
        Console.WriteLine("Intentos: " + intento);
    }

    // EJERCICIO 4
    static void PinAcceso()
    {
        Console.WriteLine("\n--- ACCESO POR PIN ---");

        int pinCorrecto = 1234;
        int intentos = 0;
        int pin;

        do
        {
            Console.Write("Ingrese el PIN: ");
            pin = int.Parse(Console.ReadLine());

            if (pin == pinCorrecto)
            {
                Console.WriteLine("Acceso concedido");
                return;
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            intentos++;

        } while (intentos < 3);

        Console.WriteLine("Cuenta bloqueada");
    }
}
