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
    public partial class Inicio : Form
    {
        ListaHuesped listaHuesped = new ListaHuesped();
        Huesped huesped1 = new Huesped();
        float subt, des, total;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void recepcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Hide();
        }

        private void datosIngresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosHuespedes datosHuespedes = new DatosHuespedes();
            datosHuespedes.Show();
            datosHuespedes.ListaHuespedes = listaHuesped;
            datosHuespedes.dgvHuespedes.DataSource = listaHuesped.Huespedes;
            Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Total();
            txtDescuento.Text = Convert.ToString(des);
            txtSubtotal.Text = Convert.ToString(subt); 
            txtTotal.Text = Convert.ToString(total);

        }

        public int MayorEdad()
        {
           
                int Edad = Convert.ToInt32(mtxtEdad.Text);
                if (Edad < 18)
                {
                    MessageBox.Show("Lo sentimos, debe ser Mayor de Edad", "Alerta de Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtEdad.Text = "";
                }

            return Edad; 
           
        }

        public int NoHabitaciones()
        {
            int totalHabi;
            int noPer = Convert.ToInt32(nupPersonal.Value);
            int noPar = Convert.ToInt32(nupPareja.Value);
            int noFam = Convert.ToInt32(nupFamiliar.Value);
            totalHabi = noPer+noPar+noFam;
            return totalHabi;
        }
        

        public void Total()
        {
            int noPer = Convert.ToInt32(nupPersonal.Value);
            int noPar = Convert.ToInt32(nupPareja.Value);
            int noFam = Convert.ToInt32(nupFamiliar.Value);
            int noDia = Convert.ToInt32(nupDias.Value);
            float valorPer = noPer * 10;
            float valorPar = noPar * 15;
            float valorFam = noFam * 20;
            subt = (valorPer + valorPar + valorFam) * noDia;

            if (noDia >= 3)
            {
                des = subt * 5/100;
            }
            else
            {
                des = 0;
            }         
            total = subt - des;           
        }
        
        

        public void Limpiar()
        {
            mtxtCedula.Text = "";
            mtxtEdad.Text = "";
            mtxtNombre.Text = "";
            rbtnEfectivo.Checked = false;
            rbtnTarjeta.Checked = false;
            nupPersonal.Value = 0;
            nupPareja.Value = 0;
            nupFamiliar.Value = 0;
            nupDias.Value = 0;
            chbPersonal.Checked = false;
            chbPareja.Checked = false;
            chbFamiliar.Checked = false;
            txtDescuento.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
        }
        public string Pago()
        {
            string tiPago;
            if(rbtnEfectivo.Checked)
            {
                tiPago = "Efectivo";
            }
            else
            {
                tiPago = "Tarjeta";
            }
            return tiPago;
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Comprobar())
                {
                    if (Convert.ToInt32(mtxtEdad.Text) >= 18)
                    {
                        Huesped huesped = new Huesped(mtxtNombre.Text, mtxtCedula.Text, MayorEdad(), NoHabitaciones(),
                    Convert.ToInt32(nupDias.Value), Pago(),subt, des, total);
                    listaHuesped.Agregar(huesped);
                        MessageBox.Show("Datos almacenandos correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos, debe ser Mayor de Edad", "Alerta de Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                       
            }
            catch
            {
                MessageBox.Show("Ingrese todos los datos", "Alerta de Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

      
        }

        public bool Comprobar()
        {
            bool aux = false;
            if (mtxtNombre.Text != "" && mtxtEdad.Text != "" && mtxtCedula.Text != "" )
                
            {
                if (chbPersonal.Checked || chbPareja.Checked || chbFamiliar.Checked)
                {
                    if (nupDias.Value > 0)
                    {
                        if (nupPersonal.Value>0 || nupPareja.Value >0 || nupFamiliar.Value >0)
                        {
                            if (rbtnEfectivo.Checked || rbtnTarjeta.Checked)
                            {
                                if (txtSubtotal.Text != "" && txtDescuento.Text != "" && txtTotal.Text != "")
                                {                           
                                    aux = true;
                                }     
                            }
                        }
                    }
                    
                    
                }
            }
            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void chbPersonal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbPersonal.Checked)
            {
                nupPersonal.Enabled = true;
            }
            else
            {
                nupPersonal.Enabled = false;
                nupPersonal.Value = 0;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DatosHuespedes datosHuespedes = new DatosHuespedes();
            datosHuespedes.Show();
            datosHuespedes.ListaHuespedes = listaHuesped;
            datosHuespedes.dgvHuespedes.DataSource = listaHuesped.Huespedes;
            Hide();
        }

        private void nupFamiliar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chbPareja_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPareja.Checked)
            {
                nupPareja.Enabled = true;
            }
            else
            {
                nupPareja.Enabled = false;
                nupPareja.Value = 0;
            }
        }

        private void chbFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFamiliar.Checked)
            {
                nupFamiliar.Enabled = true;
            }
            else
            {
                nupFamiliar.Enabled = false;
                nupFamiliar.Value = 0;
            }
        }
    }
}
