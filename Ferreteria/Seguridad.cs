using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Seguridad : Form
    {

        public class Din()
        {
            // Se utiliza Din como directorio acumulable
            public string usuario { get; set; }
            public string contra { get; set; }
        }
        public Seguridad()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Din myDin = new Din();
            myDin.usuario = txtBoxLogin.Text;
            myDin.contra = txtBoxContra.Text;

            // Se procede a condicionar 
            if (myDin.usuario == "Admin" && myDin.contra == "Admin123")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = "";
            txtBoxContra.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
