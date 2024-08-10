using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioHotelero
{
    public class HabitacionSimple : Habitacion
    {
        public int NumeroDeCamas { get; set;}
        public HabitacionSimple(int numero, double precioNoche, bool disponibilidad, string nombreCliente, int numeroDeCamas) : base(numero, precioNoche, disponibilidad, nombreCliente)
        {
            this.NumeroDeCamas = numeroDeCamas;
        }

        public override void MostrarInformacion() 
        {
            base.MostrarInformacion();
            Console.WriteLine($"El numero de camas de la habitacion simple es de {NumeroDeCamas}");
        }
        
    }
}
