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
            this.nomMascota = new System.Windows.Forms.Label();
            this.edadMascota = new System.Windows.Forms.Label();
            this.txtRazaM = new System.Windows.Forms.TextBox();
            this.razaM = new System.Windows.Forms.Label();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.pesoMascota = new System.Windows.Forms.Label();
            this.dueñoM = new System.Windows.Forms.Label();
            this.numEdadM = new System.Windows.Forms.NumericUpDown();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboVerMascota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadM)).BeginInit();
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
            this.txtRazaM.TabIndex = 3;
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
            this.btnAgregarMascota.Location = new System.Drawing.Point(39, 171);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(133, 94);
            this.btnAgregarMascota.TabIndex = 6;
            this.btnAgregarMascota.Text = "Agregar Mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.Location = new System.Drawing.Point(178, 200);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(102, 65);
            this.btnModificarMascota.TabIndex = 8;
            this.btnModificarMascota.Text = "Modificar Mascota";
            this.btnModificarMascota.UseVisualStyleBackColor = true;
            this.btnModificarMascota.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Location = new System.Drawing.Point(286, 200);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(100, 65);
            this.btnEliminarMascota.TabIndex = 9;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(39, 110);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(334, 22);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
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
            // dueñoM
            // 
            this.dueñoM.AutoSize = true;
            this.dueñoM.Location = new System.Drawing.Point(379, 141);
            this.dueñoM.Name = "dueñoM";
            this.dueñoM.Size = new System.Drawing.Size(50, 17);
            this.dueñoM.TabIndex = 14;
            this.dueñoM.Text = "Dueño";
            this.dueñoM.Click += new System.EventHandler(this.dueñoM_Click);
            // 
            // numEdadM
            // 
            this.numEdadM.Location = new System.Drawing.Point(39, 50);
            this.numEdadM.Name = "numEdadM";
            this.numEdadM.Size = new System.Drawing.Size(334, 22);
            this.numEdadM.TabIndex = 2;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(39, 141);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(334, 24);
            this.comboCliente.TabIndex = 5;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // comboVerMascota
            // 
            this.comboVerMascota.FormattingEnabled = true;
            this.comboVerMascota.Location = new System.Drawing.Point(178, 171);
            this.comboVerMascota.Name = "comboVerMascota";
            this.comboVerMascota.Size = new System.Drawing.Size(208, 24);
            this.comboVerMascota.TabIndex = 7;
            this.comboVerMascota.Text = "Elegir mascota  existente...";
            this.comboVerMascota.SelectedIndexChanged += new System.EventHandler(this.comboVerMascota_SelectedIndexChanged);
            // 
            // frmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 304);
            this.Controls.Add(this.comboVerMascota);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.numEdadM);
            this.Controls.Add(this.dueñoM);
            this.Controls.Add(this.pesoMascota);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.btnModificarMascota);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.razaM);
            this.Controls.Add(this.txtRazaM);
            this.Controls.Add(this.edadMascota);
            this.Controls.Add(this.nomMascota);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.label1);
            this.Name = "frmMascotas";
            this.Text = "Datos Mascotas";
            this.Load += new System.EventHandler(this.frmMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdadM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label nomMascota;
        private System.Windows.Forms.Label edadMascota;
        private System.Windows.Forms.TextBox txtRazaM;
        private System.Windows.Forms.Label razaM;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Button btnModificarMascota;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label pesoMascota;
        private System.Windows.Forms.Label dueñoM;
        private System.Windows.Forms.NumericUpDown numEdadM;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboVerMascota;
    }
}