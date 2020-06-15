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
    class ConsultaVeterinaia
    {

    }

    [Serializable]
    class ConsultaPeluqueria
    {

    }

    /* Esta es la clase principal que se carga cuando arranca la app
     * y se va actualizando cuando se cargan datos en los formularios 
     */
    [Serializable]
    class Veterinaria
    {
        public List<Mascota> mascotas;
        public List<Cliente> clientes;
        public List<ConsultaVeterinaia> consultasVeterinaria;
        public List<ConsultaPeluqueria> consultasPeluqueria;
        
        public Veterinaria()
        {
            mascotas = new List<Mascota>();
            clientes = new List<Cliente>();
            consultasVeterinaria = new List<ConsultaVeterinaia>();
            consultasPeluqueria = new List<ConsultaPeluqueria>();
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
