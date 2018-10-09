using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOS VIMOS");
            this.Close();
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnCerrar.Text = "AQUI";
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.Text = "Cerrar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEjercicio1.Text.Length > 0)
                this.Text = txtEjercicio1.Text;

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (int.TryParse(txtNumero1.Text, out a) && int.TryParse(txtNumero2.Text, out b))
            {
                lblResult.Text = (a + b).ToString();

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnMayus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMayus.Checked && txtEjer3.Text.Length>0)
            {
                txtEjer3.Text = txtEjer3.Text.ToUpper();
            }
        }

        private void rbtnMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMinus.Checked && txtEjer3.Text.Length > 0)
            {
                txtEjer3.Text = txtEjer3.Text.ToLower();
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            switch(cmbOpcion.SelectedIndex)
            {
                case 0:
                    mensaje = "ganaste una remera";
                    break;
                case 1:
                    mensaje = "Ganaste una bandera";
                    break;
                case 2:
                    mensaje = "No gano nada";
                    break;
                default:
                    mensaje = "ERROR";
                    break;
                
            }
            MessageBox.Show(mensaje);
            cmbOpcion.Text = "Ingrese otra opcion";

        }
    }
}
