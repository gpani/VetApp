namespace VetApp
{
    partial class frmApp
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.razonInput = new System.Windows.Forms.TextBox();
            this.mascotaInput = new System.Windows.Forms.TextBox();
            this.clienteInput = new System.Windows.Forms.TextBox();
            this.deleteConsulta = new System.Windows.Forms.Button();
            this.editConsulta = new System.Windows.Forms.Button();
            this.addConsulta = new System.Windows.Forms.Button();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.consultaBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmbrInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboConsulta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Razón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cliente";
            // 
            // razonInput
            // 
            this.razonInput.Location = new System.Drawing.Point(11, 153);
            this.razonInput.Margin = new System.Windows.Forms.Padding(4);
            this.razonInput.Name = "razonInput";
            this.razonInput.Size = new System.Drawing.Size(223, 22);
            this.razonInput.TabIndex = 4;
            // 
            // mascotaInput
            // 
            this.mascotaInput.Location = new System.Drawing.Point(11, 121);
            this.mascotaInput.Margin = new System.Windows.Forms.Padding(4);
            this.mascotaInput.Name = "mascotaInput";
            this.mascotaInput.Size = new System.Drawing.Size(223, 22);
            this.mascotaInput.TabIndex = 3;
            // 
            // clienteInput
            // 
            this.clienteInput.Location = new System.Drawing.Point(11, 89);
            this.clienteInput.Margin = new System.Windows.Forms.Padding(4);
            this.clienteInput.Name = "clienteInput";
            this.clienteInput.Size = new System.Drawing.Size(223, 22);
            this.clienteInput.TabIndex = 2;
            // 
            // deleteConsulta
            // 
            this.deleteConsulta.Location = new System.Drawing.Point(197, 259);
            this.deleteConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.deleteConsulta.Name = "deleteConsulta";
            this.deleteConsulta.Size = new System.Drawing.Size(85, 46);
            this.deleteConsulta.TabIndex = 9;
            this.deleteConsulta.Text = "Eliminar Consulta";
            this.deleteConsulta.UseVisualStyleBackColor = true;
            this.deleteConsulta.Click += new System.EventHandler(this.deleteConsulta_Click);
            // 
            // editConsulta
            // 
            this.editConsulta.Location = new System.Drawing.Point(104, 259);
            this.editConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.editConsulta.Name = "editConsulta";
            this.editConsulta.Size = new System.Drawing.Size(85, 46);
            this.editConsulta.TabIndex = 8;
            this.editConsulta.Text = "Modificar Consulta";
            this.editConsulta.UseVisualStyleBackColor = true;
            this.editConsulta.Click += new System.EventHandler(this.editConsulta_Click);
            // 
            // addConsulta
            // 
            this.addConsulta.Location = new System.Drawing.Point(11, 226);
            this.addConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.addConsulta.Name = "addConsulta";
            this.addConsulta.Size = new System.Drawing.Size(85, 79);
            this.addConsulta.TabIndex = 6;
            this.addConsulta.Text = "Agregar Consulta";
            this.addConsulta.UseVisualStyleBackColor = true;
            this.addConsulta.Click += new System.EventHandler(this.addConsulta_Click);
            // 
            // estadoBox
            // 
            this.estadoBox.FormattingEnabled = true;
            this.estadoBox.Items.AddRange(new object[] {
            "En Espera",
            "En Progreso",
            "Postergada",
            "Terminada",
            "Cancelada"});
            this.estadoBox.Location = new System.Drawing.Point(11, 187);
            this.estadoBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(223, 24);
            this.estadoBox.TabIndex = 5;
            // 
            // consultaBox
            // 
            this.consultaBox.FormattingEnabled = true;
            this.consultaBox.Items.AddRange(new object[] {
            "Veterinaria",
            "Peluquería"});
            this.consultaBox.Location = new System.Drawing.Point(11, 49);
            this.consultaBox.Margin = new System.Windows.Forms.Padding(4);
            this.consultaBox.Name = "consultaBox";
            this.consultaBox.Size = new System.Drawing.Size(223, 24);
            this.consultaBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de consulta";
            // 
            // nmbrInput
            // 
            this.nmbrInput.Location = new System.Drawing.Point(11, 10);
            this.nmbrInput.Margin = new System.Windows.Forms.Padding(4);
            this.nmbrInput.Name = "nmbrInput";
            this.nmbrInput.Size = new System.Drawing.Size(223, 22);
            this.nmbrInput.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(245, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nro de Consulta";
            // 
            // comboConsulta
            // 
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Location = new System.Drawing.Point(104, 228);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(178, 24);
            this.comboConsulta.TabIndex = 7;
            this.comboConsulta.Text = "Ver consulta existente...";
            this.comboConsulta.SelectedIndexChanged += new System.EventHandler(this.comboConsulta_SelectedIndexChanged);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.consultaBox);
            this.Controls.Add(this.estadoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.razonInput);
            this.Controls.Add(this.mascotaInput);
            this.Controls.Add(this.nmbrInput);
            this.Controls.Add(this.clienteInput);
            this.Controls.Add(this.deleteConsulta);
            this.Controls.Add(this.editConsulta);
            this.Controls.Add(this.addConsulta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApp";
            this.Text = "Consulta Veterinario";
            this.Load += new System.EventHandler(this.frmAppVet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razonInput;
        private System.Windows.Forms.TextBox mascotaInput;
        private System.Windows.Forms.TextBox clienteInput;
        private System.Windows.Forms.Button deleteConsulta;
        private System.Windows.Forms.Button editConsulta;
        private System.Windows.Forms.Button addConsulta;
        private System.Windows.Forms.ComboBox estadoBox;
        private System.Windows.Forms.ComboBox consultaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nmbrInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboConsulta;
    }
}