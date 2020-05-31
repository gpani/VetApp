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
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(35, 176);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(64, 64);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Agregar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(105, 176);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(64, 64);
            this.editClient.TabIndex = 0;
            this.editClient.Text = "Modificar Cliente";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Location = new System.Drawing.Point(175, 176);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(64, 64);
            this.removeClient.TabIndex = 0;
            this.removeClient.Text = "Eliminar Cliente";
            this.removeClient.UseVisualStyleBackColor = true;
            this.removeClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(35, 31);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(172, 20);
            this.nameInput.TabIndex = 1;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(35, 57);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(172, 20);
            this.ageInput.TabIndex = 1;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(35, 83);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(172, 20);
            this.idInput.TabIndex = 1;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(35, 109);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(172, 20);
            this.phoneInput.TabIndex = 1;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(35, 135);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(172, 20);
            this.addressInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Domicilio";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 345);
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
    }
}