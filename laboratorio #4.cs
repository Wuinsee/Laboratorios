// See https://aka.ms/new-console-template for more information
using System; // Correct usage of the System namespace
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;

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

        // Parte 4: Entrada de usuario
        Console.Write("Ingrese la velocidad actual: ");
        string entradaVelocidad = Console.ReadLine();

        int velocidad = int.Parse(entradaVelocidad);
        velocidad += 20;

        Console.WriteLine("Velocidad ajustada: " + velocidad);

        // Parte 5: Conversión desde texto
        string estadoMotor = "false";
        bool motorEncendido = Convert.ToBoolean(estadoMotor);

        string alturaTexto = "1200.75";
        double altura = Convert.ToDouble(alturaTexto);

        Console.WriteLine("Motor encendido: " + motorEncendido);
        Console.WriteLine("Altura actual: " + altura);

        // Parte 6: Formato de números
        double distancia = 123456.789;
        Console.WriteLine("Distancia normal: " + distancia.ToString());
        Console.WriteLine("Distancia con formato: " + distancia.ToString("N2"));

        // Parte 7: Cálculo con impuesto
        Console.Write("Ingrese el precio del combustible: ");
        double precioCombustible = Convert.ToDouble(Console.ReadLine());

        double impuesto = precioCombustible * 0.15;
        double totalPagar = precioCombustible + impuesto;

        Console.WriteLine("Total a pagar: " + totalPagar);
    }
}