using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioHotelero
{
    public class Habitacion
    {
        public int NumeroHabitacion { get; set;}
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precioNoche, bool disponibilidad, string nombreCliente)
        {
            this.NumeroHabitacion = numero;
            this.PrecioPorNoche = precioNoche;
            this.Disponible = disponibilidad;
            this.ClienteAsignado = nombreCliente;
        }

        public void MostrarInformacion() 
        {
            Console.WriteLine("Informacion de la habitacion:\n");
            Console.WriteLine($"El numero de la habitacion es: {NumeroHabitacion}");
            Console.WriteLine($"El precio por noche de la habitacion es: {PrecioPorNoche}");
            if (Disponible == true)
            {
                Console.WriteLine($"La habitacion  se encuentra disponible");
            }
            else 
            {
                Console.WriteLine($"La habitacion NO se encuentra disponible");
            }
            Console.WriteLine($"El numero de la habitacion es: {ClienteAsignado}");
            Console.WriteLine($"El numero de la habitacion es: {NumeroHabitacion}");
        }

        public bool CambiarDisponibilidad(List<Habitacion> list) 
        {
          Console.WriteLine("Escribe el numero de la habitacion a la cual deseas cambiarle la disponibilidad");
            int habitacionBuscar = int.Parse(Console.ReadLine());

            Habitacion listaBuscar = list.Find(h => h.NumeroHabitacion == habitacionBuscar);

            if (listaBuscar != null)
            {
                if (listaBuscar.Disponible == true) listaBuscar.Disponible = false;
                else listaBuscar.Disponible = true;
            }
            else 
            {
             Console.WriteLine("Habitacion no encontrada");
            }
            return listaBuscar.Disponible;
        }
        public string AsignarCliente(string nombreCliente, List<Habitacion> list) 
        {
          Console.WriteLine("Escribe el numero de la habitacion que deseas reservar");
            int buscarHabitacion = int.Parse(Console.ReadLine());
            Habitacion listaBuscar = list.Find(h => h.NumeroHabitacion == buscarHabitacion);

            if (listaBuscar != null)
            {
                if (listaBuscar.Disponible == true)
                {
                    listaBuscar.ClienteAsignado = nombreCliente;
                }
                else 
                {
                    Console.WriteLine("La habitacion se encuentra ocupada");
                }
            }
            else
            {
                Console.WriteLine("Habitacion no encontrada");
            }
            return nombreCliente;
        }

    }
}
