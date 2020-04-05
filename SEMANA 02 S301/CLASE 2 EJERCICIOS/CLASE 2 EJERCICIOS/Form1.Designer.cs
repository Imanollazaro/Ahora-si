namespace CLASE_2_EJERCICIOS
{
    partial class Cálculo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtObrero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.Descuentos = new System.Windows.Forms.GroupBox();
            this.chckImpuesto = new System.Windows.Forms.CheckBox();
            this.chckSeguro = new System.Windows.Forms.CheckBox();
            this.chckSolidaridad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Descuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLASE_2_EJERCICIOS.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(264, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEGURO DE SALUD VIDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.txtObrero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(33, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(128, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 23);
            this.txtCantidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "CANTIDAD";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(128, 61);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 23);
            this.txtTipo.TabIndex = 3;
            // 
            // txtObrero
            // 
            this.txtObrero.Location = new System.Drawing.Point(128, 30);
            this.txtObrero.Name = "txtObrero";
            this.txtObrero.Size = new System.Drawing.Size(200, 23);
            this.txtObrero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "TIPO DE PRENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "OBRERO ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnProcesar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(572, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CLASE_2_EJERCICIOS.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(62, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::CLASE_2_EJERCICIOS.Properties.Resources.Procesar;
            this.btnProcesar.Location = new System.Drawing.Point(62, 73);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(59, 34);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::CLASE_2_EJERCICIOS.Properties.Resources.limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(62, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 35);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkD);
            this.groupBox3.Controls.Add(this.chkC);
            this.groupBox3.Controls.Add(this.chkB);
            this.groupBox3.Controls.Add(this.chkA);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(33, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 49);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CATEGORIA";
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.ForeColor = System.Drawing.Color.Black;
            this.chkD.Location = new System.Drawing.Point(142, 22);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(34, 19);
            this.chkD.TabIndex = 3;
            this.chkD.Text = "D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.ForeColor = System.Drawing.Color.Black;
            this.chkC.Location = new System.Drawing.Point(103, 22);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(33, 19);
            this.chkC.TabIndex = 2;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.ForeColor = System.Drawing.Color.Black;
            this.chkB.Location = new System.Drawing.Point(64, 22);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(33, 19);
            this.chkB.TabIndex = 1;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.ForeColor = System.Drawing.Color.Black;
            this.chkA.Location = new System.Drawing.Point(24, 22);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(34, 19);
            this.chkA.TabIndex = 0;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSalida);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(33, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 135);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salida de Datos:";
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(0, 22);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(338, 107);
            this.txtSalida.TabIndex = 0;
            // 
            // Descuentos
            // 
            this.Descuentos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Descuentos.Controls.Add(this.chckSolidaridad);
            this.Descuentos.Controls.Add(this.chckSeguro);
            this.Descuentos.Controls.Add(this.chckImpuesto);
            this.Descuentos.ForeColor = System.Drawing.Color.Red;
            this.Descuentos.Location = new System.Drawing.Point(293, 312);
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.Size = new System.Drawing.Size(237, 94);
            this.Descuentos.TabIndex = 6;
            this.Descuentos.TabStop = false;
            this.Descuentos.Text = "Descuentos";
            // 
            // chckImpuesto
            // 
            this.chckImpuesto.AutoSize = true;
            this.chckImpuesto.ForeColor = System.Drawing.Color.Black;
            this.chckImpuesto.Location = new System.Drawing.Point(22, 28);
            this.chckImpuesto.Name = "chckImpuesto";
            this.chckImpuesto.Size = new System.Drawing.Size(89, 17);
            this.chckImpuesto.TabIndex = 0;
            this.chckImpuesto.Text = "Impuesto(9%)";
            this.chckImpuesto.UseVisualStyleBackColor = true;
            // 
            // chckSeguro
            // 
            this.chckSeguro.AutoSize = true;
            this.chckSeguro.ForeColor = System.Drawing.Color.Black;
            this.chckSeguro.Location = new System.Drawing.Point(22, 66);
            this.chckSeguro.Name = "chckSeguro";
            this.chckSeguro.Size = new System.Drawing.Size(83, 17);
            this.chckSeguro.TabIndex = 1;
            this.chckSeguro.Text = "Seguro (2%)";
            this.chckSeguro.UseVisualStyleBackColor = true;
            // 
            // chckSolidaridad
            // 
            this.chckSolidaridad.AutoSize = true;
            this.chckSolidaridad.ForeColor = System.Drawing.Color.Black;
            this.chckSolidaridad.Location = new System.Drawing.Point(117, 28);
            this.chckSolidaridad.Name = "chckSolidaridad";
            this.chckSolidaridad.Size = new System.Drawing.Size(98, 17);
            this.chckSolidaridad.TabIndex = 2;
            this.chckSolidaridad.Text = "Solidaridad(1%)";
            this.chckSolidaridad.UseVisualStyleBackColor = true;
            // 
            // Cálculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.Descuentos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cálculo";
            this.Text = "Cálculo del sueldo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Descuentos.ResumeLayout(false);
            this.Descuentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtObrero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Descuentos;
        private System.Windows.Forms.CheckBox chckSolidaridad;
        private System.Windows.Forms.CheckBox chckSeguro;
        private System.Windows.Forms.CheckBox chckImpuesto;
    }
}

