using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        /// Punto de entrada principal para la aplicación.
        private string cliente, articulo;
        private double precio, cantidad, flete, descuento, calidad, totaldescuento, totalcantidad, isc, totalpagar;

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArticulo.Clear();
            txtPrecio.Clear();
            chkFlete.Checked = false;
            chkIsc.Checked = false;
            btnA.Checked = false;
            btnB.Checked = false;
            btnC.Checked = false;
            btnImportado.Checked = false;
            btnNacional.Checked = false;

        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {

            articulo = txtArticulo.Text;
            precio = double.Parse(txtPrecio.Text);
            flete = 0.03;
            isc = 0.045;

            if (cboCantidad.SelectedIndex == 0)
                descuento = 0.130;
            else if (cboCantidad.SelectedIndex == 1)
                descuento = 0.250;
            else if (cboCantidad.SelectedIndex == 2)
                descuento = 0.290;
            else if (cboCantidad.SelectedIndex == 3)
                descuento = 0.320;
            if (btnA.Checked == true)
                calidad = 0.02;
            else if (btnB.Checked == true)
                calidad = 0.01;
            else if (btnA.Checked == true)
                calidad = 0.005;
            
            totalcantidad = descuento * precio;
            totaldescuento = totalcantidad * calidad;
            totalpagar = totaldescuento + totalcantidad;

            //salida de datos
            txtSalida.Text =
                "Articulo: " + articulo + Environment.NewLine +
                "Precio del articulo: " + precio + Environment.NewLine +
                "Total de descuentos: " + totaldescuento + Environment.NewLine +
                "Incrementos: " + totalcantidad + Environment.NewLine +
                "Total a pagar: " + totalpagar + Environment.NewLine;







        }
    }

}