namespace Ferreteria
{
    partial class FrmFerreterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFerreterias));
            btnEliminarContacto = new Button();
            btnNuevoContacto = new Button();
            label1 = new Label();
            dataGridFerreterias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombreFerreteria = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            bindingSrcFerreteria = new BindingSource(components);
            label2 = new Label();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            saveDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridFerreterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrcFerreteria).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarContacto.Location = new Point(864, 492);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(94, 29);
            btnEliminarContacto.TabIndex = 9;
            btnEliminarContacto.Text = "Eliminar";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // btnNuevoContacto
            // 
            btnNuevoContacto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoContacto.Location = new Point(764, 492);
            btnNuevoContacto.Name = "btnNuevoContacto";
            btnNuevoContacto.Size = new Size(94, 29);
            btnNuevoContacto.TabIndex = 8;
            btnNuevoContacto.Text = "Nuevo";
            btnNuevoContacto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, -37);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 6;
            label1.Text = "Contacto de los clientes";
            // 
            // dataGridFerreterias
            // 
            dataGridFerreterias.AllowUserToAddRows = false;
            dataGridFerreterias.AllowUserToDeleteRows = false;
            dataGridFerreterias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridFerreterias.AutoGenerateColumns = false;
            dataGridFerreterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFerreterias.Columns.AddRange(new DataGridViewColumn[] { Id, NombreFerreteria, Direccion, Telefono });
            dataGridFerreterias.DataSource = bindingSrcFerreteria;
            dataGridFerreterias.Location = new Point(33, 60);
            dataGridFerreterias.Name = "dataGridFerreterias";
            dataGridFerreterias.ReadOnly = true;
            dataGridFerreterias.RowHeadersWidth = 51;
            dataGridFerreterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFerreterias.Size = new Size(901, 364);
            dataGridFerreterias.TabIndex = 10;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NombreFerreteria
            // 
            NombreFerreteria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreFerreteria.DataPropertyName = "NombreFerreteria";
            NombreFerreteria.HeaderText = "Ferreteria";
            NombreFerreteria.MinimumWidth = 6;
            NombreFerreteria.Name = "NombreFerreteria";
            NombreFerreteria.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 26);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 11;
            label2.Text = "Ferreterias";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(840, 17);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.Location = new Point(725, 430);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(840, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "planillaFerreterias";
            saveDialog.Filter = "Archivo de Excel 2007+ |*.xlsx";
            // 
            // FrmFerreterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 484);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(dataGridFerreterias);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnNuevoContacto);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFerreterias";
            Text = "FrmFerreterias";
            ((System.ComponentModel.ISupportInitialize)dataGridFerreterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrcFerreteria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarContacto;
        private Button btnNuevoContacto;
        private Label label1;
        private DataGridView dataGridFerreterias;
        private BindingSource bindingSrcFerreteria;
        private Label label2;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreFerreteria;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private SaveFileDialog saveDialog;
    }
}