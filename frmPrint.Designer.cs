namespace VetApp
{
    partial class frmPrint
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
            this.components = new System.ComponentModel.Container();
            this.btnQueryCliente = new System.Windows.Forms.Button();
            this.btnQueryConsulta = new System.Windows.Forms.Button();
            this.btnQueryMascota = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQueryCliente
            // 
            this.btnQueryCliente.Location = new System.Drawing.Point(8, 8);
            this.btnQueryCliente.Name = "btnQueryCliente";
            this.btnQueryCliente.Size = new System.Drawing.Size(144, 64);
            this.btnQueryCliente.TabIndex = 1;
            this.btnQueryCliente.Text = "Mostrar Clientes";
            this.btnQueryCliente.UseVisualStyleBackColor = true;
            // 
            // btnQueryConsulta
            // 
            this.btnQueryConsulta.Location = new System.Drawing.Point(648, 8);
            this.btnQueryConsulta.Name = "btnQueryConsulta";
            this.btnQueryConsulta.Size = new System.Drawing.Size(144, 64);
            this.btnQueryConsulta.TabIndex = 1;
            this.btnQueryConsulta.Text = "Mostrar Consultas";
            this.btnQueryConsulta.UseVisualStyleBackColor = true;
            // 
            // btnQueryMascota
            // 
            this.btnQueryMascota.Location = new System.Drawing.Point(328, 8);
            this.btnQueryMascota.Name = "btnQueryMascota";
            this.btnQueryMascota.Size = new System.Drawing.Size(144, 64);
            this.btnQueryMascota.TabIndex = 1;
            this.btnQueryMascota.Text = "Mostrar Mascotas";
            this.btnQueryMascota.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.clienteBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(8, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 328);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataSource = typeof(VetApp.Cliente);
            // 
            // veterinariaBindingSource
            // 
            this.veterinariaBindingSource.DataSource = typeof(VetApp.Veterinaria);
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataSource = typeof(VetApp.Mascota);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(VetApp.Cliente);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(VetApp.Cliente);
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataSource = typeof(VetApp.Cliente);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(VetApp.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(VetApp.Program);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQueryMascota);
            this.Controls.Add(this.btnQueryConsulta);
            this.Controls.Add(this.btnQueryCliente);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnQueryCliente;
        private System.Windows.Forms.Button btnQueryConsulta;
        private System.Windows.Forms.Button btnQueryMascota;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource veterinariaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Data.DataSet dataSet1;
    }
}