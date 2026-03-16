// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada de usuario
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();

        // Salida de datos
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        Console.WriteLine("\n===== EJERCICIO 1 =====");

        int aprobados = 0;
        int reprobados = 0;
        double sumaNotas = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            double nota = Convert.ToDouble(Console.ReadLine());

            sumaNotas += nota;

            if (nota >= 61)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = sumaNotas / 10;

        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Cantidad de aprobados: " + aprobados);
        Console.WriteLine("Cantidad de reprobados: " + reprobados);


        Console.WriteLine("\n===== EJERCICIO 2 =====");

        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int suma = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= numero; i++)
        {
            suma += i;

            if (i % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine("La suma desde 1 hasta " + numero + " es: " + suma);
        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);


        Console.WriteLine("\n===== EJERCICIO 3 =====");

        int opcion;
        double totalVentas = 0;
        int clientes = 0;

        do
        {
            Console.WriteLine("\nMENÚ");
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4) Salir");

            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: ");
                    double compra = Convert.ToDouble(Console.ReadLine());
                    totalVentas += compra;
                    clientes++;
                    break;

                case 2:
                    Console.WriteLine("Total de ventas del día: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Cantidad de clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);


        Console.WriteLine("\n===== EJERCICIO 4 =====");

        int contador = 0;
        int positivos = 0;
        int negativos = 0;
        int sumaTotal = 0;
        int num;

        do
        {
            Console.Write("Ingrese un número (0 para terminar): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
            {
                contador++;
                sumaTotal += num;

                if (num > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }

        } while (num != 0);

        Console.WriteLine("Total de números ingresados: " + contador);
        Console.WriteLine("Cantidad de positivos: " + positivos);
        Console.WriteLine("Cantidad de negativos: " + negativos);
        Console.WriteLine("Suma total: " + sumaTotal);


        Console.WriteLine("\n===== EJERCICIO 5 =====");

        Console.Write("Ingrese un número N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

    }
}
