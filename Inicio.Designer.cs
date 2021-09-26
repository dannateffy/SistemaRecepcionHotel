
namespace SistemaRecepcionHotel
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rECEPCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosIngresadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbPersonal = new System.Windows.Forms.CheckBox();
            this.chbPareja = new System.Windows.Forms.CheckBox();
            this.chbFamiliar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nupDias = new System.Windows.Forms.NumericUpDown();
            this.nupFamiliar = new System.Windows.Forms.NumericUpDown();
            this.nupPersonal = new System.Windows.Forms.NumericUpDown();
            this.nupPareja = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFamiliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPareja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEPCION DE HUESPEDES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mtxtEdad);
            this.panel1.Controls.Add(this.mtxtCedula);
            this.panel1.Controls.Add(this.mtxtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(79, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 96);
            this.panel1.TabIndex = 5;
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtEdad.Location = new System.Drawing.Point(342, 16);
            this.mtxtEdad.Mask = "99";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(70, 22);
            this.mtxtEdad.TabIndex = 6;
            this.mtxtEdad.ValidatingType = typeof(int);
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCedula.Location = new System.Drawing.Point(84, 51);
            this.mtxtCedula.Mask = "0000000000";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(100, 22);
            this.mtxtCedula.TabIndex = 5;
            // 
            // mtxtNombre
            // 
            this.mtxtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNombre.Location = new System.Drawing.Point(83, 16);
            this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNombre.Name = "mtxtNombre";
            this.mtxtNombre.Size = new System.Drawing.Size(197, 22);
            this.mtxtNombre.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECEPCIONToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rECEPCIONToolStripMenuItem
            // 
            this.rECEPCIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionToolStripMenuItem1,
            this.datosIngresadosToolStripMenuItem});
            this.rECEPCIONToolStripMenuItem.Name = "rECEPCIONToolStripMenuItem";
            this.rECEPCIONToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rECEPCIONToolStripMenuItem.Text = "Inicio";
            // 
            // recepcionToolStripMenuItem1
            // 
            this.recepcionToolStripMenuItem1.Name = "recepcionToolStripMenuItem1";
            this.recepcionToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.recepcionToolStripMenuItem1.Text = "Recepcion";
            this.recepcionToolStripMenuItem1.Click += new System.EventHandler(this.recepcionToolStripMenuItem1_Click);
            // 
            // datosIngresadosToolStripMenuItem
            // 
            this.datosIngresadosToolStripMenuItem.Name = "datosIngresadosToolStripMenuItem";
            this.datosIngresadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.datosIngresadosToolStripMenuItem.Text = "Huespedes";
            this.datosIngresadosToolStripMenuItem.Click += new System.EventHandler(this.datosIngresadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // chbPersonal
            // 
            this.chbPersonal.AutoSize = true;
            this.chbPersonal.Location = new System.Drawing.Point(21, 35);
            this.chbPersonal.Name = "chbPersonal";
            this.chbPersonal.Size = new System.Drawing.Size(104, 21);
            this.chbPersonal.TabIndex = 7;
            this.chbPersonal.Text = "Personal  10$";
            this.chbPersonal.UseVisualStyleBackColor = true;
            this.chbPersonal.CheckedChanged += new System.EventHandler(this.chbPersonal_CheckedChanged_1);
            // 
            // chbPareja
            // 
            this.chbPareja.AutoSize = true;
            this.chbPareja.Location = new System.Drawing.Point(21, 61);
            this.chbPareja.Name = "chbPareja";
            this.chbPareja.Size = new System.Drawing.Size(104, 21);
            this.chbPareja.TabIndex = 8;
            this.chbPareja.Text = "Pareja      15$";
            this.chbPareja.UseVisualStyleBackColor = true;
            this.chbPareja.CheckedChanged += new System.EventHandler(this.chbPareja_CheckedChanged);
            // 
            // chbFamiliar
            // 
            this.chbFamiliar.AutoSize = true;
            this.chbFamiliar.Location = new System.Drawing.Point(21, 90);
            this.chbFamiliar.Name = "chbFamiliar";
            this.chbFamiliar.Size = new System.Drawing.Size(106, 21);
            this.chbFamiliar.TabIndex = 9;
            this.chbFamiliar.Text = "Familiar    20$";
            this.chbFamiliar.UseVisualStyleBackColor = true;
            this.chbFamiliar.CheckedChanged += new System.EventHandler(this.chbFamiliar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dias de hospedaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Subtotal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descuento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.nupDias);
            this.groupBox1.Controls.Add(this.nupFamiliar);
            this.groupBox1.Controls.Add(this.nupPersonal);
            this.groupBox1.Controls.Add(this.nupPareja);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chbPersonal);
            this.groupBox1.Controls.Add(this.chbFamiliar);
            this.groupBox1.Controls.Add(this.chbPareja);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // nupDias
            // 
            this.nupDias.Location = new System.Drawing.Point(69, 148);
            this.nupDias.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupDias.Name = "nupDias";
            this.nupDias.Size = new System.Drawing.Size(43, 22);
            this.nupDias.TabIndex = 17;
            this.nupDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nupFamiliar
            // 
            this.nupFamiliar.Enabled = false;
            this.nupFamiliar.Location = new System.Drawing.Point(137, 90);
            this.nupFamiliar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupFamiliar.Name = "nupFamiliar";
            this.nupFamiliar.Size = new System.Drawing.Size(43, 22);
            this.nupFamiliar.TabIndex = 16;
            this.nupFamiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nupPersonal
            // 
            this.nupPersonal.Enabled = false;
            this.nupPersonal.Location = new System.Drawing.Point(137, 32);
            this.nupPersonal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupPersonal.Name = "nupPersonal";
            this.nupPersonal.Size = new System.Drawing.Size(43, 22);
            this.nupPersonal.TabIndex = 15;
            this.nupPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nupPareja
            // 
            this.nupPareja.Enabled = false;
            this.nupPareja.Location = new System.Drawing.Point(137, 61);
            this.nupPareja.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupPareja.Name = "nupPareja";
            this.nupPareja.Size = new System.Drawing.Size(43, 22);
            this.nupPareja.TabIndex = 14;
            this.nupPareja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtDescuento);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbtnTarjeta);
            this.groupBox2.Controls.Add(this.rbtnEfectivo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(346, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 193);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(104, 148);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 21;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(104, 120);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 20;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(104, 90);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total:";
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Location = new System.Drawing.Point(130, 49);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(67, 21);
            this.rbtnTarjeta.TabIndex = 17;
            this.rbtnTarjeta.TabStop = true;
            this.rbtnTarjeta.Text = "Tarjeta";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Location = new System.Drawing.Point(23, 50);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(76, 21);
            this.rbtnEfectivo.TabIndex = 16;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Aqua;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(264, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 23);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(265, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(209, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Aqua;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(314, 409);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRecepcionHotel.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(622, 454);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Sol";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFamiliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPareja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rECEPCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosIngresadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.MaskedTextBox mtxtNombre;
        private System.Windows.Forms.CheckBox chbPersonal;
        private System.Windows.Forms.CheckBox chbPareja;
        private System.Windows.Forms.CheckBox chbFamiliar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.RadioButton rbtnEfectivo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.NumericUpDown nupDias;
        public System.Windows.Forms.NumericUpDown nupFamiliar;
        public System.Windows.Forms.NumericUpDown nupPersonal;
        public System.Windows.Forms.NumericUpDown nupPareja;
    }
}

