using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp
{
    [Serializable]
    class Mascota
    {
        String nombre;
        String raza;
        int edad;
        Cliente duenno;

        public Mascota(String nombre, String raza, int edad, Cliente duenno)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.duenno = duenno;
        }
    }

    [Serializable]
    class Cliente
    {
        public String nombreApellido;
        public int edad;
        public int dni;
        public String telefono;
        public String domicilio;

        public Cliente(String nombre, int edad, int dni, String telefono, String domicilio)
        {
            this.nombreApellido = nombre;
            this.edad = edad;
            this.dni = dni;
            this.telefono = telefono;
            this.domicilio = domicilio;
        }

        public override string ToString()
        {
            return this.nombreApellido;
        }

    }

    [Serializable]
    class Consulta
    {
        public string cliente;
        public string mascota;
        public string razon;
        public string estado;
        public string tipoConsulta;

        public Consulta (String cl, String mascota, String razon, String estado, String tc)
        {
            this.cliente = cl;
            this.mascota = mascota;
            this.razon = razon;
            this.estado = estado;
            this.tipoConsulta = tc;
        }
    }

    /* Esta es la clase principal que se carga cuando arranca la app
     * y se va actualizando cuando se cargan datos en los formularios 
     */
    [Serializable]
    class Veterinaria
    {
        public List<Mascota> mascotas;
        public List<Cliente> clientes;
        public List<Consulta> consultas;
        
        public Veterinaria()
        {
            mascotas = new List<Mascota>();
            clientes = new List<Cliente>();
            consultas = new List<Consulta>();
        }
        public bool agregarConsulta(Consulta con)
        {
            foreach (Consulta consulta in this.consultas)
            {
                if ((consulta.razon == con.razon) && (consulta.cliente == con.cliente))
                {
                    MessageBox.Show("Error: Ya existe una consulta de cliente " + con.cliente);
                    return false;
                }
            }

            consultas.Add(con);
            return true;
        }

        public bool eliminarConsulta(Consulta con)
        {
            foreach (Consulta consulta in this.consultas)
            {
                if ((consulta.cliente == con.cliente ) && (consulta.razon == con.razon))
                {
                    this.consultas.Remove(con);
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo eliminar consulta de cliente " + con.cliente);
            return false;
        }

        public void agregarMascota(Mascota m)
        {
            mascotas.Add(m);
        }

        public bool agregarCliente(Cliente c)
        {
            foreach (Cliente cli in this.clientes)
            {
                if (cli.dni == c.dni)
                {
                    MessageBox.Show("Error: Ya existe un cliente con DNI " + c.dni);
                    return false;
                }
            }
            clientes.Add(c);
            return true;
        }

        public bool eliminarCliente(Cliente c)
        {
            foreach (Cliente cli in this.clientes)
            {
                if (cli.dni == c.dni)
                {
                    this.clientes.Remove(cli);
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo eliminar cliente con DNI " + c.dni);
            return false;
        }

        public bool modificarCliente(Cliente c)
        {
            if (eliminarCliente(c))
            {
                if (agregarCliente(c))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
