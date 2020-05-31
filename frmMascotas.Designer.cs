namespace VetApp
{
    partial class frmMascotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtEdadM = new System.Windows.Forms.TextBox();
            this.nomMascota = new System.Windows.Forms.Label();
            this.edadMascota = new System.Windows.Forms.Label();
            this.txtRazaM = new System.Windows.Forms.TextBox();
            this.razaM = new System.Windows.Forms.Label();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.btnHistorialM = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pesoMascota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(39, 22);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(334, 22);
            this.txtNombreM.TabIndex = 1;
            // 
            // txtEdadM
            // 
            this.txtEdadM.Location = new System.Drawing.Point(39, 50);
            this.txtEdadM.Name = "txtEdadM";
            this.txtEdadM.Size = new System.Drawing.Size(334, 22);
            this.txtEdadM.TabIndex = 2;
            // 
            // nomMascota
            // 
            this.nomMascota.AutoSize = true;
            this.nomMascota.Location = new System.Drawing.Point(379, 25);
            this.nomMascota.Name = "nomMascota";
            this.nomMascota.Size = new System.Drawing.Size(58, 17);
            this.nomMascota.TabIndex = 3;
            this.nomMascota.Text = "Nombre";
            // 
            // edadMascota
            // 
            this.edadMascota.AutoSize = true;
            this.edadMascota.Location = new System.Drawing.Point(379, 53);
            this.edadMascota.Name = "edadMascota";
            this.edadMascota.Size = new System.Drawing.Size(41, 17);
            this.edadMascota.TabIndex = 4;
            this.edadMascota.Text = "Edad";
            this.edadMascota.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRazaM
            // 
            this.txtRazaM.Location = new System.Drawing.Point(39, 78);
            this.txtRazaM.Name = "txtRazaM";
            this.txtRazaM.Size = new System.Drawing.Size(334, 22);
            this.txtRazaM.TabIndex = 5;
            // 
            // razaM
            // 
            this.razaM.AutoSize = true;
            this.razaM.Location = new System.Drawing.Point(379, 81);
            this.razaM.Name = "razaM";
            this.razaM.Size = new System.Drawing.Size(41, 17);
            this.razaM.TabIndex = 6;
            this.razaM.Text = "Raza";
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Location = new System.Drawing.Point(25, 259);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(133, 94);
            this.btnAgregarMascota.TabIndex = 7;
            this.btnAgregarMascota.Text = "Agregar Mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.Location = new System.Drawing.Point(164, 259);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(133, 94);
            this.btnModificarMascota.TabIndex = 8;
            this.btnModificarMascota.Text = "Modificar Mascota";
            this.btnModificarMascota.UseVisualStyleBackColor = true;
            // 
            // btnHistorialM
            // 
            this.btnHistorialM.Location = new System.Drawing.Point(304, 259);
            this.btnHistorialM.Name = "btnHistorialM";
            this.btnHistorialM.Size = new System.Drawing.Size(133, 94);
            this.btnHistorialM.TabIndex = 9;
            this.btnHistorialM.Text = "Ver Historial Médico";
            this.btnHistorialM.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Location = new System.Drawing.Point(453, 259);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(133, 94);
            this.btnEliminarMascota.TabIndex = 10;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 22);
            this.textBox1.TabIndex = 11;
            // 
            // pesoMascota
            // 
            this.pesoMascota.AutoSize = true;
            this.pesoMascota.Location = new System.Drawing.Point(379, 110);
            this.pesoMascota.Name = "pesoMascota";
            this.pesoMascota.Size = new System.Drawing.Size(40, 17);
            this.pesoMascota.TabIndex = 12;
            this.pesoMascota.Text = "Peso";
            // 
            // frmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.pesoMascota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.btnHistorialM);
            this.Controls.Add(this.btnModificarMascota);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.razaM);
            this.Controls.Add(this.txtRazaM);
            this.Controls.Add(this.edadMascota);
            this.Controls.Add(this.nomMascota);
            this.Controls.Add(this.txtEdadM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.label1);
            this.Name = "frmMascotas";
            this.Text = "Datos Mascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtEdadM;
        private System.Windows.Forms.Label nomMascota;
        private System.Windows.Forms.Label edadMascota;
        private System.Windows.Forms.TextBox txtRazaM;
        private System.Windows.Forms.Label razaM;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Button btnModificarMascota;
        private System.Windows.Forms.Button btnHistorialM;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pesoMascota;
    }
}