using DocumentFormat.OpenXml.Packaging;

namespace Ferreteria
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        //Configuaraciones de la parte de Ventana y Archivo
        private void mosaicosVerticalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mosaicosHorizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

        }

        private void organizarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }


        // Estas serian para mostrar los formularios dentros del mismo

        // Con esto ya incluiriamos la parte de Excel
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEmpleados listadoEmpleados = new ListadoEmpleados();
            listadoEmpleados.MdiParent = this;
            listadoEmpleados.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonas frmPersonas = new FrmPersonas();
            frmPersonas.MdiParent = this;
            frmPersonas.Show();
        }

        private void ferreteriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFerreterias frmFerreterias = new FrmFerreterias();
            frmFerreterias.MdiParent = this;
            frmFerreterias.Show();
        }
    }
}
