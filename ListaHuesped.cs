using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionHotel
{
    public class ListaHuesped
    {
        public List<Huesped> Huespedes { set; get; }

        public ListaHuesped()
        {
            Huespedes = new List<Huesped>();
        }
        public void Agregar(Huesped huesped)
        {
            Huespedes.Add(huesped);
        }

        public List<Huesped> HuespXCedula(string cedula)
        {
            List<Huesped> huespedes = new List<Huesped>();
            foreach (Huesped huesped in Huespedes)
            {
                if (huesped.Cedula.Equals(cedula))
                {
                    huespedes.Add(huesped);
                }
            }
            return huespedes;
        }

    }
}
