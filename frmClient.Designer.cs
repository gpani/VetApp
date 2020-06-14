namespace VetApp
{
    partial class frmClient
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
            this.addClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.removeClient = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboVerClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(47, 196);
            this.addClient.Margin = new System.Windows.Forms.Padding(4);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(85, 100);
            this.addClient.TabIndex = 6;
            this.addClient.Text = "Agregar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(140, 227);
            this.editClient.Margin = new System.Windows.Forms.Padding(4);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(85, 69);
            this.editClient.TabIndex = 8;
            this.editClient.Text = "Modificar Cliente";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Location = new System.Drawing.Point(233, 227);
            this.removeClient.Margin = new System.Windows.Forms.Padding(4);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(85, 69);
            this.removeClient.TabIndex = 9;
            this.removeClient.Text = "Eliminar Cliente";
            this.removeClient.UseVisualStyleBackColor = true;
            this.removeClient.Click += new System.EventHandler(this.removeClient_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(47, 38);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(228, 22);
            this.nameInput.TabIndex = 1;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(47, 70);
            this.ageInput.Margin = new System.Windows.Forms.Padding(4);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(228, 22);
            this.ageInput.TabIndex = 2;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(47, 102);
            this.idInput.Margin = new System.Windows.Forms.Padding(4);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(228, 22);
            this.idInput.TabIndex = 3;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(47, 134);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(4);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(228, 22);
            this.phoneInput.TabIndex = 4;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(47, 166);
            this.addressInput.Margin = new System.Windows.Forms.Padding(4);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(228, 22);
            this.addressInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Domicilio";
            // 
            // comboVerClientes
            // 
            this.comboVerClientes.FormattingEnabled = true;
            this.comboVerClientes.Location = new System.Drawing.Point(140, 196);
            this.comboVerClientes.Name = "comboVerClientes";
            this.comboVerClientes.Size = new System.Drawing.Size(178, 24);
            this.comboVerClientes.TabIndex = 7;
            this.comboVerClientes.Text = "Elegir cliente existente...";
            this.comboVerClientes.SelectedIndexChanged += new System.EventHandler(this.comboVerClientes_SelectedIndexChanged);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 425);
            this.Controls.Add(this.comboVerClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.editClient);
            this.Controls.Add(this.addClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClient";
            this.Text = "Datos de Cliente";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboVerClientes;
    }
}