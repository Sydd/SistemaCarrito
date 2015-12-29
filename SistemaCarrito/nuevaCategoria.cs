using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class nuevaCategoria : Form
    {
        public string nombre;
        public string descripcion;

        public nuevaCategoria()
        {
            InitializeComponent();
        }

        public nuevaCategoria(string _nombre, string _descripcion)
        {
            InitializeComponent();
            txtNombre.Text = _nombre;
            txtDesc.Text = _descripcion;
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
                descripcion = txtDesc.Text;
            else
                MessageBox.Show("Error: Campo descripcion vacio");
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            else
                MessageBox.Show("Error: Campo nombre vacio");
            if (nombre != null && descripcion != null)
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaCategoria_Load(object sender, EventArgs e)
        {
            nombre = "";
            descripcion = "";
        }


    }
}
