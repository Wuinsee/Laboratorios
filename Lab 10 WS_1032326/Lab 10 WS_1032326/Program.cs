// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada básica
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        // =========================
        // EJERCICIO 1
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");
        Console.Write("Ingrese un número entero positivo: ");
        int num = int.Parse(Console.ReadLine());
        int suma = SumarDigitos(num);
        Console.WriteLine("Suma de dígitos: " + suma + "\n");

        // =========================
        // EJERCICIO 2
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Antes: N = " + n);
        string mensaje = ElevarCuadrado(ref n);
        Console.WriteLine("Después: N = " + n);
        Console.WriteLine(mensaje + "\n");

        // =========================
        // EJERCICIO 3
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");
        Console.Write("Ingrese precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("Ingrese porcentaje de descuento (ej. 0.25): ");
        double descuento = double.Parse(Console.ReadLine());

        double montoDescuento = AplicarDescuento(descuento, ref precio);
        Console.WriteLine("Precio final: " + precio);
        Console.WriteLine("Descuento aplicado: " + montoDescuento + "\n");

        // =========================
        // EJERCICIO 4
        // =========================
        Console.WriteLine("=== EJERCICIO 4 ===");
        int energiaJugador = 10;

        Console.WriteLine("Energía inicial: " + energiaJugador);

        energiaJugador = ConsumirEnergia(ref energiaJugador);
        Console.WriteLine("Después de consumir: " + energiaJugador);

        energiaJugador = RecargarEnergia(ref energiaJugador);
        Console.WriteLine("Después de recargar: " + energiaJugador);

        string estado = ObtenerEstado(energiaJugador);
        Console.WriteLine("Estado: " + estado);

        string rendimiento = CalcularRendimiento(energiaJugador);
        Console.WriteLine("Rendimiento: " + rendimiento);
    }

    // =========================
    // EJERCICIO 1
    // =========================
    static int SumarDigitos(int numero)
    {
        int suma = 0;
        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static string ElevarCuadrado(ref int numero)
    {
        numero = numero * numero;
        return "El número fue elevado al cuadrado correctamente.";
    }

    // =========================
    // EJERCICIO 3
    // =========================
    static double AplicarDescuento(double porcentaje, ref double precio)
    {
        double descuento = precio * porcentaje;
        precio -= descuento;
        return descuento;
    }

    // =========================
    // EJERCICIO 4.1
    // =========================
    static int ConsumirEnergia(ref int energia)
    {
        energia -= 4;
        if (energia < 0)
            energia = 0;
        return energia;
    }

    // =========================
    // EJERCICIO 4.2
    // =========================
    static int RecargarEnergia(ref int energia)
    {
        energia += 6;
        if (energia > 20)
            energia = 20;
        return energia;
    }

    // =========================
    // EJERCICIO 4.3
    // =========================
    static string ObtenerEstado(int energia)
    {
        if (energia >= 15 && energia <= 20)
            return "Alta";
        else if (energia >= 8)
            return "Media";
        else
            return "Baja";
    }

    // =========================
    // EJERCICIO 4.4
    // =========================
    static string CalcularRendimiento(int energia)
    {
        if (energia == 20)
            return "S";
        else if (energia >= 15)
            return "A";
        else if (energia >= 8)
            return "B";
        else
            return "C";
    }
}