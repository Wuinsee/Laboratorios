// See https://aka.ms/new-console-template for more information
using System;

namespace L15_WS_1032326
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== LABORATORIO 15 =====");

            // ---------------- EJERCICIO 1 ----------------
            Console.WriteLine("\n--- Ejercicio 1: Errores de Sintaxis ---");

            // Error encontrado:
            // Tipo de error: sintaxis
            // Corrección realizada: Se agregó ';' faltante y using correcto.
            // Explicación: Sin estos elementos el programa no compila.

            string nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");

            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número:");
            }

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tienes " + edad + " años");

            // Error encontrado:
            // Tipo de error: sintaxis
            // Corrección realizada: Se corrigieron llaves y punto y coma.
            // Explicación: El if necesita estructura correcta.

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

            // Pruebas:
            // Edad 20 -> Mayor de edad
            // Edad 15 -> Menor de edad


            // ---------------- EJERCICIO 2 ----------------
            Console.WriteLine("\n--- Ejercicio 2: Errores Lógicos ---");

            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese la primera nota:");

            while (!double.TryParse(Console.ReadLine(), out nota1))
            {
                Console.WriteLine("Dato inválido. Intente de nuevo:");
            }

            Console.WriteLine("Ingrese la segunda nota:");

            while (!double.TryParse(Console.ReadLine(), out nota2))
            {
                Console.WriteLine("Dato inválido. Intente de nuevo:");
            }

            Console.WriteLine("Ingrese la tercera nota:");

            while (!double.TryParse(Console.ReadLine(), out nota3))
            {
                Console.WriteLine("Dato inválido. Intente de nuevo:");
            }

            // Error encontrado:
            // Tipo de error: lógico
            // Corrección realizada: Se agregaron paréntesis.
            // Explicación: El código compilaba, pero calculaba mal el promedio.

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio es: " + promedio);

            // Error encontrado:
            // Tipo de error: lógico
            // Corrección realizada: Se cambió > por >=.
            // Explicación: 61 también debe aprobar.

            if (promedio >= 61)
            {
                Console.WriteLine("El estudiante aprobó");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó");
            }

            // Casos de prueba:
            // 60 60 60 -> 60 -> Reprobó
            // 61 61 61 -> 61 -> Aprobó
            // 80 70 90 -> 80 -> Aprobó


            // ---------------- EJERCICIO 3 ----------------
            Console.WriteLine("\n--- Ejercicio 3: Error de Ejecución en Arreglos ---");

            int[] numeros = new int[5];
            int suma = 0;

            // Error encontrado:
            // Tipo de error: ejecución
            // Corrección realizada: Se cambió <=5 por <5.
            // Explicación: Un arreglo de tamaño 5 usa posiciones 0-4.

            for (int i = 0; i < 5; i++)
            {
                bool valido = false;

                while (!valido)
                {
                    Console.WriteLine("Ingrese un número:");

                    if (int.TryParse(Console.ReadLine(), out numeros[i]))
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine("La suma total es: " + suma);

            // Prueba:
            // 1,2,3,4,5 -> 15
            // Texto -> pide nuevamente


            // ---------------- EJERCICIO 4 ----------------
            Console.WriteLine("\n--- Ejercicio 4: Depuración con Métodos ---");

            double baseRectangulo;
            double alturaRectangulo;

            while (true)
            {
                Console.WriteLine("Ingrese la base del rectángulo:");

                if (double.TryParse(Console.ReadLine(), out baseRectangulo) && baseRectangulo > 0)
                {
                    break;
                }

                Console.WriteLine("Valor inválido.");
            }

            while (true)
            {
                Console.WriteLine("Ingrese la altura del rectángulo:");

                if (double.TryParse(Console.ReadLine(), out alturaRectangulo) && alturaRectangulo > 0)
                {
                    break;
                }

                Console.WriteLine("Valor inválido.");
            }

            double area = CalcularArea(baseRectangulo, alturaRectangulo);

            Console.WriteLine("Base: " + baseRectangulo);
            Console.WriteLine("Altura: " + alturaRectangulo);
            Console.WriteLine("Área: " + area);

            // Error encontrado:
            // Tipo de error: lógico
            // Corrección realizada: >=100.
            // Explicación: 100 también debe ser grande.

            if (area >= 100)
            {
                Console.WriteLine("El área es grande");
            }
            else
            {
                Console.WriteLine("El área es pequeña");
            }

            // Casos:
            // 10x10 =100 Grande
            // 5x8 =40 Pequeña
            // 20x6 =120 Grande


            // ---------------- EJERCICIO 5 ----------------
            Console.WriteLine("\n--- Ejercicio 5: Análisis de IA ---");

            int[] edades = new int[5];
            int sumaEdades = 0;
            int mayores = 0;
            double promedioEdad;

            // Análisis de la solución generada por IA:
            // Error 1: Usaba posiciones 1-5 en el arreglo.
            // Error 2: Consideraba mayor solo >18.
            // Error 3: Promedio sin asegurar decimales.
            // Limitación encontrada: No validaba texto ni edades negativas.
            // Importancia de la validación humana:
            // La IA puede generar código útil pero con errores que deben revisarse.

            for (int i = 0; i < 5; i++)
            {
                bool valido = false;

                while (!valido)
                {
                    Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                    if (int.TryParse(Console.ReadLine(), out edades[i]) && edades[i] >= 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Edad inválida. Intente nuevamente.");
                    }
                }

                sumaEdades += edades[i];

                // Corrección:
                // Tipo de error: lógico
                // Explicación: 18 también es mayor de edad.

                if (edades[i] >= 18)
                {
                    mayores++;
                }
            }

            promedioEdad = (double)sumaEdades / 5;

            Console.WriteLine("Promedio de edades: " + promedioEdad);
            Console.WriteLine("Cantidad de mayores de edad: " + mayores);

            // Casos:
            // 10,15,18,20,30 -> 18.6 -> 3
            // 18,18,18,18,18 -> 18 -> 5
            // 5,6,7,8,9 -> 7 -> 0


            // Pregunta final de reflexión
            /*
            ¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y validada?

            Una solución generada por Inteligencia Artificial debe revisarse porque puede contener
            errores de sintaxis, lógica o ejecución. Aunque el código parezca correcto, puede producir
            resultados equivocados o fallar al ejecutarse. La IA no siempre interpreta completamente
            el contexto o las reglas del problema. Por eso, el programador debe probar, analizar y
            validar el código antes de considerarlo correcto y confiable.
            */

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        static double CalcularArea(double baseRectangulo, double alturaRectangulo)
        {
            // Error encontrado:
            // Tipo de error: lógico
            // Corrección realizada: multiplicación.
            // Explicación: El área es base * altura.

            return baseRectangulo * alturaRectangulo;
        }
    }
}