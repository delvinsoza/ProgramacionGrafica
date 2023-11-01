namespace EjemploWindowsForm
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delegadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem,
            this.delegadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem1});
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.tabControlToolStripMenuItem.Text = "contenedores";
            // 
            // tabControlToolStripMenuItem1
            // 
            this.tabControlToolStripMenuItem1.Name = "tabControlToolStripMenuItem1";
            this.tabControlToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tabControlToolStripMenuItem1.Text = "TabControl";
            // 
            // delegadosToolStripMenuItem
            // 
            this.delegadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesCompuestoToolStripMenuItem});
            this.delegadosToolStripMenuItem.Name = "delegadosToolStripMenuItem";
            this.delegadosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.delegadosToolStripMenuItem.Text = "Delegados";
            // 
            // interesCompuestoToolStripMenuItem
            // 
            this.interesCompuestoToolStripMenuItem.Name = "interesCompuestoToolStripMenuItem";
            this.interesCompuestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interesCompuestoToolStripMenuItem.Text = "InteresCompuesto";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Uso de formulario";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem1;
        private ToolStripMenuItem delegadosToolStripMenuItem;
        private ToolStripMenuItem interesCompuestoToolStripMenuItem;
    }
}