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
    public partial class AgregarEmpleado : Form
    {
        private string _nombre;
        private string _apellido;
        private string _numero_de_pago;
        private string _area;
        private bool _isConfirmar;
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Numero_de_pago { get => _numero_de_pago; set => _numero_de_pago = value; }
        public string Area { get => _area; set => _area = value; }
        public bool IsConfirmar { get => _isConfirmar; set => _isConfirmar = value; }



        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            this.Nombre = this.txtNombre.Text;
            this.Apellido = this.txtApellido.Text;
            this.Numero_de_pago = this.txtNpago.Text;
            this.Area = this.txtArea.Text;
            this.IsConfirmar = true;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsConfirmar = false;
            this.Close();
        }
    }
}
