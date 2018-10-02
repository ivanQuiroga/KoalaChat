using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServidorForms.MainClass;
using static ServidorForms.Servidor.Servidor;
using ServidorForms.Servidor;

namespace ServidorForms
{
    public partial class Form_Servidor : Form
    {
        private string ip, port;
        Servidor.Servidor svr;
        Thread tservidor, tescuchador, tconectado;

        public Form_Servidor()
        {
            
            Control.CheckForIllegalCrossThreadCalls = false;
            svr = new Servidor.Servidor();
            InitializeComponent();
            txtIP.Text = Iplocal;
            txtPort.Text = Puerto.ToString();

            
            tservidor = new Thread(new ThreadStart(svr.Inicio));
            tescuchador = new Thread(new ThreadStart(Delegado));
           
            tservidor.Start();
            tescuchador.Start();

        }

        public void Delegado()
        {
            svr.ResMensaje += new Servidor.Servidor.RecibirMensaje(Escuchador);
        }
        
        public void Escuchador()
        {
            lock(this){
                lstMensajes.Items.Add(svr.Mensaje);
            }
        }

        private void detenerServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            svr.Desconectar();
            fi.Show();
            fs.Close();
        }

        private void btnIniciarServer_Click(object sender, EventArgs e)
        {
            svr.Envia(Nombre+": "+txtMensaje.Text);
            lock(this){
                lstMensajes.Items.Add(Nombre + ": " + txtMensaje.Text);
            }

            txtMensaje.Clear();
        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiarChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstMensajes.Items.Clear();
        }

        private void txtMensaje_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciarServer_Click(null,null);
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fi.Close();
            fs.Close();
            svr.Desconectar();
            Application.Exit();
        }

        private void AddItem(String s)
        {
            lock (this)
            {
             //   if(lstMensajes.Items.IndexOf( lstMensajes.Items.Count-1 )==svr.Aux)
                lstMensajes.Items.Add(s);
            }
        }


    }
}
