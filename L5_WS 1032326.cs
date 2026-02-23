// See https://aka.ms/new-console-template for more information

// PROGRAMA COMPLETO - EJERCICIOS 1, 2, 3 Y 4

using System;

class Program
{
    static void Main()
    {

        // =========================
        // EJERCICIO 1
        // =========================

        Console.WriteLine("=========== EJERCICIO 1 ===========");
        Console.WriteLine();

        int usuarioIngresado, pinIngresado, tokenIngresado;

        Console.Write("Ingrese su usuario: ");
        usuarioIngresado = int.Parse(Console.ReadLine());

        if (usuarioIngresado == 2026)
        {
            Console.WriteLine("Usuario reconocido");
        }
        else
        {
            Console.WriteLine("Usuario no reconocido");
        }

        Console.WriteLine();

        Console.Write("Ingrese su PIN: ");
        pinIngresado = int.Parse(Console.ReadLine());

        if (pinIngresado == 1234)
        {
            Console.WriteLine("PIN correcto");
        }
        else
        {
            Console.WriteLine("PIN incorrecto");
        }

        Console.WriteLine();

        Console.Write("Ingrese el token de seguridad: ");
        tokenIngresado = int.Parse(Console.ReadLine());

        if (tokenIngresado == 777)
        {
            Console.WriteLine("Token valido");
        }
        else
        {
            Console.WriteLine("Token invalido");
        }


        // =========================
        // EJERCICIO 2
        // =========================

        Console.WriteLine();
        Console.WriteLine("=========== EJERCICIO 2 ===========");
        Console.WriteLine();

        int pinVerificacion;

        Console.Write("Ingrese su PIN: ");
        pinVerificacion = int.Parse(Console.ReadLine());

        if (pinVerificacion > 999 && pinVerificacion <= 9999)
        {
            Console.WriteLine("Su PIN es de 4 digitos: OK");
        }
        else
        {
            Console.WriteLine("PIN invalido: debe tener 4 digitos");
        }

        if (pinVerificacion % 2 == 0)
        {
            Console.WriteLine("Su PIN es par");
        }
        else
        {
            Console.WriteLine("Su PIN es impar");
        }

        if (pinVerificacion % 5 == 0)
        {
            Console.WriteLine("Su PIN es multiplo de 5");
        }
        else
        {
            Console.WriteLine("Su PIN NO es multiplo de 5");
        }


        // =========================
        // EJERCICIO 3
        // =========================

        Console.WriteLine();
        Console.WriteLine("=========== EJERCICIO 3 ===========");
        Console.WriteLine();

        int codigoVerificacion, edadUsuario, aceptaTerminos;

        Console.Write("Ingrese su codigo de verificacion: ");
        codigoVerificacion = int.Parse(Console.ReadLine());

        if (codigoVerificacion == 2026)
        {
            Console.WriteLine("Codigo correcto");
        }
        else
        {
            Console.WriteLine("Codigo incorrecto");
        }

        Console.WriteLine();

        Console.Write("Ingrese su edad: ");
        edadUsuario = int.Parse(Console.ReadLine());

        if (edadUsuario >= 18)
        {
            Console.WriteLine("Edad valida");
        }
        else
        {
            Console.WriteLine("Edad invalida");
        }

        Console.WriteLine();

        Console.Write("Acepta los terminos (1 = si / 0 = no): ");
        aceptaTerminos = int.Parse(Console.ReadLine());

        if (aceptaTerminos == 1)
        {
            Console.WriteLine("Terminos aceptados");
        }
        else
        {
            Console.WriteLine("Debe aceptar los terminos");
        }


        // =========================
        // EJERCICIO 4
        // =========================

        Console.WriteLine();
        Console.WriteLine("=========== EJERCICIO 4 ===========");
        Console.WriteLine();

        int notaEstudiante, minutosRetraso, estadoSolvencia, tieneIdentificacion, tieneCalculadora;

        Console.Write("Ingrese la nota previa: ");
        notaEstudiante = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los minutos de llegada tarde: ");
        minutosRetraso = int.Parse(Console.ReadLine());

        Console.Write("Tiene solvencia de pagos (1 = si / 0 = no): ");
        estadoSolvencia = int.Parse(Console.ReadLine());

        Console.Write("Tiene identificacion fisica (1 = si / 0 = no): ");
        tieneIdentificacion = int.Parse(Console.ReadLine());

        Console.Write("Tiene una calculadora permitida (1 = si / 0 = no): ");
        tieneCalculadora = int.Parse(Console.ReadLine());


        if (notaEstudiante >= 61)
        {
            Console.WriteLine("REQUISITO ACADEMICO APROBADO");
        }
        else
        {
            Console.WriteLine("REQUISITO ACADEMICO NO APROBADO");
        }

        if (minutosRetraso <= 10 && minutosRetraso > 0)
        {
            Console.WriteLine("Advertencia: Llego tarde pero puede ingresar");
        }
        else if (minutosRetraso > 10)
        {
            Console.WriteLine("LLEGADA TARDE: fuera de tiempo");
        }
        else
        {
            Console.WriteLine("Hora valida");
        }

        if (estadoSolvencia == 1)
            Console.WriteLine("Solvencia validada");
        else
            Console.WriteLine("Sin solvencia");

        if (tieneIdentificacion == 1)
            Console.WriteLine("Identificacion validada");
        else
            Console.WriteLine("Sin identificacion");

        if (tieneCalculadora == 1)
            Console.WriteLine("Calculadora aceptada");
        else
            Console.WriteLine("Calculadora no permitida");

        if (notaEstudiante >= 61 && minutosRetraso <= 10 && estadoSolvencia == 1 && tieneIdentificacion == 1 && tieneCalculadora == 1)
        {
            Console.WriteLine("ACCESO A LA SALA DE EXAMEN CONCEDIDO");
        }
        else
        {
            Console.WriteLine("ACCESO DENEGADO");
        }

    }
}