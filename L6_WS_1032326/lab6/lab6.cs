// See https://aka.ms/new-console-template for more information
partial class Program
{
    static void Main()
    {
        // ==============================
        // ENTRADA DE USUARIO INICIAL
        // ==============================
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido al Laboratorio 06!");
        Console.WriteLine();

        // ==============================
        // EJERCICIO 1
        // ==============================
        Console.WriteLine("===== EJERCICIO 1: VEHÍCULOS =====");
        Console.WriteLine("1: Bicicleta");
        Console.WriteLine("2: Motocicleta");
        Console.WriteLine("3: Auto");
        Console.WriteLine("4: Camión");
        Console.WriteLine("5: Autobús");
        Console.Write("Ingrese el tipo de vehículo: ");

        int vehiculo = int.Parse(Console.ReadLine());

        switch (vehiculo)
        {
            case 1:
                Console.WriteLine("Bicicleta → No motorizado");
                break;
            case 2:
                Console.WriteLine("Motocicleta → Ligero");
                break;
            case 3:
                Console.WriteLine("Auto → Mediano");
                break;
            case 4:
                Console.WriteLine("Camión → Pesado");
                break;
            case 5:
                Console.WriteLine("Autobús → Transporte público");
                break;
            default:
                Console.WriteLine("Error: Número fuera de rango.");
                break;
        }

        Console.WriteLine();

        // ==============================
        // EJERCICIO 2
        // ==============================
        Console.WriteLine("===== EJERCICIO 2: BANCO =====");
        Console.Write("Ingrese su límite actual de crédito: ");
        double limite = double.Parse(Console.ReadLine());

        Console.Write("Ingrese tipo de tarjeta (1, 2, 3 u otro): ");
        int tipo = int.Parse(Console.ReadLine());

        double porcentaje;

        switch (tipo)
        {
            case 1:
                porcentaje = 0.25;
                break;
            case 2:
                porcentaje = 0.35;
                break;
            case 3:
                porcentaje = 0.40;
                break;
            default:
                porcentaje = 0.50;
                break;
        }

        double nuevoLimite = limite + (limite * porcentaje);

        Console.WriteLine("Su nuevo límite de crédito es: " + nuevoLimite);
        Console.WriteLine();

        // ==============================
        // EJERCICIO 3
        // ==============================
        Console.WriteLine("===== EJERCICIO 3: EVALUACIÓN =====");
        Console.Write("Ingrese su puntuación (0.0, 0.4, 0.6 o más): ");
        double puntos = double.Parse(Console.ReadLine());

        string nivel;
        double dinero;

        if (puntos == 0.0)
        {
            nivel = "Inaceptable";
        }
        else if (puntos == 0.4)
        {
            nivel = "Aceptable";
        }
        else if (puntos >= 0.6)
        {
            nivel = "Meritorio";
        }
        else
        {
            Console.WriteLine("Puntuación inválida.");
            return;
        }

        dinero = 2400 * puntos;

        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Dinero recibido: " + dinero + "€");
        Console.WriteLine();

        // ==============================
        // EJERCICIO 4
        // ==============================
        Console.WriteLine("===== EJERCICIO 4: PIZZERÍA =====");
        Console.Write("¿Quiere pizza vegetariana? (si/no): ");
        string respuesta = Console.ReadLine().ToLower();

        string ingrediente = "";

        if (respuesta == "si")
        {
            Console.WriteLine("Ingredientes vegetarianos:");
            Console.WriteLine("1: Pimiento");
            Console.WriteLine("2: Tofu");
            Console.Write("Elija un ingrediente: ");
            int opcionVeg = int.Parse(Console.ReadLine());

            if (opcionVeg == 1)
                ingrediente = "Pimiento";
            else if (opcionVeg == 2)
                ingrediente = "Tofu";
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            Console.WriteLine("Pizza Vegetariana con: Mozzarella, Tomate y " + ingrediente);
        }
        else if (respuesta == "no")
        {
            Console.WriteLine("Ingredientes no vegetarianos:");
            Console.WriteLine("1: Peperoni");
            Console.WriteLine("2: Jamón");
            Console.WriteLine("3: Salmón");
            Console.Write("Elija un ingrediente: ");
            int opcionNoVeg = int.Parse(Console.ReadLine());

            switch (opcionNoVeg)
            {
                case 1:
                    ingrediente = "Peperoni";
                    break;
                case 2:
                    ingrediente = "Jamón";
                    break;
                case 3:
                    ingrediente = "Salmón";
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine("Pizza No Vegetariana con: Mozzarella, Tomate y " + ingrediente);
        }
        else
        {
            Console.WriteLine("Respuesta inválida.");
        }

        Console.WriteLine();
        Console.WriteLine("Fin del programa.");
    }
}
