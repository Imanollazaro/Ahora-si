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
        private string obrero,tipo;

        private double Tarifa,cantidad, descuentoImpuesto, descuentoSeguro, descuentoSolidaridad,totalIngresos, sueldoneto,bonificacion;
        private double totalImpuesto, totalSeguro, totalSolidaridad;
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
            txtObrero.Clear();
            txtTipo.Clear();
            txtSalida.Clear();
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            txtObrero.Focus();


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
            obrero = txtObrero.Text;
            tipo = txtTipo.Text;
            cantidad = double.Parse(txtCantidad.Text);


            // Calcular el descuento seguro
            if (cantidad>700 && chkA.Checked == true)
                bonificacion = 250;

            // Calcular el descuento por faltas
            if (cantidad > 700 && chkB.Checked == true)
                bonificacion = 150;

            // Calcular el descuento por tardanzas
            if (cantidad > 700 && chkC.Checked == true)
                bonificacion = 100;

            if (cantidad > 700 && chkD.Checked == true)
                bonificacion = 50;

            if (tipo == "polo")
                Tarifa = 0.50;
            if (tipo == "camisa")
                Tarifa = 1.00;
            if (tipo == "pantalon")
                Tarifa = 1.50;

            if (chckImpuesto.Checked == true)
                descuentoImpuesto = 0.09;
            else
                descuentoImpuesto = 0.00;
            if (chckSeguro.Checked == true)
                descuentoSeguro = 0.02;
            else
                descuentoSeguro = 0.00;

            if (chckSolidaridad.Checked == true)
                descuentoSolidaridad = 0.01;
            else
                descuentoSolidaridad = 0.00;

            totalIngresos = Tarifa * cantidad+ bonificacion;
            totalImpuesto = totalIngresos * descuentoImpuesto;
            totalSolidaridad = totalIngresos * descuentoSolidaridad;
            sueldoneto = (totalImpuesto + totalSeguro + totalSolidaridad) - totalIngresos;

            // Salida de Datos 
            txtSalida.Text =
                  "Nombre del Obrero :" + obrero + Environment.NewLine +
                  "Tipo de prenda :" + tipo + Environment.NewLine +
                  "Tarifa :" +Tarifa.ToString() + Environment.NewLine +
                  "Bonificacion: "+bonificacion.ToString()+ Environment.NewLine+
                  "Total de ingresos: "+totalIngresos.ToString()+Environment.NewLine+
                  "Descuento de impuestos: "+totalImpuesto.ToString()+Environment.NewLine+
                  "Descuento de Seguro: " + totalSeguro.ToString() + Environment.NewLine +
                  "Descuento de Solidaridad: " + totalSolidaridad.ToString() + Environment.NewLine +
                  "Sueldo neto : " + Math.Round(sueldoneto, 2).ToString();


        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSeguro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}

