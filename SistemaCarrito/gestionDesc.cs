using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladoras;
namespace SistemaCarrito
{
    //Este formulario es la gestion  de descuentos. Carga la lista de categorias 
    // donde se selecionara la categoria a la cual asignarle un descuento.
    public partial class gestionDesc : Form
    {
        controlCate conCat = new controlCate();
        controlDesc conDesc = new controlDesc();

        public gestionDesc()
        {
            InitializeComponent();
        }

        private void gestionDesc_Load(object sender, EventArgs e)
        {
            crearcate();
            actualizar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprobar())
                {
                    conDesc.nuevoDesc(dateDesde.Value, dateHasta.Value, Convert.ToInt32(txtDesc.Text), listCate.SelectedIndex);
                    actualizar();
                }
                else
                    throw new Exception("Error 01:\n Error en la selecion de categoria, descuento o fecha");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void crearcate()
        {
            conCat.nuevaCategoria("Electrodomesticos", "Electrodomesticos de todo tipo: Televisores, lavarropas, etc...");
            conCat.nuevaCategoria("Alimentos", "Alimentos variados");
            conCat.nuevaCategoria("Computacion", "Todo lo relacionado a la informatica: Mouses, Monitores, etc...");
            conCat.nuevaCategoria("Movil", "Celulares, Ipad, Iphone, tecnologia Android, etc...");
        }

        void actualizar()
        {

            listCate.Items.Clear();
            foreach (string i in conCat.listarcategoriaSTRING())
            {
                listCate.Items.Add(i);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = conDesc.getlist();
        }
        bool comprobar()
        {
            bool pasa = true;
            if (dateDesde.Value.DayOfYear >= dateHasta.Value.DayOfYear)
                pasa = false;
            if (Convert.ToInt32(txtDesc.Text) == 0)
                pasa = false;
            if (listCate.SelectedIndex == -1)
                pasa = false;
            return pasa;
        }

    }
}
