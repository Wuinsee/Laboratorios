// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Laboratorio 9 - Procedimientos\n");

        // Ejercicio 1
        Ejercicio1();

        // Ejercicio 2
        Ejercicio2();

        // Ejercicio 3
        Ejercicio3();

        // Ejercicio 4
        Ejercicio4();

        // Ejercicio 5
        Ejercicio5();
    }

    // =========================
    // EJERCICIO 1
    // =========================
    static void Ejercicio1()
    {
        Console.WriteLine("\n--- Ejercicio 1 ---");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Saludar(nombre);
        MostrarCurso();
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre + ", bienvenido!");
    }

    static void MostrarCurso()
    {
        Console.WriteLine("Curso: Programación - Laboratorio 9");
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static void Ejercicio2()
    {
        Console.WriteLine("\n--- Ejercicio 2 ---");

        Console.Write("Lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("Base del rectángulo: ");
        double baseR = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura del rectángulo: ");
        double alturaR = Convert.ToDouble(Console.ReadLine());
        AreaRectangulo(baseR, alturaR);

        Console.Write("Base del triángulo: ");
        double baseT = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura del triángulo: ");
        double alturaT = Convert.ToDouble(Console.ReadLine());
        AreaTriangulo(baseT, alturaT);
    }

    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine("Área del cuadrado: " + area);
    }

    static void AreaRectangulo(double b, double h)
    {
        double area = b * h;
        Console.WriteLine("Área del rectángulo: " + area);
    }

    static void AreaTriangulo(double b, double h)
    {
        double area = (b * h) / 2;
        Console.WriteLine("Área del triángulo: " + area);
    }

    // =========================
    // EJERCICIO 3
    // =========================
    static void Ejercicio3()
    {
        Console.WriteLine("\n--- Ejercicio 3 ---");

        int opcion;
        do
        {
            Console.WriteLine("\n1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 4)
            {
                Console.Write("Ingrese N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        DibujarCuadrado(n);
                        break;
                    case 2:
                        DibujarTriangulo(n);
                        break;
                    case 3:
                        DibujarLinea(n);
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }

        } while (opcion != 4);
    }

    static void DibujarCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    static void DibujarLinea(int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write("*");
        Console.WriteLine();
    }

    // =========================
    // EJERCICIO 4
    // =========================
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Ejercicio 4 ---");

        int aprobados = 0, reprobados = 0;
        double suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Nota " + i + ": ");
            double nota = Convert.ToDouble(Console.ReadLine());

            EvaluarNota(nota, ref aprobados, ref reprobados);
            suma += nota;
        }

        MostrarResumen(suma, aprobados, reprobados);
    }

    static void EvaluarNota(double nota, ref int aprobados, ref int reprobados)
    {
        if (nota >= 61)
        {
            Console.WriteLine("Aprobado");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Reprobado");
            reprobados++;
        }
    }

    static void MostrarResumen(double suma, int aprobados, int reprobados)
    {
        double promedio = suma / 5;
        Console.WriteLine("\nPromedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }

    // =========================
    // EJERCICIO 5
    // =========================
    static void Ejercicio5()
    {
        Console.WriteLine("\n--- Ejercicio 5 ---");

        Console.Write("Ingrese número 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese número 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Antes: " + a + ", " + b);

        Intercambiar(ref a, ref b);

        Console.WriteLine("Después: " + a + ", " + b);
    }

    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
