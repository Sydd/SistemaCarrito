using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaCarrito;
namespace Vista
{
    public partial class GestionMain : Form
    {
        frmCategoria FormCategorias;
        gestionDesc FormDescuentos;
        gestionproducto FormProductos;
        public GestionMain()
        {
            InitializeComponent();
        }

        private void gestionDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!comprobar(FormCategorias))
            {
                FormCategorias = new frmCategoria();
                FormCategorias.MdiParent = this;
                FormCategorias.Show();
            }
            else
            {
                FormCategorias.Activate();
            }
        }
        private void GestionMain_Load(object sender, EventArgs e)
        {

        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!comprobar(FormProductos))
            {
                FormProductos = new gestionproducto();
                FormProductos.MdiParent = this;
                FormProductos.Show();
                FormProductos.Activate();
            }
            else
            {
                FormProductos.Activate();
            }
        }

        private void gestionDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!comprobar(FormDescuentos))
            {
                FormDescuentos = new gestionDesc();
                FormDescuentos.MdiParent = this;
                FormDescuentos.Show();
                FormDescuentos.Activate();
            }
            else
            {
                FormDescuentos.Activate();
            } 
        }
        bool comprobar(Form form)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Equals(form)) return true;
            return false;
        }


    }
}
