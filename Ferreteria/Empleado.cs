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
using System.Xml.Serialization;


namespace Ferreteria
{
    public partial class Empleado : Form
    {
        private FerreteriaLib.Empleado Empleado1;
        private FerreteriaLib.Empleado Empleado2;
        private FerreteriaLib.Empleado Empleado3;
        private FerreteriaLib.Empleado Empleado4;
        private FerreteriaLib.Empleado Empleado5;
        private FerreteriaLib.Empleado Empleado6;

        public List<FerreteriaLib.Empleado> Empleados;
        public Empleado()
        {
            InitializeComponent();

            Empleados = new List<FerreteriaLib.Empleado>();

            Empleado1 = new FerreteriaLib.Empleado("1 ", "Jose Castro ", " correo@uncorreo.com ", " 96969696 ", "Construccion ");
            Empleado2 = new FerreteriaLib.Empleado(" 2 ", "Maria Moncada ", " correo@uncorreo.com ", " 15151515 ", " Electricidad ");
            Empleado3 = new FerreteriaLib.Empleado(" 3 ", "Emily Cruz ", " correo@uncorreo.com ", " 03030303 ", " Electricidad ");
            Empleado4 = new FerreteriaLib.Empleado(" 4 ", "Juan Perez ", " correo@uncorreo.com ", " 78787878 ", " Fontaneria ");
            Empleado5 = new FerreteriaLib.Empleado(" 5 ", "Wilmer Romero ", " correo@uncorreo.com ", " 65655665 ", " Construccion ");
            Empleado6 = new FerreteriaLib.Empleado(" 6 ", "Hilton Flores ", " correo@uncorreo.com ", " 12121212 ", " Fontaneria ");

            Empleados.Add(Empleado1);
            Empleados.Add(Empleado2);
            Empleados.Add(Empleado3);
            Empleados.Add(Empleado4);
            Empleados.Add(Empleado5);
            Empleados.Add(Empleado6);

            lblEmpleado1.Text = Empleado1.obtenerPerfil();
            lblEmpleado2.Text = Empleado2.obtenerPerfil();
            lblEmpleado3.Text = Empleado2.obtenerPerfil();
            lblEmpleado4.Text = Empleado2.obtenerPerfil();
            lblEmpleado5.Text = Empleado2.obtenerPerfil();
            lblEmpleado6.Text = Empleado2.obtenerPerfil();


        }


        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(Empleados, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

        private void lblEmpleado1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpleado4_Click(object sender, EventArgs e)
        {

        }
    }
}
