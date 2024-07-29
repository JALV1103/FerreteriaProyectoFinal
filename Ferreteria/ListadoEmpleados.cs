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
    public partial class ListadoEmpleados : Form
    {
        private List<Trabajador> trabajadores;
        private void ActualizarDataGridView()
        {
            gridEmpleados.DataSource = null;
            gridEmpleados.DataSource = this.trabajadores;
        }
        public ListadoEmpleados()
        {
            InitializeComponent();

            trabajadores = new List<Trabajador>();

            trabajadores.Add(new Trabajador(1, "Jeffry", "Suarez", "001", "Carpinteria"));
            trabajadores.Add(new Trabajador(2, "Josue", "Martinez", "012", "Fontaneria"));
            trabajadores.Add(new Trabajador(3, "Josue", "Caceres", "023", "Electricidad"));
            trabajadores.Add(new Trabajador(4, "Jesus", "Barahona", "015", "Construccion"));

            this.bindingSrc.DataSource = trabajadores;
            ActualizarDataGridView();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.ShowDialog();
            if (agregarEmpleado.IsConfirmar == true)
            {
                Trabajador nuevo = new Trabajador(
                        this.trabajadores.Count + 1,
                        agregarEmpleado.Nombre,
                        agregarEmpleado.Apellido,
                        agregarEmpleado.Numero_de_pago,
                        agregarEmpleado.Area
                    );

                this.trabajadores.Add(nuevo);
            }
            this.bindingSrc.DataSource = this.trabajadores;
            ActualizarDataGridView();
            agregarEmpleado = null;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (gridEmpleados.SelectedRows.Count > 0)
            {
                int rowIndex = gridEmpleados.SelectedRows[0].Index;
                trabajadores.RemoveAt(rowIndex);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(trabajadores, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }
    }
}
