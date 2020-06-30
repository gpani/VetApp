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
        public String nombre;
        public String raza;
        public int edad;
        public Cliente duenno;
        public float peso;

        public Mascota(String nombre, String raza, int edad, Cliente duenno, float peso)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.duenno = duenno;
            this.peso = peso;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public bool coincideCon(Mascota m)
        {
            return ((this.nombre == m.nombre) && (this.duenno.coincideCon(m.duenno)));
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
        public Cliente cliente;
        public Mascota mascota;
        public string razon;
        public string estado;
        public string tipoConsulta;
        public int nroConsulta;

        public Consulta (Cliente cl, Mascota mascota, String razon, String estado, String tc, int nc)
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

        public override string ToString()
        {
            return this.nroConsulta.ToString();
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
            consultas.Add(con);
            this.ultimoNumeroConsulta++;
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
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo modificar la consulta con numero de consulta " + con.nroConsulta);
            return false;
        }

        public bool agregarMascota(Mascota m)
        {
            foreach(Mascota mascota in this.mascotas)
            {
                if (m.coincideCon(mascota))
                {
                    MessageBox.Show("Error: Ya existe una mascota " + m.nombre + " de " + m.duenno.nombreApellido );
                    return false;
                }
            }
            mascotas.Add(m);
            return true;
        }

        public bool eliminarMascota(Mascota m)
        {
            foreach (Mascota mascota in this.mascotas)
            {
                if (mascota.coincideCon(m))
                {
                    this.mascotas.Remove(mascota);
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo eliminar mascota " + m.nombre);
            return false;
        }

        public bool modificarMascota(Mascota m)
        {
            foreach (Mascota mascota in this.mascotas)
            {
                if (m.coincideCon(mascota))
                {
                    mascota.nombre = m.nombre;
                    mascota.edad = m.edad;
                    mascota.raza = m.raza;
                    mascota.peso = m.peso;
                    mascota.duenno = m.duenno;
                    return true;
                }
            }
            MessageBox.Show("Error: No se pudo modificar la mascota " + m.nombre);
            return false;
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