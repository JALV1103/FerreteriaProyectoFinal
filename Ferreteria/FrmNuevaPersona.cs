using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaLib;

namespace Ferreteria
{
    public partial class FrmNuevaPersona : Form
    {
        private string _name;
        private string _correo;
        private string _direccion;
        private string _telefono;
        private bool _isConfirmar = false;

        public FrmNuevaPersona()
        {
            InitializeComponent();

        }

        public string PersonaName { get => _name; set => _name = value; }
        public string PersonaCorreo { get => _correo; set => _correo = value; }
        public string PersonaDireccion { get => _direccion; set => _direccion = value; }
        public string PersonaTelefono { get => _telefono; set => _telefono = value; }
        public bool IsConfirmar { get => _isConfirmar; set => _isConfirmar = value; }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.PersonaName = this.txtName.Text;
            this.PersonaCorreo = this.txtCorreo.Text;
            this.PersonaDireccion = this.txtDireccion.Text;
            this.PersonaTelefono = this.txtTelefono.Text;
            this.IsConfirmar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsConfirmar = false;
            this.Close();
        }
    }
}
