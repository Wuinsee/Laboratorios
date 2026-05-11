// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace L14_InicialesCarne
{
    // --- CLASE EJERCICIO #1: LIBRO ---
    class Libro
    {
        // Atributos [cite: 40-43]
        private string titulo;
        private string autor;
        private int anioPublicacion;
        private bool disponible;

        // Constructor [cite: 47]
        public Libro(string titulo, string autor, int anio, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anio;
            this.disponible = disponible;
        }

        // Métodos [cite: 48-50]
        public void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {titulo} | Autor: {autor} | Año: {anioPublicacion} | Disponible: {(disponible ? "Sí" : "No")}");
        }

        public void PrestarLibro()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine($"Has prestado el libro: {titulo}.");
            }
            else
            {
                Console.WriteLine($"El libro {titulo} ya está prestado.");
            }
        }

        public void DevolverLibro()
        {
            disponible = true;
            Console.WriteLine($"Has devuelto el libro: {titulo}.");
        }
    }

    // --- CLASE EJERCICIO #2: MASCOTA ---
    class Mascota
    {
        // Atributos [cite: 60-63]
        private string nombre;
        private string especie;
        private int edad;
        private bool vacunado;

        // Constructor [cite: 66]
        public Mascota(string nombre, string especie, int edad, bool vacunado)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.vacunado = vacunado;
        }

        // Métodos [cite: 67-69]
        public void MostrarInformacion()
        {
            Console.WriteLine($"Mascota: {nombre} | Especie: {especie} | Edad: {edad} | Vacunado: {(vacunado ? "Sí" : "No")}");
        }

        public void Vacunar()
        {
            vacunado = true;
            Console.WriteLine($"{nombre} ha sido vacunado/a.");
        }

        public void CumplirAnios()
        {
            edad++;
            Console.WriteLine($"{nombre} ahora tiene {edad} años.");
        }
    }

    // --- CLASE EJERCICIO #3: ESTUDIANTE ---
    class Estudiante
    {
        // Atributos [cite: 78-81]
        private string nombre;
        private int edad;
        private string grado;
        private List<double> notas; // Se usa List para facilitar el método AgregarNota [cite: 88]

        // Constructor [cite: 83]
        public Estudiante(string nombre, int edad, string grado, double[] notasIniciales)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = new List<double>(notasIniciales);
        }

        // Métodos [cite: 84, 87, 88]
        public double CalcularPromedio()
        {
            return notas.Count > 0 ? notas.Average() : 0;
        }

        public void Aprobar()
        {
            double promedio = CalcularPromedio();
            string estado = promedio >= 61 ? "APROBADO" : "REPROBADO";
            Console.WriteLine($"El estudiante {nombre} está {estado} con un promedio de {promedio:F2}.");
        }

        public void AgregarNota(double nuevaNota)
        {
            notas.Add(nuevaNota);
            Console.WriteLine($"Nota {nuevaNota} agregada a {nombre}. Nuevo promedio: {CalcularPromedio():F2}");
        }

        // [cite_start]
        public void MostrarInformacion() // [cite: 86]
        {
            Console.WriteLine($"Estudiante: {nombre} | Grado: {grado} | Edad: {edad} | Promedio Actual: {CalcularPromedio():F2}");
        }
    }

    // --- PROGRAMA PRINCIPAL ---
    class Program
    {
        static void Main(string[] args)
        {
            // PRUEBA EJERCICIO 1 [cite: 52-56]
            Console.WriteLine("=== EJERCICIO 1: BIBLIOTECA ===");
            Libro libro1 = new Libro("Don Quijote", "Cervantes", 1605, true);
            Libro libro2 = new Libro("Cien Años de Soledad", "García Márquez", 1967, true);

            libro1.MostrarInformacion();
            libro2.MostrarInformacion();

            libro1.PrestarLibro();
            libro1.MostrarInformacion();
            libro1.DevolverLibro();
            libro1.MostrarInformacion();
            Console.WriteLine();

            // PRUEBA EJERCICIO 2 [cite: 71-74]
            Console.WriteLine("=== EJERCICIO 2: VETERINARIA ===");
            Mascota mascota1 = new Mascota("Firulais", "Perro", 3, false);
            Mascota mascota2 = new Mascota("Michi", "Gato", 2, true);

            mascota1.MostrarInformacion();
            mascota1.Vacunar();
            mascota1.CumplirAnios();
            mascota1.MostrarInformacion();
            Console.WriteLine();

            // PRUEBA EJERCICIO 3 [cite: 90-94]
            Console.WriteLine("=== EJERCICIO 3: ESCUELA ===");
            Estudiante est1 = new Estudiante("Ana Gómez", 15, "Tercero Básico", new double[] { 70, 85, 60 });
            Estudiante est2 = new Estudiante("Luis Perez", 16, "Cuarto Bachillerato", new double[] { 50, 40, 55 });

            est1.MostrarInformacion();
            est1.Aprobar();

            est2.MostrarInformacion();
            est2.Aprobar();

            Console.WriteLine("--- Actualizando notas ---");
            est2.AgregarNota(90);
            est2.Aprobar();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}


