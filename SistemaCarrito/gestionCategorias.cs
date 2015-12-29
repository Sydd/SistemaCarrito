using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladoras;
using Vista;
namespace SistemaCarrito
{
    public partial class frmCategoria : Form
    {
        controlCate Categorias;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Categorias = new controlCate();
            actualizarcategorias();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            try
            {

                nuevaCategoria nuevaC = new nuevaCategoria();
                nuevaC.ShowDialog();
                if (nuevaC.nombre != "" || nuevaC.descripcion != "")
                    Categorias.nuevaCategoria(nuevaC.nombre, nuevaC.descripcion);
                actualizarcategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Categorias.borrarporID((int)dataGridView1.CurrentRow.Cells["Id"].Value);
                    actualizarcategorias();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    nuevaCategoria nuevaC = new nuevaCategoria((string)dataGridView1.CurrentRow.Cells["Nombre"].Value, (string)dataGridView1.CurrentRow.Cells["Descripcion"].Value);
                    nuevaC.ShowDialog();
                    if (nuevaC.nombre != "" && nuevaC.descripcion != "")
                        Categorias.editarcategoria((int)dataGridView1.CurrentRow.Cells["Id"].Value,nuevaC.nombre,nuevaC.descripcion);
                    actualizarcategorias();
                }
                else
                {
                    MessageBox.Show("Selecione un item a modificar");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show( er.Message);
            }
        }

        /*
         * Metodos de actualizacion de las listas que se muestran.
         * */

        private void actualizarcategorias()
        {
            databind.DataSource = Categorias.listarcategoria();
            databind.ResetBindings(false);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = databind;
        }




    }
}
