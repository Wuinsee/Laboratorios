// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== LABORATORIO 11 =====");
            Console.WriteLine("1. Validar contraseña");
            Console.WriteLine("2. Invertir texto");
            Console.WriteLine("3. Suma, promedio, mayor y menor");
            Console.WriteLine("4. Buscar número en arreglo");
            Console.WriteLine("5. Nombres en arreglo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ValidarContrasena();
                    break;
                case 2:
                    InvertirTexto();
                    break;
                case 3:
                    ArregloNumeros();
                    break;
                case 4:
                    BuscarNumero();
                    break;
                case 5:
                    NombresArreglo();
                    break;
            }

        } while (opcion != 0);
    }

    // EJERCICIO 1
    static void ValidarContrasena()
    {
        Console.Write("Ingrese contraseña: ");
        string pass = Console.ReadLine();

        bool tieneMayus = false, tieneNumero = false, tieneEspecial = false;
        string especiales = "@#$%";

        foreach (char c in pass)
        {
            if (char.IsUpper(c)) tieneMayus = true;
            if (char.IsDigit(c)) tieneNumero = true;
            if (especiales.Contains(c)) tieneEspecial = true;
        }

        if (pass.Length >= 8 && tieneMayus && tieneNumero && tieneEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: ");
            if (pass.Length < 8) Console.Write("falta longitud, ");
            if (!tieneMayus) Console.Write("falta mayúscula, ");
            if (!tieneNumero) Console.Write("falta número, ");
            if (!tieneEspecial) Console.Write("falta carácter especial, ");
            Console.WriteLine();
        }
    }

    // EJERCICIO 2
    static void InvertirTexto()
    {
        Console.Write("Ingrese texto: ");
        string texto = Console.ReadLine();
        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Invertido: " + invertido);
    }

    // EJERCICIO 3
    static void ArregloNumeros()
    {
        Console.Write("¿Cuántos números desea ingresar?: ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int num in numeros)
        {
            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
        }

        double promedio = (double)suma / n;

        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);
    }

    // EJERCICIO 4
    static void BuscarNumero()
    {
        int[] arr = new int[8];

        Console.WriteLine("Ingrese 8 números:");
        for (int i = 0; i < 8; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == buscar)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine("El número sí existe en la posición " + posicion);
        else
            Console.WriteLine("El número no existe en el arreglo");
    }

    // EJERCICIO 5
    static void NombresArreglo()
    {
        string[] nombres = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
        }

        int contador = 0;
        string masLargo = nombres[0];

        foreach (string nombre in nombres)
        {
            if (nombre.Length > 5) contador++;
            if (nombre.Length > masLargo.Length) masLargo = nombre;
        }

        Console.WriteLine("Nombres ingresados:");
        foreach (string nombre in nombres)
        {
            Console.Write(nombre + " ");
        }

        Console.WriteLine("\nMás de 5 letras: " + contador);
        Console.WriteLine("Nombre más largo: " + masLargo);
    }
}