using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_2_EJERCICIOS
{
    public partial class Cálculo : Form
    {
        public Cálculo()
        {
            InitializeComponent();
        }
        // Variables globales
        private string empleado;
        private double sueldo,descuentos, faltas, tardanzas, seguro,cuota, totalpagar;
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtSueldo.Clear();
            txtSalida.Clear();
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            txtEmpleado.Focus();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir del formulario?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (opcion == DialogResult.OK)
            {
                Close();
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Ingreso de datos
            empleado=txtEmpleado.Text;
            sueldo=double.Parse(txtSueldo.Text); 
           
           
            // Calcular el descuento seguro
            if (chkA.Checked == true)
                cuota = 220;
          
            // Calcular el descuento por faltas
            if (chkB.Checked == true)
                cuota = 200;
          
            // Calcular el descuento por tardanzas
            if (chkC.Checked == true)
                cuota = 180;
          
            if (chkD.Checked == true)
                cuota = 160;
            
            if (sueldo>75 &(chkA.Checked == true) | (chkB.Checked == true))
                descuentos = 15;
            else
                descuentos = 0;
            if (sueldo > 75 & (chkC.Checked == true) | (chkD.Checked == true))
                descuentos = 8;

            totalpagar = cuota -  descuentos  ;
            
            // Salida de Datos 
            txtSalida.Text =
                  "Nombre del empleado :" + empleado + Environment.NewLine +
                  "Edad del empleado :" + sueldo.ToString() + Environment.NewLine +
                  "Descuento :" + descuentos.ToString() + Environment.NewLine +
                  "Total a pagar :" + Math.Round(totalpagar, 2).ToString();


           }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSeguro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
