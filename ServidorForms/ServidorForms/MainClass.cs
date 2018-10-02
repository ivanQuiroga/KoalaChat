using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorForms.Servidor;
using System.Net;
using System.Net.Sockets;

namespace ServidorForms
{
    static class MainClass
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static Form_Inicio fi;
        public static Form_Servidor fs;
        private static string iplocal;
        public static String Iplocal { get { return iplocal; } set { iplocal = value; } }

        private static int puerto;
        public static int Puerto { get { return puerto; } set { puerto = value; } }
        private static string nombre;
        public static string Nombre { get { return nombre; } set { nombre = value; } }
        [STAThread]
        static void Main()
        {
            Nombre = "Servidor";
            Puerto = 5000;
            Iplocal = ObtenerIPLocal();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(fi=new Form_Inicio());
            

        }

        public static string ObtenerIPLocal()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            Console.WriteLine(hostName);
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }

    }
}
