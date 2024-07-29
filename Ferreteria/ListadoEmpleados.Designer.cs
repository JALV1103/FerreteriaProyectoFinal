namespace Ferreteria
{
    partial class ListadoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEmpleados));
            label1 = new Label();
            gridEmpleados = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNumero_de_pago = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            bindingSrc = new BindingSource(components);
            saveDialog = new SaveFileDialog();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Listado de Empleados";
            // 
            // gridEmpleados
            // 
            gridEmpleados.AllowUserToAddRows = false;
            gridEmpleados.AllowUserToDeleteRows = false;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colNumero_de_pago, colArea });
            gridEmpleados.Location = new Point(12, 72);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.ReadOnly = true;
            gridEmpleados.RowHeadersWidth = 51;
            gridEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmpleados.Size = new Size(776, 334);
            gridEmpleados.TabIndex = 1;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 145;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellidos";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colNumero_de_pago
            // 
            colNumero_de_pago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNumero_de_pago.DataPropertyName = "Numero_de_Pago";
            colNumero_de_pago.HeaderText = "Numero de pago";
            colNumero_de_pago.MinimumWidth = 6;
            colNumero_de_pago.Name = "colNumero_de_pago";
            colNumero_de_pago.ReadOnly = true;
            // 
            // colArea
            // 
            colArea.DataPropertyName = "Area";
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 144;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(694, 25);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(694, 412);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(594, 412);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // ListadoEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(gridEmpleados);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListadoEmpleados";
            Text = "ListadoEmpleados";
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView gridEmpleados;
        private BindingSource bindingSrc;
        private SaveFileDialog saveDialog;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colNumero_de_pago;
        private DataGridViewTextBoxColumn colArea;
    }
}