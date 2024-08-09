using servicioHotelero;
using System.Runtime.CompilerServices;

bool continuar = true;

List<Habitacion> HabitacionesHotel = new List<Habitacion>();
do 
{
    Console.WriteLine("--MENU--\n");
    Console.WriteLine("1. AGREGAR HABITACION");
    Console.WriteLine("2. ELIMINAR HABITACION");
    Console.WriteLine("3. MOSTRAR HABITACION");
    Console.WriteLine("4. ASIGNAR HABITACION A CLIENTE");
    Console.WriteLine("5. LIBERAR HABITACION");
    Console.WriteLine("6. SALIR");

    var opcionHabitacion = int.Parse(Console.ReadLine());
    switch (opcionHabitacion) 
    {
        case 1:
            bool  continuarMenu = true;
            while (continuarMenu) 
            {
                Console.WriteLine("Que tipo de habitacion deseas agregar\n");
                Console.WriteLine("1. HABITACION SIMPLE");
                Console.WriteLine("2. HABITACION DOBLE");
                Console.WriteLine("3. SUITE");
                Console.WriteLine("4. HABITACION DELUX");
                Console.WriteLine("5. SALIR");

                var opcionHabitaciones = int.Parse(Console.ReadLine());
                switch (opcionHabitaciones) 
                {
                    case 1:
                        Console.WriteLine("Escribe Numero de la habitacion");
                        int numeroHabitacion = int.Parse (Console.ReadLine());
                        Console.WriteLine("Escribe el precio por noche de la habitacion");
                        int precioNoche = int.Parse (Console.ReadLine());
                        Console.WriteLine("Escribe el numero de camas de la habitacion");
                        int numeroCamas = int.Parse (Console.ReadLine());

                        HabitacionSimple NuevaHabitacion = new HabitacionSimple(numeroHabitacion,precioNoche,true,null,numeroCamas);
                        HabitacionesHotel.Add(NuevaHabitacion); 
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
} while (continuar);

