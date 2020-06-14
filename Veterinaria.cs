using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
        String nombreApellido;
        int edad;
        int dni;
        String telefono;
        String domicilio;

        public Cliente(String nombre, int edad, int dni, String telefono, String domicilio)
        {
            this.nombreApellido = nombre;
            this.edad = edad;
            this.dni = dni;
            this.telefono = telefono;
            this.domicilio = domicilio;
        }
    }

    [Serializable]
    class ConsultaVeterinaria
    {
        string nombreApellido;
        string mascota;
        string razon;
        string estado;

        public ConsultaVeterinaria(String nombreApellido, String mascota, String razon, String estado)
        {
            this.nombreApellido = nombreApellido;
            this.mascota = mascota;
            this.razon = razon;
            this.estado = estado;
        }
    }

    [Serializable]
    class ConsultaPeluqueria
    {
        string nombreApellido;
        string mascota;
        string razon;
        string estado;

        public ConsultaPeluqueria(String nombreApellido, String mascota, String razon, String estado)
        {
            this.nombreApellido = nombreApellido;
            this.mascota = mascota;
            this.razon = razon;
            this.estado = estado;
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
        public List<ConsultaVeterinaria> consultasVeterinaria;
        public List<ConsultaPeluqueria> consultasPeluqueria;
        
        public Veterinaria()
        {
            mascotas = new List<Mascota>();
            clientes = new List<Cliente>();
            consultasVeterinaria = new List<ConsultaVeterinaria>();
            consultasPeluqueria = new List<ConsultaPeluqueria>();
        }

        public void agregarMascota(Mascota m)
        {
            mascotas.Add(m);
        }

        public void agregarCliente(Cliente c)
        {
            clientes.Add(c);
        }


    }
}
