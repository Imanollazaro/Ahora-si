namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnC = new System.Windows.Forms.RadioButton();
            this.btnB = new System.Windows.Forms.RadioButton();
            this.btnA = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNacional = new System.Windows.Forms.RadioButton();
            this.btnImportado = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkIsc = new System.Windows.Forms.CheckBox();
            this.chkFlete = new System.Windows.Forms.CheckBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonProcesar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPRESA ASR SOLUTION ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCantidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de datos";
            // 
            // cboCantidad
            // 
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Items.AddRange(new object[] {
            "0-5",
            "6-10",
            "11-15",
            "+15"});
            this.cboCantidad.Location = new System.Drawing.Point(103, 90);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(198, 21);
            this.cboCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(231, 58);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PRECIO";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(103, 54);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(41, 20);
            this.txtArticulo.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(103, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(210, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ARTICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnC);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Controls.Add(this.btnA);
            this.groupBox2.Location = new System.Drawing.Point(441, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.Location = new System.Drawing.Point(71, 19);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(32, 17);
            this.btnC.TabIndex = 2;
            this.btnC.TabStop = true;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.AutoSize = true;
            this.btnB.Location = new System.Drawing.Point(36, 19);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(32, 17);
            this.btnB.TabIndex = 1;
            this.btnB.TabStop = true;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.Location = new System.Drawing.Point(6, 19);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(32, 17);
            this.btnA.TabIndex = 0;
            this.btnA.TabStop = true;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNacional);
            this.groupBox3.Controls.Add(this.btnImportado);
            this.groupBox3.Location = new System.Drawing.Point(590, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de variables";
            // 
            // btnNacional
            // 
            this.btnNacional.AutoSize = true;
            this.btnNacional.Location = new System.Drawing.Point(99, 24);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(79, 17);
            this.btnNacional.TabIndex = 2;
            this.btnNacional.TabStop = true;
            this.btnNacional.Text = "NACIONAL";
            this.btnNacional.UseVisualStyleBackColor = true;
            // 
            // btnImportado
            // 
            this.btnImportado.AutoSize = true;
            this.btnImportado.Location = new System.Drawing.Point(6, 22);
            this.btnImportado.Name = "btnImportado";
            this.btnImportado.Size = new System.Drawing.Size(90, 17);
            this.btnImportado.TabIndex = 1;
            this.btnImportado.TabStop = true;
            this.btnImportado.Text = "IMPORTADO";
            this.btnImportado.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkIsc);
            this.groupBox4.Controls.Add(this.chkFlete);
            this.groupBox4.Location = new System.Drawing.Point(441, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 59);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Impuestos fijos";
            // 
            // chkIsc
            // 
            this.chkIsc.AutoSize = true;
            this.chkIsc.Location = new System.Drawing.Point(71, 28);
            this.chkIsc.Name = "chkIsc";
            this.chkIsc.Size = new System.Drawing.Size(43, 17);
            this.chkIsc.TabIndex = 1;
            this.chkIsc.Text = "ISC";
            this.chkIsc.UseVisualStyleBackColor = true;
            // 
            // chkFlete
            // 
            this.chkFlete.AutoSize = true;
            this.chkFlete.Location = new System.Drawing.Point(10, 27);
            this.chkFlete.Name = "chkFlete";
            this.chkFlete.Size = new System.Drawing.Size(59, 17);
            this.chkFlete.TabIndex = 0;
            this.chkFlete.Text = "FLETE";
            this.chkFlete.UseVisualStyleBackColor = true;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(68, 344);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(380, 135);
            this.txtSalida.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botonSalir);
            this.groupBox5.Controls.Add(this.botonProcesar);
            this.groupBox5.Controls.Add(this.botonLimpiar);
            this.groupBox5.Location = new System.Drawing.Point(590, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 208);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACCIONES";
            // 
            // botonSalir
            // 
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.Location = new System.Drawing.Point(99, 146);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 40);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // botonProcesar
            // 
            this.botonProcesar.Image = ((System.Drawing.Image)(resources.GetObject("botonProcesar.Image")));
            this.botonProcesar.Location = new System.Drawing.Point(99, 89);
            this.botonProcesar.Name = "botonProcesar";
            this.botonProcesar.Size = new System.Drawing.Size(75, 40);
            this.botonProcesar.TabIndex = 1;
            this.botonProcesar.UseVisualStyleBackColor = true;
            this.botonProcesar.Click += new System.EventHandler(this.botonProcesar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("botonLimpiar.Image")));
            this.botonLimpiar.Location = new System.Drawing.Point(99, 33);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 35);
            this.botonLimpiar.TabIndex = 0;
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnC;
        private System.Windows.Forms.RadioButton btnB;
        private System.Windows.Forms.RadioButton btnA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnNacional;
        private System.Windows.Forms.RadioButton btnImportado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkIsc;
        private System.Windows.Forms.CheckBox chkFlete;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonProcesar;
        private System.Windows.Forms.Button botonLimpiar;
    }
}

