using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp
{
    static class Program
    {
        private static Veterinaria Vet;

        public static Veterinaria getVeterinaria()
        {
            return Vet;
        }

        public static void cargarDatos()
        {
            try
            {
                Stream flujoArchivo = File.OpenRead("Veterinaria.bin");
                BinaryFormatter deserializador = new BinaryFormatter();
                Vet = (Veterinaria)deserializador.Deserialize(flujoArchivo);
                flujoArchivo.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("cargarInformacion: " + ex.Message);
                Vet = new Veterinaria();
            }
        }
        public static void guardarInformacion(object sender, EventArgs e)
        {
            Stream flujoArchivo = File.Create("Veterinaria.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujoArchivo, Vet);
            flujoArchivo.Close();
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            cargarDatos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new System.EventHandler(guardarInformacion);
            Application.Run(new frmMain());
        }
    }
}
