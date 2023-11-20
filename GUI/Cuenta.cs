using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Cuenta : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        List<Usuario> usuarios = new List<Usuario>();
        int pos;
        public Cuenta(int posicion)
        {
            InitializeComponent();
            pos = posicion;
            usuarios = usuarioBLL.ConsultarUsers();
        }

        private void btnActualizarPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAntiguaPassword.Text))
            {
                MessageBox.Show("El campo de Antigua Password no puede estar vacío.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevaPassword.Text))
            {
                MessageBox.Show("El campo de Nueva Password no puede estar vacío.");
                return;
            }

            string antiguaPassword = txtAntiguaPassword.Text;
            string nuevaPassword = txtNuevaPassword.Text;

            if (antiguaPassword == usuarios[pos].clave)
            {
                if (nuevaPassword != antiguaPassword)
                {
                    bool cambioExitoso = usuarioBLL.CambiarContraseña(usuarios[pos].correo, nuevaPassword);
                    if (cambioExitoso)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.");
                        txtAntiguaPassword.Text = "";
                        txtNuevaPassword.Text = "";
                    }
                    else
                    {
                        Console.WriteLine("ERROR.. Hubo un error en el cambio de Contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR... Es la misma Contraseña");
                }
            }
            else
            {
                MessageBox.Show("ERROR... La antigua Contraseña es Incorrecta");
            }
        }
    }
}
