using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioHotelero
{
    public class Suite : Habitacion
    {
        public int NumeroDeHabitaciones { get; set;}
        public bool TieneJacuzzi {  get; set;}
        public Suite(int numero, double precioNoche, bool disponibilidad, string nombreCliente, int numeroDeHabitaciones, bool tieneJacuzzi) : base(numero, precioNoche, disponibilidad, nombreCliente)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"El numero de habitaciones es: {NumeroDeHabitaciones}");
            if ( TieneJacuzzi == true) 
            {
                Console.WriteLine("La habitacion cuenta con Jacuzzi");
            }else
            {
                Console.WriteLine("La habitacion no cuenta con Jacuzzi");
            }
 
        }
    }
}
