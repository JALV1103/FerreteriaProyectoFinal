namespace Ferreteria
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            ferreteriasToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentanaToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            mosaicosVerticalesToolStripMenuItem = new ToolStripMenuItem();
            mosaicosHorizToolStripMenuItem = new ToolStripMenuItem();
            cerrarTodoToolStripMenuItem = new ToolStripMenuItem();
            organizarIconosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 1029);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 12, 0);
            statusStrip.Size = new Size(1904, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(54, 20);
            toolStripStatusLabel1.Text = "Estado";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ferreteriasToolStripMenuItem, empleadosToolStripMenuItem, personasToolStripMenuItem });
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(130, 24);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // ferreteriasToolStripMenuItem
            // 
            ferreteriasToolStripMenuItem.Name = "ferreteriasToolStripMenuItem";
            ferreteriasToolStripMenuItem.Size = new Size(166, 26);
            ferreteriasToolStripMenuItem.Text = "Ferreterias";
            ferreteriasToolStripMenuItem.Click += ferreteriasToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(166, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(166, 26);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentanaToolStripMenuItem, cascadaToolStripMenuItem, mosaicosVerticalesToolStripMenuItem, mosaicosHorizToolStripMenuItem, cerrarTodoToolStripMenuItem, organizarIconosToolStripMenuItem });
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(82, 24);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // nuevaVentanaToolStripMenuItem
            // 
            nuevaVentanaToolStripMenuItem.Name = "nuevaVentanaToolStripMenuItem";
            nuevaVentanaToolStripMenuItem.Size = new Size(228, 26);
            nuevaVentanaToolStripMenuItem.Text = "Nueva Ventana";
            nuevaVentanaToolStripMenuItem.Click += nuevaVentanaToolStripMenuItem_Click;
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.Size = new Size(228, 26);
            cascadaToolStripMenuItem.Text = "Cascada";
            cascadaToolStripMenuItem.Click += cascadaToolStripMenuItem_Click;
            // 
            // mosaicosVerticalesToolStripMenuItem
            // 
            mosaicosVerticalesToolStripMenuItem.Name = "mosaicosVerticalesToolStripMenuItem";
            mosaicosVerticalesToolStripMenuItem.Size = new Size(228, 26);
            mosaicosVerticalesToolStripMenuItem.Text = "Mosaicos Vertical";
            mosaicosVerticalesToolStripMenuItem.Click += mosaicosVerticalesToolStripMenuItem_Click;
            // 
            // mosaicosHorizToolStripMenuItem
            // 
            mosaicosHorizToolStripMenuItem.Name = "mosaicosHorizToolStripMenuItem";
            mosaicosHorizToolStripMenuItem.Size = new Size(228, 26);
            mosaicosHorizToolStripMenuItem.Text = "Mosaicos Horizontal";
            mosaicosHorizToolStripMenuItem.Click += mosaicosHorizToolStripMenuItem_Click;
            // 
            // cerrarTodoToolStripMenuItem
            // 
            cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            cerrarTodoToolStripMenuItem.Size = new Size(228, 26);
            cerrarTodoToolStripMenuItem.Text = "Cerrar Todo";
            cerrarTodoToolStripMenuItem.Click += cerrarTodoToolStripMenuItem_Click;
            // 
            // organizarIconosToolStripMenuItem
            // 
            organizarIconosToolStripMenuItem.Name = "organizarIconosToolStripMenuItem";
            organizarIconosToolStripMenuItem.Size = new Size(228, 26);
            organizarIconosToolStripMenuItem.Text = "Organizar Iconos";
            organizarIconosToolStripMenuItem.Click += organizarIconosToolStripMenuItem_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientosToolStripMenuItem, ventanasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 3, 0, 3);
            menuStrip.Size = new Size(1904, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1904, 1055);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Main";
            Text = "Ferretería";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem ferreteriasToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentanaToolStripMenuItem;
        private ToolStripMenuItem cascadaToolStripMenuItem;
        private ToolStripMenuItem mosaicosVerticalesToolStripMenuItem;
        private ToolStripMenuItem mosaicosHorizToolStripMenuItem;
        private ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private ToolStripMenuItem organizarIconosToolStripMenuItem;
        private MenuStrip menuStrip;
    }
}
