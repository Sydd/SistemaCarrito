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
    public partial class administrargestiones : Form
    {
       frmCategoria categorias;
       //gestionDesc descuentos;
       gestionproducto producto;
       public administrargestiones()
        {
            InitializeComponent();
        }

        private void gestionDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprobarformulario(categorias))
            {
                categorias = new frmCategoria();
                categorias.MdiParent = this;
                categorias.Show();
            }
            else
            {
                categorias.Activate();
            }
        }
        bool comprobarformulario(Form aux)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (aux.Equals(f))
                    return false;
            }
            return true;
        }
        private void administrargestiones_Load(object sender, EventArgs e)
        {

        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comprobarformulario(producto))
            {
                producto = new gestionproducto();
                producto.MdiParent = this;
                producto.Show();
            }
            else
            {
                producto.Activate();
            }
        }

  

    }
}
