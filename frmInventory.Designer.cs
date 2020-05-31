namespace VetApp
{
    partial class frmInventory
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
            this.stockInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.codeInput = new System.Windows.Forms.TextBox();
            this.removeClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código";
            // 
            // stockInput
            // 
            this.stockInput.Location = new System.Drawing.Point(8, 86);
            this.stockInput.Name = "stockInput";
            this.stockInput.Size = new System.Drawing.Size(172, 20);
            this.stockInput.TabIndex = 7;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(8, 60);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(172, 20);
            this.priceInput.TabIndex = 8;
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(8, 34);
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(172, 20);
            this.descInput.TabIndex = 9;
            // 
            // codeInput
            // 
            this.codeInput.Location = new System.Drawing.Point(8, 8);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(172, 20);
            this.codeInput.TabIndex = 10;
            // 
            // removeClient
            // 
            this.removeClient.Location = new System.Drawing.Point(148, 128);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(64, 64);
            this.removeClient.TabIndex = 3;
            this.removeClient.Text = "Eliminar Cliente";
            this.removeClient.UseVisualStyleBackColor = true;
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(78, 128);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(64, 64);
            this.editClient.TabIndex = 4;
            this.editClient.Text = "Modificar Cliente";
            this.editClient.UseVisualStyleBackColor = true;
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(8, 128);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(64, 64);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "Agregar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.descInput);
            this.Controls.Add(this.codeInput);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.editClient);
            this.Controls.Add(this.addClient);
            this.Name = "frmInventory";
            this.Text = "Datos de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.TextBox codeInput;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button addClient;
    }
}