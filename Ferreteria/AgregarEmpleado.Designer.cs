namespace Ferreteria
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNpago = new TextBox();
            txtArea = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 0;
            label3.Text = "Numero de Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 0;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(83, 9);
            label5.Name = "label5";
            label5.Size = new Size(265, 30);
            label5.TabIndex = 1;
            label5.Text = "Agregar Nuevo Empleado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(170, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(238, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtNpago
            // 
            txtNpago.Location = new Point(170, 182);
            txtNpago.Name = "txtNpago";
            txtNpago.Size = new Size(238, 27);
            txtNpago.TabIndex = 3;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(170, 226);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(238, 27);
            txtArea.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.Location = new Point(214, 292);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(314, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 345);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtArea);
            Controls.Add(txtNpago);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNpago;
        private TextBox txtArea;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}