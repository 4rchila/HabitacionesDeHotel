using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioHotelero
{
    public class habitacionDoble : Habitacion
    {
        public bool VistaAlMar { get; set; }
        public habitacionDoble(int numero, double precioNoche, bool disponibilidad, string nombreCliente, bool vistaAlMar) : base(numero, precioNoche, disponibilidad, nombreCliente)
        {
            this.VistaAlMar = vistaAlMar;
        }
        public void InfoExtra(bool visalmar) 
        {
            base.MostrarInformacion();
            Console.WriteLine($"La habitacion cuenta con vista al mar{VistaAlMar}");
        }
    }
}
