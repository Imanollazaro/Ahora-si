using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_2_XD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double precio;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ingreso de datos
            

            if (rbtTelevision.Checked==true)
                precio = 2240.00;
            
            if (rbtLaptop.Checked == true)
                precio = 2350.00;
            if (rbtMicro.Checked == true)
                precio = 340.00;
            if (rbtTablet.Checked == true)
                precio = 1800.00;
            if (rbtImpresora.Checked == true)
                precio = 899.00;

            //salida de datos
            txtPrecio.Text = "S/" + precio + "";
            if (precio==2240.00)
                pictureBox.Image = Image.FromFile("C:/Users/Windows 10/source/repos/TAREA 2 XD/TAREA 2 XD/XD/Monitor.jpg");
            if (precio == 2350.00)
                pictureBox.Image = Image.FromFile("C:/Users/Windows 10/source/repos/TAREA 2 XD/TAREA 2 XD/XD/laptop.png");
            if (precio == 340.00)
                pictureBox.Image = Image.FromFile("C:/Users/Windows 10/source/repos/TAREA 2 XD/TAREA 2 XD/XD/microondas.png");
            if (precio == 1800.00)
                pictureBox.Image = Image.FromFile("C:/Users/Windows 10/source/repos/TAREA 2 XD/TAREA 2 XD/XD/tablet.jpg");
            if (precio == 890.00)
                pictureBox.Image = Image.FromFile("C:/Users/Windows 10/source/repos/TAREA 2 XD/TAREA 2 XD/XD/impresora.png");
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

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
