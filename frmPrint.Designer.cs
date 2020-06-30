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
            this.listadoMascotas = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.cargarClientes = new System.Windows.Forms.Button();
            this.cargarMascotas = new System.Windows.Forms.Button();
            this.cargarTurnos = new System.Windows.Forms.Button();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.listadoTurnos = new System.Windows.Forms.DataGridView();
            this.nombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoMascotas
            // 
            this.listadoMascotas.AllowUserToAddRows = false;
            this.listadoMascotas.AutoGenerateColumns = false;
            this.listadoMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dueñoMascota,
            this.nomMas,
            this.razaMascota,
            this.edadMascota,
            this.pesoMascota});
            this.listadoMascotas.DataSource = this.clienteBindingSource;
            this.listadoMascotas.Location = new System.Drawing.Point(8, 16);
            this.listadoMascotas.Name = "listadoMascotas";
            this.listadoMascotas.Size = new System.Drawing.Size(784, 376);
            this.listadoMascotas.TabIndex = 2;
            this.listadoMascotas.Visible = false;
            this.listadoMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoHistorial_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // cargarClientes
            // 
            this.cargarClientes.Location = new System.Drawing.Point(8, 392);
            this.cargarClientes.Name = "cargarClientes";
            this.cargarClientes.Size = new System.Drawing.Size(104, 47);
            this.cargarClientes.TabIndex = 3;
            this.cargarClientes.Text = "Mostrar Clientes";
            this.cargarClientes.UseVisualStyleBackColor = true;
            this.cargarClientes.Click += new System.EventHandler(this.cargarClientes_Click);
            // 
            // cargarMascotas
            // 
            this.cargarMascotas.Location = new System.Drawing.Point(120, 392);
            this.cargarMascotas.Name = "cargarMascotas";
            this.cargarMascotas.Size = new System.Drawing.Size(104, 47);
            this.cargarMascotas.TabIndex = 3;
            this.cargarMascotas.Text = "Mostrar Mascotas";
            this.cargarMascotas.UseVisualStyleBackColor = true;
            this.cargarMascotas.Click += new System.EventHandler(this.cargarMascotas_Click);
            // 
            // cargarTurnos
            // 
            this.cargarTurnos.Location = new System.Drawing.Point(232, 392);
            this.cargarTurnos.Name = "cargarTurnos";
            this.cargarTurnos.Size = new System.Drawing.Size(104, 47);
            this.cargarTurnos.TabIndex = 3;
            this.cargarTurnos.Text = "Mostrar Turnos";
            this.cargarTurnos.UseVisualStyleBackColor = true;
            this.cargarTurnos.Click += new System.EventHandler(this.cargarTurnos_Click);
            // 
            // listadoClientes
            // 
            this.listadoClientes.AllowUserToAddRows = false;
            this.listadoClientes.AutoGenerateColumns = false;
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCli,
            this.edad,
            this.dni,
            this.tel,
            this.direccion});
            this.listadoClientes.DataSource = this.clienteBindingSource;
            this.listadoClientes.Location = new System.Drawing.Point(8, 32);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(784, 376);
            this.listadoClientes.TabIndex = 4;
            this.listadoClientes.Visible = false;
            // 
            // listadoTurnos
            // 
            this.listadoTurnos.AllowUserToAddRows = false;
            this.listadoTurnos.AutoGenerateColumns = false;
            this.listadoTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.nombreCliente,
            this.nombreMascota,
            this.razon,
            this.tipoConsulta,
            this.estadoConsulta});
            this.listadoTurnos.DataSource = this.clienteBindingSource;
            this.listadoTurnos.Location = new System.Drawing.Point(8, 48);
            this.listadoTurnos.Name = "listadoTurnos";
            this.listadoTurnos.Size = new System.Drawing.Size(784, 376);
            this.listadoTurnos.TabIndex = 5;
            this.listadoTurnos.Visible = false;
            this.listadoTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoTurnos_CellContentClick);
            // 
            // nombreCli
            // 
            this.nombreCli.HeaderText = "Cliente";
            this.nombreCli.Name = "nombreCli";
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // tel
            // 
            this.tel.HeaderText = "Teléfono";
            this.tel.Name = "tel";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // dueñoMascota
            // 
            this.dueñoMascota.HeaderText = "Dueño";
            this.dueñoMascota.Name = "dueñoMascota";
            // 
            // nomMas
            // 
            this.nomMas.HeaderText = "Mascota";
            this.nomMas.Name = "nomMas";
            // 
            // razaMascota
            // 
            this.razaMascota.HeaderText = "Raza";
            this.razaMascota.Name = "razaMascota";
            // 
            // edadMascota
            // 
            this.edadMascota.HeaderText = "Edad";
            this.edadMascota.Name = "edadMascota";
            // 
            // pesoMascota
            // 
            this.pesoMascota.HeaderText = "Peso";
            this.pesoMascota.Name = "pesoMascota";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(VetApp.Cliente);
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
            // nro
            // 
            this.nro.HeaderText = "N° Consulta";
            this.nro.Name = "nro";
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
            // razon
            // 
            this.razon.HeaderText = "Razón";
            this.razon.Name = "razon";
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
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadoTurnos);
            this.Controls.Add(this.listadoClientes);
            this.Controls.Add(this.cargarTurnos);
            this.Controls.Add(this.cargarMascotas);
            this.Controls.Add(this.cargarClientes);
            this.Controls.Add(this.listadoMascotas);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource veterinariaBindingSource;
        private System.Windows.Forms.DataGridView listadoMascotas;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button cargarClientes;
        private System.Windows.Forms.Button cargarMascotas;
        private System.Windows.Forms.Button cargarTurnos;
        private System.Windows.Forms.DataGridView listadoClientes;
        private System.Windows.Forms.DataGridView listadoTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoConsulta;
    }
}