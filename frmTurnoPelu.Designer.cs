namespace VetApp
{
    partial class frmTurnoPelu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mascota = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.servicio = new System.Windows.Forms.Label();
            this.comboBoxEpecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Notas = new System.Windows.Forms.Label();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(36, 46);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(256, 22);
            this.txtCliente.TabIndex = 0;
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Location = new System.Drawing.Point(298, 49);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(51, 17);
            this.cliente.TabIndex = 1;
            this.cliente.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Mascota
            // 
            this.Mascota.AutoSize = true;
            this.Mascota.Location = new System.Drawing.Point(298, 86);
            this.Mascota.Name = "Mascota";
            this.Mascota.Size = new System.Drawing.Size(61, 17);
            this.Mascota.TabIndex = 3;
            this.Mascota.Text = "Mascota";
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(36, 126);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(256, 22);
            this.txtServicio.TabIndex = 4;
            // 
            // servicio
            // 
            this.servicio.AutoSize = true;
            this.servicio.Location = new System.Drawing.Point(298, 131);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(110, 17);
            this.servicio.TabIndex = 5;
            this.servicio.Text = "Tipo de Servicio";
            // 
            // comboBoxEpecie
            // 
            this.comboBoxEpecie.FormattingEnabled = true;
            this.comboBoxEpecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Otros"});
            this.comboBoxEpecie.Location = new System.Drawing.Point(36, 163);
            this.comboBoxEpecie.Name = "comboBoxEpecie";
            this.comboBoxEpecie.Size = new System.Drawing.Size(256, 24);
            this.comboBoxEpecie.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Especie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 235);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 123);
            this.textBox2.TabIndex = 8;
            // 
            // Notas
            // 
            this.Notas.AutoSize = true;
            this.Notas.Location = new System.Drawing.Point(42, 215);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(45, 17);
            this.Notas.TabIndex = 9;
            this.Notas.Text = "Notas";
            this.Notas.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(36, 409);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(130, 75);
            this.btnAgregarC.TabIndex = 10;
            this.btnAgregarC.Text = "Agregar Cliente";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            // 
            // btnModificarC
            // 
            this.btnModificarC.Location = new System.Drawing.Point(172, 409);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(130, 75);
            this.btnModificarC.TabIndex = 11;
            this.btnModificarC.Text = "Modificar Cliente";
            this.btnModificarC.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(308, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 75);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmTurnoPelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 501);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarC);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEpecie);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.Mascota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.txtCliente);
            this.Name = "frmTurnoPelu";
            this.Text = "Turno para Peluqueria";
            this.Load += new System.EventHandler(this.frmTurnoPelu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Mascota;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label servicio;
        private System.Windows.Forms.ComboBox comboBoxEpecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Notas;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnEliminar;
    }
}