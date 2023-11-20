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
    public partial class Login : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        int pos;

        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AbrirFormulario(Form formulario)
        {
            Form formExistente = panelLogin.Controls.OfType<Home>().FirstOrDefault();

            if (formExistente != null)
            {
                formExistente.Hide();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(formulario);
            panelLogin.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hpRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register formRegister = new Register();
            AbrirFormulario(formRegister);
            txtCorreoIS.Text = "";
            txtPasswordIS.Text = "";
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            btnOcultar.BringToFront();
            txtPasswordIS.PasswordChar = '\0';
        }

        private void btnOcultar_Click_1(object sender, EventArgs e)
        {
            btnMostrar.BringToFront();
            txtPasswordIS.PasswordChar = '*';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreoIS.Text))
            {
                MessageBox.Show("El campo de E-mail no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordIS.Text))
            {
                MessageBox.Show("El campo de password no puede estar vacío.");
                return;
            }
            string correo = txtCorreoIS.Text;
            string password = txtPasswordIS.Text;

            pos = usuarioBLL.ValidarAcceso(correo, password);
            if (usuarioBLL.ValidarRegistroUser(correo))
            {
                if (pos == -1)
                {
                    MessageBox.Show("ERROR... Clave Incorrecta");
                }
                else
                {
                    Home home = new Home(pos);
                    home.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Correo no registrado, Por favor registrese en la App");
            }
        }
    }
}
