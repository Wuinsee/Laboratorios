// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Programa hecho por: Wuin See Salguero");

        string nombre;
        string curso;

        Console.WriteLine();

        Console.Write("Escriba su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Escriba su curso: ");
        curso = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Bienvenido " + nombre + " del curso: " + curso);

        Console.WriteLine();
        Console.Write("Presione una tecla para salir");
        Console.ReadKey();
    }
}



