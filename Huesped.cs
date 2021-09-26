using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionHotel
{
    public class Huesped
    {
        
        public string Nombre { set; get; }
        public string Cedula { set; get; }
        public int Edad { set; get; }
        public int NoHabitaciones { set; get; }
        public int Dias { set; get; }
        public string TipoPago { set; get; }
        public float Subtotal { set; get; }
        public float Descuento { set; get; }
        public float Total { set; get; }

        public Huesped()
        {
        }

        public Huesped(string nombre, string cedula, int edad, int noHabitaciones,  
             int dias,string tipoPago, float subtotal,  float descuento, float total)
        {
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
            NoHabitaciones = noHabitaciones;
            Dias = dias;
            TipoPago = tipoPago;
            Subtotal = subtotal;
            Descuento = descuento;
            Total = total;
        }
       
    }
}
