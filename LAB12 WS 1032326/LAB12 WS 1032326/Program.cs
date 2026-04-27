// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LABORATORIO 12 =====");

        // ================= EJERCICIO 1 =================
        Console.WriteLine("\n--- EJERCICIO 1 ---");
        int[,] matriz1 = new int[4, 4];
        LlenarMatriz4x4(matriz1);

        Console.Write("Ingrese fila a sumar (0-3): ");
        int fila = int.Parse(Console.ReadLine());
        Console.WriteLine("Suma de fila: " + SumaFila(matriz1, fila));

        Console.Write("Ingrese columna a sumar (0-3): ");
        int col = int.Parse(Console.ReadLine());
        Console.WriteLine("Suma de columna: " + SumaColumna(matriz1, col));

        // ================= EJERCICIO 2 =================
        Console.WriteLine("\n--- EJERCICIO 2 ---");
        float[,] matriz2 = new float[3, 5];
        CargarMatriz3x5(matriz2);
        Console.WriteLine("Mayor valor: " + MayorMatriz(matriz2));

        // ================= EJERCICIO 3 =================
        Console.WriteLine("\n--- EJERCICIO 3 ---");
        int[,] A = new int[3, 2];
        int[,] B = new int[3, 2];
        int[,] R = new int[3, 2];

        LlenarMatriz3x2(A, "A");
        LlenarMatriz3x2(B, "B");

        Multiplicar(A, B, R);
        Console.WriteLine("Matriz resultante:");
        MostrarMatriz(R);

        // ================= EJERCICIO 4 =================
        Console.WriteLine("\n--- EJERCICIO 4 ---");
        int[,] matriz4 = new int[5, 5];
        LlenarMatriz5x5(matriz4);

        Console.WriteLine("Suma diagonal principal: " + SumaDiagonalPrincipal(matriz4));
        Console.WriteLine("Suma diagonal secundaria: " + SumaDiagonalSecundaria(matriz4));
    }

    // ================= EJERCICIO 1 =================
    static void LlenarMatriz4x4(int[,] m)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaFila(int[,] m, int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[fila, j];
        return suma;
    }

    static int SumaColumna(int[,] m, int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
            suma += m[i, col];
        return suma;
    }

    // ================= EJERCICIO 2 =================
    static void CargarMatriz3x5(float[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
    }

    static float MayorMatriz(float[,] m)
    {
        float mayor = m[0, 0];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                if (m[i, j] > mayor)
                    mayor = m[i, j];
        return mayor;
    }

    // ================= EJERCICIO 3 =================
    static void LlenarMatriz3x2(int[,] m, string nombre)
    {
        Console.WriteLine($"Llenando matriz {nombre}:");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void Multiplicar(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = 0;
                for (int k = 0; k < 2; k++)
                    R[i, j] += A[i, k] * B[k, j];
            }
    }

    static void MostrarMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }
    }

    // ================= EJERCICIO 4 =================
    static void LlenarMatriz5x5(int[,] m)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }
}