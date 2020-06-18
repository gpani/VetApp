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

        public bool coincideCon(Cliente c)
        {
            return (this.dni == c.dni);
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
        public int nroConsulta;

        public Consulta (String cl, String mascota, String razon, String estado, String tc, int nc)
        {
            this.cliente = cl;
            this.mascota = mascota;
            this.razon = razon;
            this.estado = estado;
            this.tipoConsulta = tc;
            this.nroConsulta = nc;
        }

        public bool coincideCon(Consulta c)
        {
            return (this.nroConsulta == c.nroConsulta);
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
        public int ultimoNumeroConsulta = 1; /* el numero de consulta siempre se incrementa para evitar duplicados */

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
                if (con.coincideCon(consulta))
                {
                    MessageBox.Show("Error: Ya existe una consulta de cliente con número " + con.nroConsulta);
                    return false;
                }
            }
            con.nroConsulta = this.ultimoNumeroConsulta + 1;
            this.ultimoNumeroConsulta++;
            consultas.Add(con);
            return true;
        }

        public bool eliminarConsulta(Consulta con)
        {
            foreach (Consulta consulta in this.consultas)
            {
                if (consulta.coincideCon(con))
                {
                    this.consultas.Remove(consulta);
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo eliminar consulta de cliente " + con.cliente);
            return false;
        }

        public bool modificarConsulta(Consulta con)
        {
            foreach (Consulta consulta in this.consultas)
            {
                if (con.coincideCon(consulta))
                {
                    consulta.cliente = con.cliente;
                    consulta.mascota = con.mascota;
                    consulta.razon= con.razon;
                    consulta.estado = con.estado;
                    consulta.tipoConsulta = con.tipoConsulta;
                }
            }
            MessageBox.Show("Error: No se pudo modificar la consulta con numero de consulta" + con.nroConsulta);
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
                if (cli.coincideCon(c))
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
                if (cli.coincideCon(c))
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
            foreach (Cliente cli in this.clientes)
            {
                if (cli.coincideCon(c))
                {
                    cli.nombreApellido = c.nombreApellido;
                    cli.edad = c.edad;
                    cli.dni = c.dni;
                    cli.telefono = c.telefono;
                    cli.domicilio = c.domicilio;
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo modificar el cliente con DNI " + c.dni);
            return false;
        }

    }
}