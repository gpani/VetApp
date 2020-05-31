namespace VetApp
{
    partial class frmMain
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnTurnoVet = new System.Windows.Forms.Button();
            this.btnPelu = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(205, 71);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Datos de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(12, 89);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(205, 71);
            this.btnMascotas.TabIndex = 1;
            this.btnMascotas.Text = "Datos de Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(12, 166);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(205, 71);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnTurnoVet
            // 
            this.btnTurnoVet.Location = new System.Drawing.Point(12, 243);
            this.btnTurnoVet.Name = "btnTurnoVet";
            this.btnTurnoVet.Size = new System.Drawing.Size(205, 73);
            this.btnTurnoVet.TabIndex = 3;
            this.btnTurnoVet.Text = "Turno Veterinaria";
            this.btnTurnoVet.UseVisualStyleBackColor = true;
            this.btnTurnoVet.Click += new System.EventHandler(this.btnTurnoVet_Click);
            // 
            // btnPelu
            // 
            this.btnPelu.Location = new System.Drawing.Point(12, 322);
            this.btnPelu.Name = "btnPelu";
            this.btnPelu.Size = new System.Drawing.Size(205, 73);
            this.btnPelu.TabIndex = 4;
            this.btnPelu.Text = "Turno Peluqueria";
            this.btnPelu.UseVisualStyleBackColor = true;
            this.btnPelu.Click += new System.EventHandler(this.btnPelu_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(12, 401);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(205, 39);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 454);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnPelu);
            this.Controls.Add(this.btnTurnoVet);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmMain";
            this.Text = "VetApp - Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnTurnoVet;
        private System.Windows.Forms.Button btnPelu;
        private System.Windows.Forms.Button btnSalida;
    }
}

