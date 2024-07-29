namespace Ferreteria
{
    partial class NuevaFerreteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaFerreteria));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreFerreteria = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la Ferreteria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 94);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefono";
            // 
            // txtNombreFerreteria
            // 
            txtNombreFerreteria.Location = new Point(219, 50);
            txtNombreFerreteria.Name = "txtNombreFerreteria";
            txtNombreFerreteria.Size = new Size(257, 27);
            txtNombreFerreteria.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(219, 94);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(257, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(219, 134);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 27);
            txtTelefono.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(282, 187);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(382, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NuevaFerreteria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 235);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreFerreteria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevaFerreteria";
            Text = "NuevaFerreteria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreFerreteria;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}