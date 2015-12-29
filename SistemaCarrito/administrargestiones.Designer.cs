namespace Vista
{
    partial class administrargestiones
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.gestionDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeCategoriasToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeDescuentosToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(611, 23);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // gestionDeCategoriasToolStripMenuItem
            // 
            this.gestionDeCategoriasToolStripMenuItem.Name = "gestionDeCategoriasToolStripMenuItem";
            this.gestionDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(132, 19);
            this.gestionDeCategoriasToolStripMenuItem.Text = "Gestion de categorias";
            this.gestionDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCategoriasToolStripMenuItem_Click);
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(132, 19);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de productos";
            this.gestionDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProductosToolStripMenuItem_Click);
            // 
            // gestionDeDescuentosToolStripMenuItem
            // 
            this.gestionDeDescuentosToolStripMenuItem.Name = "gestionDeDescuentosToolStripMenuItem";
            this.gestionDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(138, 19);
            this.gestionDeDescuentosToolStripMenuItem.Text = "Gestion de descuentos";
            // 
            // administrargestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 404);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "administrargestiones";
            this.Text = "administrargestiones";
            this.Load += new System.EventHandler(this.administrargestiones_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDescuentosToolStripMenuItem;
    }
}