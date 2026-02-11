// See https://aka.ms/new-console-template for more information
using System; // Correct usage of the System namespace
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program 
{
    static void Main(string[] args) 
    {
        //Ejercicio 1 : Registro de Nave Espacial

        // Saludo inicial
        Console.WriteLine("Hello, World!");

        // Entrada de usuario
        Console.WriteLine("¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        // Salida de datos
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        string modelo;
        int carga;
        double combustible;
        bool motorDeSaltoActivo;

        // Entrada de datos adicionales
        Console.Write("Modelo de la nave: ");
        modelo = Console.ReadLine();

        Console.Write("Capacidad de carga: ");
        carga = int.Parse(Console.ReadLine());

        Console.Write("Nivel de combustible: ");
        combustible = double.Parse(Console.ReadLine());

        Console.Write("¿Motor de salto activo? (true/false): ");
        motorDeSaltoActivo = bool.Parse(Console.ReadLine());

        // Mostrar datos ingresados
        Console.WriteLine($"Modelo de la nave: {modelo}, Capacidad de carga: {carga}, Nivel de combustible: {combustible}, Motor de salto activo: {motorDeSaltoActivo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 2: Expansión de Memoria (Conversión Implícita)

        // Declaración de variables
        
    }
}