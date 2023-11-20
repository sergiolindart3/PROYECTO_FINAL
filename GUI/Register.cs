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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Xml.Linq;

namespace GUI
{
    public partial class Register : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        public Register()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnOcultar.BringToFront();
            txtPasswordR.PasswordChar = '\0';
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            btnMostrar.BringToFront();
            txtPasswordR.PasswordChar = '*';
        }

        private void hpIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login formPrincipal = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (formPrincipal != null)
            {
                formPrincipal.BringToFront();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameR.Text))
            {
                MessageBox.Show("El campo de nombre no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoR.Text))
            {
                MessageBox.Show("El campo de E-mail no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordR.Text))
            {
                MessageBox.Show("El campo de password no puede estar vacío.");
                return;
            }
            string name = txtNameR.Text;
            string correo = txtCorreoR.Text;
            string password = txtPasswordR.Text;
            double saldo = 0;

            Usuario nuevoUsuario = new Usuario
            {
                name = name,
                correo = correo,
                clave = password,
                saldo = saldo
            };

            if (usuarioBLL.ValidarRegistroUser(correo))
            {
                MessageBox.Show("YA EXISTE UN CORREO ASI");
            }
            else
            {
                string resultadoGuardar = usuarioBLL.GuardarUser(nuevoUsuario);
                MessageBox.Show(resultadoGuardar);
                txtNameR.Text = "";
                txtCorreoR.Text = "";
                txtPasswordR.Text = "";
            }
        }
    }
}
