using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServidorForms.MainClass;
namespace ServidorForms
{
    public partial class Form_Inicio : Form
    {
        
        public Form_Inicio()
        {
            InitializeComponent();
            txtIP.Text = Iplocal;
            lblExcepcion.Hide();
        }

        
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciarServidor_Click(null,null);
            }
        }

        private void txtPort_Click(object sender, EventArgs e)
        {
         //   if (txtPort.Text == "5000")
            //    txtPort.Text = "";            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            try {
                Puerto = Convert.ToInt32(txtPort.Text); 
                Iplocal = txtIP.Text;
                fs = new Form_Servidor();
                fi.Hide();
                fs.Show();
                lblExcepcion.Hide();
            }
            catch(FormatException ex)
            {
                lblExcepcion.Show();
                lblExcepcion.Text = "Puerto incorrecto.";
                if (txtPort.Text == "")
                    txtPort.Text = "5000";
            }
            catch(Exception ex)
            {
                lblExcepcion.Show();
                lblExcepcion.Text = "Error: " + ex;
            }
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
