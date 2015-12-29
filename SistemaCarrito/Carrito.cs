using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladoras;
using Entidades;

namespace Vista
{
    public partial class Carrito : Form
    {
        controlCarrito conCarro = new controlCarrito();
        controlCate conCate = new controlCate();
        controlDesc conDesc = new controlDesc();
        controlproducto conPro = new controlproducto();

        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            crearcate();
            actualizar();
        }

        private void crearcate()
        {
            conCate.nuevaCategoria("Electrodomesticos", "Electrodomesticos de todo tipo: Televisores, lavarropas, etc...");
            conCate.nuevaCategoria("Alimentos", "Alimentos variados");
            conCate.nuevaCategoria("Computacion", "Todo lo relacionado a la informatica: Mouses, Monitores, etc...");
            conCate.nuevaCategoria("Movil", "Celulares, Ipad, Iphone, tecnologia Android, etc...");
            conDesc.nuevoDesc(DateTime.Today, Convert.ToDateTime("10/08/2013"), 20, 1);
            conDesc.nuevoDesc(DateTime.Today, Convert.ToDateTime("10/08/2013"), 15, 2);
            conDesc.nuevoDesc(DateTime.Today, Convert.ToDateTime("10/08/2013"), 50, 0);
            conPro.nuevo("Chocolate", 4, "Alimentos");
            conPro.nuevo("Alfajor", 3, "Alimentos");
            conPro.nuevo("Torta", 12, "Alimentos");
            conPro.nuevo("Budin", 8, "Alimentos");
            conPro.nuevo("Iphone", 500, "Movil");
            conPro.nuevo("Ipad", 1000, "Movil");
            conPro.nuevo("Ipod", 300, "Movil");

        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            BindingSource bind = new BindingSource();
            comboCategoria.DataSource = conCate.listarcategoria();
            comboCategoria.DisplayMember = "Nombre";
            listBox1.DataSource = conDesc.descuentoshoy();
            listBox1.ValueMember = "Nombre";
            if (comboCategoria.SelectedIndex > -1)
            {
                dataProducto.DataSource = conPro.ListaPorCategoria((Categoria)comboCategoria.SelectedItem);
                dataProducto.Columns[0].Visible = false;
                dataProducto.Columns[1].Visible = false;
                dataProducto.Columns[2].Visible = false;
                dataProducto.Columns[4].Width = 58;
            }
            bind.DataSource = conCarro.Items;
            bind.ResetBindings(false);
            dataCarrito.DataSource = null;
            dataCarrito.DataSource = bind;
            lblTotal.Text = "Total: $" + conCarro.total().ToString();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                conCarro.agregarproducto((Producto)dataProducto.CurrentRow.DataBoundItem, Convert.ToInt32(maskedTextBox1.Text));
                actualizar();
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
