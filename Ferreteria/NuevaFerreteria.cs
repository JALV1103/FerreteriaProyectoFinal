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
    public partial class NuevaFerreteria : Form
    {
        private string _nombreFerreteria;
        private string _direccion;
        private string _telefono;
        private bool _isConfirmar = false;
        public NuevaFerreteria()
        {
            InitializeComponent();
        }

        public string NombreFerreteria { get => _nombreFerreteria; set => _nombreFerreteria = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public bool IsConfirmar { get => _isConfirmar; set => _isConfirmar = value; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.NombreFerreteria = this.txtNombreFerreteria.Text;
            this.Direccion = this.txtDireccion.Text;
            this.Telefono = this.txtTelefono.Text;
            this.IsConfirmar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this._isConfirmar = false;
            this.Close();
        }
    }
}
