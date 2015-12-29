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
    public partial class Login : Form
    {
        Carrito formCarrito;
        
        public Carrito FormCarrito
        {
            get { return formCarrito; }
            set { formCarrito = value; }
        }
        public Login()
        {
            InitializeComponent();
        }

         private void Login_Load(object sender, EventArgs e)
        {

        }

         private void btnRegistrar_Click(object sender, EventArgs e)
         {
             try
             {
                 if (comprobar(0))
                 {

                 }
             }
             catch (Exception er)
             {
                 MessageBox.Show(er.Message);
             }
         }

         bool comprobar(int x)
         {
             bool comprobacion = true;
             if (x == 0)
             {

                 if (txtNombre.Text.Equals("") || txtPass.Text.Equals("") || txtUser.Text.Equals(""))
                 {
                     lblResponse.Text = "Por favor, no deje espacios en blanco.";
                     return comprobacion = false;
                 }
                 
                 
             }
             else
             {

             }
             return comprobacion;
         }
    }
}
