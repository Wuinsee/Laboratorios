// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class NaveEspacial
{
    static void Main()
    {
        // Parte 1: Datos básicos
        string nombreNave = "GalaxyX";
        int cargaMaxima = 5000;
        double combustibleActual = 75.5;
        bool escudoActivo = false;

        Console.WriteLine("Nave: " + nombreNave);
        Console.WriteLine("Carga máxima permitida: " + cargaMaxima);
        Console.WriteLine("Combustible disponible: " + combustibleActual + "%");
        Console.WriteLine("¿Escudo activado? " + escudoActivo);

        // Parte 2: Conversión automática
        byte modulos = 10;
        int totalModulos = modulos;
        double calculoFinal = totalModulos;

        Console.WriteLine("Total de módulos instalados: " + calculoFinal);

        // Parte 3: Conversión explícita
        double energiaTotal = 456.89;
        int energiaEntera = (int)energiaTotal;

        Console.WriteLine("Energía total: " + energiaTotal);
        Console.WriteLine("Energía aproximada: " + energiaEntera);

        // Parte 4: Entrada segura de velocidad
        Console.Write("Ingrese la velocidad actual: ");
        string entradaVelocidad = Console.ReadLine();

        if (int.TryParse(entradaVelocidad, out int velocidad))
        {
            velocidad += 20;
            Console.WriteLine("Velocidad ajustada: " + velocidad);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se asigna velocidad 0.");
            velocidad = 0;
        }

        // Parte 5: Conversión segura desde texto
        string estadoMotor = "false";
        bool motorEncendido;

        if (!bool.TryParse(estadoMotor, out motorEncendido))
        {
            motorEncendido = false;
        }

        string alturaTexto = "1200.75";
        double altura;

        if (!double.TryParse(alturaTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out altura))
        {
            altura = 0;
        }

        Console.WriteLine("Motor encendido: " + motorEncendido);
        Console.WriteLine("Altura actual: " + altura);

        // Parte 6: Formato de números
        double distancia = 123456.789;
        Console.WriteLine("Distancia normal: " + distancia);
        Console.WriteLine("Distancia con formato: " + distancia.ToString("N2"));

        // Parte 7: Precio con validación
        Console.Write("Ingrese el precio del combustible: ");
        string entradaPrecio = Console.ReadLine();

        if (double.TryParse(entradaPrecio, NumberStyles.Any, CultureInfo.InvariantCulture, out double precioCombustible))
        {
            double impuesto = precioCombustible * 0.15;
            double totalPagar = precioCombustible + impuesto;

            Console.WriteLine("Impuesto (15%): " + impuesto.ToString("F2"));
            Console.WriteLine("Total a pagar: " + totalPagar.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Precio inválido. No se pudo calcular.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
