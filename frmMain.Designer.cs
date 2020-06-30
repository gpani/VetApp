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
            this.btnTurnoVet = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(9, 10);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(154, 58);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Datos de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(9, 72);
            this.btnMascotas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(154, 58);
            this.btnMascotas.TabIndex = 1;
            this.btnMascotas.Text = "Datos de Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnTurnoVet
            // 
            this.btnTurnoVet.Location = new System.Drawing.Point(9, 135);
            this.btnTurnoVet.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnoVet.Name = "btnTurnoVet";
            this.btnTurnoVet.Size = new System.Drawing.Size(154, 59);
            this.btnTurnoVet.TabIndex = 3;
            this.btnTurnoVet.Text = "Turnos";
            this.btnTurnoVet.UseVisualStyleBackColor = true;
            this.btnTurnoVet.Click += new System.EventHandler(this.btnTurnoVet_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(8, 264);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(154, 32);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(8, 200);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(152, 56);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Registros";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 303);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnTurnoVet);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "VetApp - Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnTurnoVet;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnQuery;
    }
}

