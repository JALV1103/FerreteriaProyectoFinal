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
    public partial class FrmFerreterias : Form
    {
        private List<Ferreterias> ferreterias;
        public FrmFerreterias()
        {
            InitializeComponent();
            ferreterias = new List<Ferreterias>();

            ferreterias.Add(new Ferreterias  (1, "Larach", "Tegucigalpa", "78787878"));
            ferreterias.Add(new Ferreterias  (2, "Larach", "Tegucigalpa", "78787878"));
            ferreterias.Add(new Ferreterias  (3, "Larach", "Tegucigalpa", "78787878"));

            this.bindingSrcFerreteria.DataSource = ferreterias;
        }

        private void ActualizarDataGridView()
        {
            dataGridFerreterias.DataSource = null;
            dataGridFerreterias.DataSource = this.ferreterias;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaFerreteria nuevaFerreteria = new NuevaFerreteria();
            nuevaFerreteria.ShowDialog();

            if (nuevaFerreteria.IsConfirmar == true)
            {
                Ferreterias nuevo = new Ferreterias(
                        this.ferreterias.Count + 1,
                        nuevaFerreteria.NombreFerreteria,
                        nuevaFerreteria.Direccion,
                        nuevaFerreteria.Telefono
                    );
                this.ferreterias.Add(nuevo);
            }
            this.bindingSrcFerreteria.DataSource = this.ferreterias;
            ActualizarDataGridView();
            nuevaFerreteria = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridFerreterias.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridFerreterias.SelectedRows[0].Index;
                ferreterias.RemoveAt(rowIndex);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(ferreterias, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }
    }
}
