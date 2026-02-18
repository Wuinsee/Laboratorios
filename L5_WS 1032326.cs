// See https://aka.ms/new-console-template for more information

partial class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1

        Console.WriteLine("Ingrese su ID de usuario:");
        int id = Convert.ToInt32(Console.ReadLine());
        if (id == 2026)
        {
            Console.WriteLine("ID correcto");
        }
        else
        {
            Console.WriteLine("ID incorrecto");
        }
        Console.WriteLine();
        Console.WriteLine("Ingrese su PIN:");
        int pin = Convert.ToInt32(Console.ReadLine());
        if (pin == 1234)
        {
            Console.WriteLine("PIN correcto");
        }
        else
        {
            Console.WriteLine("PIN incorrecto");
        }
        Console.WriteLine();
        Console.WriteLine("Ingrese su Token de seguridad:");
        int token = Convert.ToInt32(Console.ReadLine());
        if (token == 777)
        {
            Console.WriteLine("Token valido");
        }
        else
        {
            Console.WriteLine("Token invalido");
        }
        Console.WriteLine();
        Console.WriteLine("¿Modo seguro activado? (1 = Sí, 0 = No):");
        bool modoSeguro = Console.ReadLine() == "1";
        if ( modoSeguro)
        {
            Console.WriteLine("Modo seguro activado");
        }
        else
        { 
            Console.WriteLine("Modo seguro desactivado"); 
        }
        Console.WriteLine();
        if (id == 2026 && pin == 1234 && token == 777 && modoSeguro)
            {
            Console.WriteLine("Acceso total concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
        Console.WriteLine();
        if (modoSeguro && token >= 700)
        {
            Console.WriteLine("Regla extra aprobada");
        }
        else
        {
            Console.WriteLine("Regla extra fallida");
        }

        //EJERCICIO 2

    }






}