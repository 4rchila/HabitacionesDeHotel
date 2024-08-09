using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioHotelero
{
    public class HabitacionDeluxe : Habitacion
    {
        public string ServicioExtra { get; set; } 
        public HabitacionDeluxe(int numero, double precioNoche, bool disponibilidad, string nombreCliente, string servicioExtra) : base(numero, precioNoche, disponibilidad, nombreCliente)
        {
            this.ServicioExtra = servicioExtra;
        }
        public void InfoExtraDelux() 
        {
            base.MostrarInformacion();
            Console.WriteLine($"La habitacion cuenta con el servicio extra: {ServicioExtra}");

        } 
    }
}
