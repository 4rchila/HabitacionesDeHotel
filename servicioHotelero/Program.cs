using servicioHotelero;
using System.Runtime.CompilerServices;

bool continuar = true;
int numeroHabitacion = 0;
int precioNoche = 0;
int numeroCamas = 0;
int habitacionNumero = 0;
string servicioEspecial = null;
int busquedaHabitacion = 0;
string asignarClientes = null;

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
                        numeroHabitacion = int.Parse (Console.ReadLine());
                        Console.WriteLine("Escribe el precio por noche de la habitacion");
                        precioNoche = int.Parse (Console.ReadLine());
                        Console.WriteLine("Escribe el numero de camas de la habitacion");
                        numeroCamas = int.Parse (Console.ReadLine());

                        HabitacionSimple NuevaHabitacion = new HabitacionSimple(numeroHabitacion,precioNoche,true,null,numeroCamas);
                        HabitacionesHotel.Add(NuevaHabitacion); 
                        break;
                    case 2:
                        Console.WriteLine("Escribe Numero de la habitacion");
                        numeroHabitacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el precio por noche de la habitacion");
                        precioNoche = int.Parse(Console.ReadLine());
                         Console.WriteLine("La habitacion tiene vista al mar? S/N");
                        var respuestaMar = Console.ReadLine().ToLower();

                        if (respuestaMar == "s")
                        {
                            habitacionDoble NuevaHabitaciondoble = new habitacionDoble(numeroHabitacion, precioNoche, true, null, true);
                            HabitacionesHotel.Add(NuevaHabitaciondoble);
                        }
                        else if (respuestaMar == "n")
                        {
                            habitacionDoble NuevaHabitaciondoble = new habitacionDoble(numeroHabitacion, precioNoche, true, null, false);
                            HabitacionesHotel.Add(NuevaHabitaciondoble);
                        }
                            
                        break;
                    case 3:
                        Console.WriteLine("Escribe Numero de la habitacion");
                        numeroHabitacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el precio por noche de la habitacion");
                        precioNoche = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el numero de habitaciones");
                        habitacionNumero = int.Parse(Console.ReadLine());
                        Console.WriteLine("La habitacion cuenta con jacuzzi S/N");
                        var respuestaJacuzzi = Console.ReadLine().ToLower();

                        if (respuestaJacuzzi == "s")
                        {
                            Suite NuevaHabitacionSuite = new Suite(numeroHabitacion, precioNoche, true,asignarClientes,habitacionNumero ,true);
                            HabitacionesHotel.Add(NuevaHabitacionSuite);
                        }
                        else if (respuestaJacuzzi == "n")
                        {
                            Suite NuevaHabitacionSuite = new Suite(numeroHabitacion, precioNoche, true, asignarClientes,habitacionNumero,false);
                            HabitacionesHotel.Add(NuevaHabitacionSuite);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Escribe Numero de la habitacion");
                        numeroHabitacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el precio por noche de la habitacion");
                        precioNoche = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el numero de habitaciones");
                        habitacionNumero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Con que servicio especial cuenta la habitacion?");
                        servicioEspecial = Console.ReadLine();
                        HabitacionDeluxe NuevaHabitacionDelux = new HabitacionDeluxe(numeroHabitacion,precioNoche,true,asignarClientes,servicioEspecial);
                        break;
                    case 5:
                        continuarMenu = false;
                        break;
                }
            }
            break;
        case 2:
            Console.WriteLine("Escribe el numero de la habitacion que deseas eliminar");
            busquedaHabitacion = int.Parse(Console.ReadLine());
            foreach (var h in HabitacionesHotel)
            {
                if (h.NumeroHabitacion == busquedaHabitacion)
                {
                    HabitacionesHotel.Remove(h);
                }
            }
            break;
        case 3:
            Console.WriteLine("Escribe el numero de la habitacion que deseas buscar");
             busquedaHabitacion = int.Parse(Console.ReadLine());
            foreach (var h in HabitacionesHotel)
            {
                if (h.NumeroHabitacion == busquedaHabitacion)
                {
                    h.MostrarInformacion();
                }
            }
            break;
        case 4:
            Console.WriteLine("Escribe el numero de la habitacion a la que deseas agregarle un cliente");
            busquedaHabitacion = int.Parse(Console.ReadLine());
            foreach (var h in HabitacionesHotel)
            {
                if (h.NumeroHabitacion == busquedaHabitacion)
                {
                    Console.WriteLine("Escribe el nombre del cliente que reserva la habitacion");
                    asignarClientes = Console.ReadLine();
                    h.AsignarCliente(asignarClientes,HabitacionesHotel);
                }
            }
            break;
        case 5:
            Console.WriteLine("Escribe el numero de la habitacion a la que deseas liberar");
            busquedaHabitacion = int.Parse(Console.ReadLine());
            foreach (var h in HabitacionesHotel)
            {
                if (h.NumeroHabitacion == busquedaHabitacion)
                {
                    h.CambiarDisponibilidad(HabitacionesHotel);
                }
            }
            break;
        case 6:
            continuar = false;
            break;
    }
} while (continuar);

