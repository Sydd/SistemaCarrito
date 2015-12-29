namespace Vista
{
    partial class GestionMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.gestionDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeCategoriasToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeDescuentosToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(946, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // gestionDeCategoriasToolStripMenuItem
            // 
            this.gestionDeCategoriasToolStripMenuItem.Name = "gestionDeCategoriasToolStripMenuItem";
            this.gestionDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.gestionDeCategoriasToolStripMenuItem.Text = "Gestion de Categorias";
            this.gestionDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCategoriasToolStripMenuItem_Click);
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            this.gestionDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProductosToolStripMenuItem_Click);
            // 
            // gestionDeDescuentosToolStripMenuItem
            // 
            this.gestionDeDescuentosToolStripMenuItem.Name = "gestionDeDescuentosToolStripMenuItem";
            this.gestionDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.gestionDeDescuentosToolStripMenuItem.Text = "Gestion de descuentos";
            this.gestionDeDescuentosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDescuentosToolStripMenuItem_Click);
            // 
            // GestionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 400);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "GestionMain";
            this.Text = "GestionMain";
            this.Load += new System.EventHandler(this.GestionMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDescuentosToolStripMenuItem;
    }
}