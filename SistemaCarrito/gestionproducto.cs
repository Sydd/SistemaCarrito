using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladoras;
namespace Vista
{
    public partial class gestionproducto : Form
    {
        controlproducto control = new controlproducto();
        controlCate Categorias = new controlCate();
        public gestionproducto()
        {
            InitializeComponent();
        }

        bool comprobacion()
        {
            
            if (txtNombre.Text == "") throw new Exception("Cuadro de nombre vacio");
            if (txtPrecio.Text == "") throw new Exception("Cuadro de precio vacio");
            if (comboCate.SelectedIndex == -1) throw new Exception("No has selecionado categoria");
            return true;
        }

        //Metodo para crear categorias por default.
        private void crearcate()
        {
            Categorias.nuevaCategoria("Electrodomesticos", "Electrodomesticos de todo tipo: Televisores, lavarropas, etc...");
            Categorias.nuevaCategoria("Alimentos", "Alimentos variados");
            Categorias.nuevaCategoria("Computacion", "Todo lo relacionado a la informatica: Mouses, Monitores, etc...");
            Categorias.nuevaCategoria("Movil", "Celulares, Ipad, Iphone, tecnologia Android, etc...");
        }
        private void actualizar()
        {
            comboCate.Items.Clear();
            foreach (string _categoria in Categorias.listarcategoriaSTRING())
                comboCate.Items.Add(_categoria);
            dataPro.DataSource = null;
            dataPro.DataSource = control.Lista();
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }
        private void gestionproducto_Load(object sender, EventArgs e)
        {
            crearcate();
            actualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprobacion())
                {
                    
                    string aux = comboCate.Items[comboCate.SelectedIndex].ToString();
                    control.nuevo(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), aux);
                }
                actualizar();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

    }
}
