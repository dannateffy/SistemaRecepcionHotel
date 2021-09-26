using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionHotel
{
    public partial class DatosHuespedes : Form
    {
        public ListaHuesped ListaHuespedes { set; get; }
        public DatosHuespedes()
        {
            InitializeComponent();
            ListaHuespedes = new ListaHuesped();
        }

        private void recepciomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Hide();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosHuespedes datosHuespedes = new DatosHuespedes();
            datosHuespedes.Show();
            dgvHuespedes.DataSource = ListaHuespedes.Huespedes;
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
              dgvHuespedes.DataSource= ListaHuespedes.HuespXCedula(mtxtCedulaB.Text);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvHuespedes.DataSource = ListaHuespedes.Huespedes;
        }
    }
}
