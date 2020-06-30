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
            this.listadoHistorial = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoHistorial)).BeginInit();
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
            // listadoHistorial
            // 
            this.listadoHistorial.AllowUserToAddRows = false;
            this.listadoHistorial.AutoGenerateColumns = false;
            this.listadoHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.nombreMascota,
            this.dni,
            this.nroTelefono,
            this.tipoConsulta,
            this.estadoConsulta,
            this.direccion});
            this.listadoHistorial.DataSource = this.clienteBindingSource;
            this.listadoHistorial.Location = new System.Drawing.Point(8, 8);
            this.listadoHistorial.Name = "listadoHistorial";
            this.listadoHistorial.Size = new System.Drawing.Size(784, 424);
            this.listadoHistorial.TabIndex = 2;
            //this.listadoHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoHistorial_CellContentClick);
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
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // nombreMascota
            // 
            this.nombreMascota.HeaderText = "Mascota";
            this.nombreMascota.Name = "nombreMascota";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // nroTelefono
            // 
            this.nroTelefono.HeaderText = "Número de Teléfono";
            this.nroTelefono.Name = "nroTelefono";
            // 
            // tipoConsulta
            // 
            this.tipoConsulta.HeaderText = "Tipo de Consulta";
            this.tipoConsulta.Name = "tipoConsulta";
            // 
            // estadoConsulta
            // 
            this.estadoConsulta.HeaderText = "Estado de Consulta";
            this.estadoConsulta.Name = "estadoConsulta";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadoHistorial);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoHistorial)).EndInit();
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
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource veterinariaBindingSource;
        private System.Windows.Forms.DataGridView listadoHistorial;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}