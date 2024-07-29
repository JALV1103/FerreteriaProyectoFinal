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
    public partial class FrmPersonas : Form
    {
        private List<Personas> personas;

        public FrmPersonas()
        {
            InitializeComponent();
            personas = new List<Personas>();

            personas.Add(new Personas(1, "Pedro", "correo@gmail.com", "Tegucigalpa", "96969696"));
            personas.Add(new Personas(2, "Juan", "correo@gmail.com", "San Pedro Sula", "14141414"));
            personas.Add(new Personas(3, "Maria", "correo@gmail.com", "Olancho", "85858585"));

            this.bindingSrc.DataSource = personas;
        }

        private void ActualizarDataGridView()
        {
            dataGridPersonas.DataSource = null;
            dataGridPersonas.DataSource = this.personas;
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            FrmNuevaPersona frmNuevaPersona = new FrmNuevaPersona();
            frmNuevaPersona.ShowDialog();

            if (frmNuevaPersona.IsConfirmar == true)
            {
                Personas nuevo = new Personas(
                        this.personas.Count + 1,
                        frmNuevaPersona.PersonaName,
                        frmNuevaPersona.PersonaCorreo,
                        frmNuevaPersona.PersonaDireccion,
                        frmNuevaPersona.PersonaTelefono
                    );
                this.personas.Add(nuevo);
            }
            this.bindingSrc.DataSource = this.personas;
            ActualizarDataGridView();
            frmNuevaPersona = null;
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (dataGridPersonas.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridPersonas.SelectedRows[0].Index;
                personas.RemoveAt(rowIndex);
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
                excel.ExportarListaAExcel(personas, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }
    }
}
