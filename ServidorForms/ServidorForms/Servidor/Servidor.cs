    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using static ServidorForms.MainClass;
using static ServidorForms.Servidor.Servidor;

namespace ServidorForms.Servidor
{
    public partial class Servidor
    {
        private TcpListener server;
        static public TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint;
        private List<Connection> list = new List<Connection>();

        public delegate void RecibirMensaje();
        public RecibirMensaje ResMensaje;

        public string Mensaje, Aux;

        Connection con;


        private struct Connection
        {
            public NetworkStream stream;
            public StreamReader streamr;
            public StreamWriter streamw;
            public string Nombre;
        }

        public Servidor()
        {
            ipendpoint = new IPEndPoint(IPAddress.Any, Puerto);
        }

        public void Desconectar()
        {
            server.Stop();
            server.Server.Close();
        }

        public void Inicio()
        {
            server = new TcpListener(ipendpoint);
            server.Start();
            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();

                    con = new Connection();
                    con.stream = client.GetStream();
                    con.streamw = new StreamWriter(con.stream);
                    con.Nombre = recibirNombre();
                    list.Add(con);
                    Mensaje = (con.Nombre+" se ha conectado.");
                    ResMensaje();


                    Thread t = new Thread(Escuchar_conexion);

                    t.Start();
                }
                catch { break; }
            }

        }

        public void Envia(String s)
        {
            foreach (Connection c in list)
            {
                try
                {

                    c.streamw.WriteLine(s);
                    Mensaje = s;
                    c.streamw.Flush();
                }
                catch
                {
                    Mensaje = "No hay clientes conectados.";
                    ResMensaje();
                }

            }

        }

        public String recibirNombre()
        {
            Connection hcon = con;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            //Guarda en el byte el streamLeído
            hcon.stream.Read(bytesFrom, 0, bytesFrom.Length);
            //Guarda en string el byte
            dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            //Manda el mensaje hasta que llegue al final de la cadena "$*$"
            return dataFromClient.Substring(0, dataFromClient.IndexOf("$*$"));
        }

        public void Escuchar_conexion()
        {
            Connection hcon = con;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            string cambioNombre = null;
            int index=-1;
            do
            {
                try
                {
                    Mensaje = "";
                    hcon.stream.Read(bytesFrom, 0, bytesFrom.Length);

                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    index = dataFromClient.IndexOf("$*$");
                    if (index!=-1)
                    {
                        cambioNombre = hcon.Nombre;
                        hcon.Nombre= dataFromClient.Substring(0, dataFromClient.IndexOf("$*$"));
                        dataFromClient = cambioNombre + " ahora se llama " + hcon.Nombre;
                        index = -1;
                    }
                    else
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$*!"));

                    foreach (Connection c in list)
                    {
                        try
                        {

                            c.streamw.WriteLine(dataFromClient);
                            Mensaje = dataFromClient;
                            c.streamw.Flush();
                        }
                        catch
                        {
                        }

                    } 
                    ResMensaje();
                }
                catch
                {
                    Mensaje = hcon.Nombre +" se ha desconectado.";
                    ResMensaje();
                    list.Remove(hcon);
                    break;
                }
            } while (true);
        }


    }
}