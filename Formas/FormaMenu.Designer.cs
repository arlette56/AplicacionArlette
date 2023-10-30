
namespace Aplicacion_Arlette.Formas
{
    partial class FormaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computoPantallasYElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membresiasToolStripMenuItem,
            this.revistaToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.departamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrateToolStripMenuItem});
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(164, 36);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            // 
            // registrateToolStripMenuItem
            // 
            this.registrateToolStripMenuItem.Name = "registrateToolStripMenuItem";
            this.registrateToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.registrateToolStripMenuItem.Text = "Registro";
            this.registrateToolStripMenuItem.Click += new System.EventHandler(this.registrateToolStripMenuItem_Click);
            // 
            // revistaToolStripMenuItem
            // 
            this.revistaToolStripMenuItem.Name = "revistaToolStripMenuItem";
            this.revistaToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.revistaToolStripMenuItem.Text = "Revista";
            this.revistaToolStripMenuItem.Click += new System.EventHandler(this.revistaToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(146, 36);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(167, 36);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computoPantallasYElectronicaToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // computoPantallasYElectronicaToolStripMenuItem
            // 
            this.computoPantallasYElectronicaToolStripMenuItem.Name = "computoPantallasYElectronicaToolStripMenuItem";
            this.computoPantallasYElectronicaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.computoPantallasYElectronicaToolStripMenuItem.Text = "Compras ";
            this.computoPantallasYElectronicaToolStripMenuItem.Click += new System.EventHandler(this.computoPantallasYElectronicaToolStripMenuItem_Click);
            // 
            // FormaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormaMenu";
            this.Text = "FormaMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computoPantallasYElectronicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrateToolStripMenuItem;
    }
}