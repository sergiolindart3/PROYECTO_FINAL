using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class Home : Form
    {
        int pos;
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        List<Usuario> usuarios = new List<Usuario>();

        public Home(int posicion)
        {
            InitializeComponent();
            pos = posicion;
            usuarios = usuarioBLL.ConsultarUsers();
            lbBienvenido.Text = $"¡Bienvenido {usuarios[pos].name}!";
            lbSaldo.Text = $"${usuarios[pos].saldo}";
            fechaIngreso.Value = DateTime.Now;
            fechaEgreso.Value = DateTime.Now;
        }

        private void AbrirFormulario(Form formulario)
        {
            Form formExistente = panelHome.Controls.OfType<Home>().FirstOrDefault();

            if (formExistente != null)
            {
                formExistente.Hide();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelHome.Controls.Add(formulario);
            panelHome.Tag = formulario;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void btnCrearIngreso_Click(object sender, EventArgs e)
        {
            string tipoIngreso = cmbTipoIngreso.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(txtCantIngreso.Text))
            {
                MessageBox.Show("El campo de cantidad no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAsuntoIngreso.Text))
            {
                MessageBox.Show("El campo de asunto no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFrecuenciaIngreso.Text) && tipoIngreso == "FIJO")
            {
                MessageBox.Show("El campo de frecuencia no puede estar vacío.");
                return;
            }

            if (usuarios[pos] != null)
            {
                if (tipoIngreso == "FIJO")
                {
                    double cantIngreso = Convert.ToDouble(txtCantIngreso.Text);
                    string asuntoIngreso = txtAsuntoIngreso.Text.ToUpper();
                    int frecuenciaIngreso = Convert.ToInt32(txtFrecuenciaIngreso.Text);
                    DateTime FechaIngreso = fechaIngreso.Value;
                    usuarios[pos].RegistrarIF(cantIngreso, asuntoIngreso, frecuenciaIngreso, FechaIngreso);
                    usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                    string FK = usuarios[pos].correo;
                    Ingreso nuevoIngreso = new Ingreso
                    {
                        ingreso = cantIngreso,
                        asunto = asuntoIngreso,
                        frecuencia = frecuenciaIngreso,
                        fechaInicio = FechaIngreso
                    };
                    bool resultadoGuardar = usuarioBLL.GuardarIngreso(nuevoIngreso, FK);
                    if (!resultadoGuardar)
                    {
                        MessageBox.Show("ERROR... NO SE PUDO REGSTRAR EL INGRESO");
                    }
                    else
                    {
                        MessageBox.Show("REGISTRADO INGRESO FIJO");
                    }
                }
                else
                {
                    if (tipoIngreso == "EVENTUAL")
                    {
                        double cantIngreso = Convert.ToDouble(txtCantIngreso.Text);
                        string asuntoIngreso = txtAsuntoIngreso.Text.ToUpper();
                        DateTime FechaIngreso = fechaIngreso.Value;
                        usuarios[pos].RegistrarIE(cantIngreso, asuntoIngreso, FechaIngreso);
                        usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                        string FK = usuarios[pos].correo;
                        Ingreso nuevoIngreso = new Ingreso
                        {
                            ingreso = cantIngreso,
                            asunto = asuntoIngreso,
                            fechaInicio = FechaIngreso
                        };
                        bool resultadoGuardar = usuarioBLL.GuardarIngreso(nuevoIngreso, FK);
                        if (!resultadoGuardar)
                        {
                            MessageBox.Show("ERROR... NO SE PUDO REGSTRAR EL INGRESO");
                        }
                        else
                        {
                            MessageBox.Show("REGISTRADO INGRESO EVENTUAL");
                        }
                    }
                }
            }
            lbSaldo.Text = $"${usuarios[pos].saldo}";
            cmbTipoIngreso.SelectedIndex = 0;
            txtCantIngreso.Text = "";
            txtAsuntoIngreso.Text = "";
            txtFrecuenciaIngreso.Text = "";
            fechaIngreso.Value = DateTime.Now;
        }

        private void btnCrearEgreso_Click(object sender, EventArgs e)
        {
            string tipoEgreso = cmbTipoEgreso.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(txtCantEgreso.Text))
            {
                MessageBox.Show("El campo de cantidad no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAsuntoEgreso.Text))
            {
                MessageBox.Show("El campo de asunto no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFrecuenciaEgreso.Text) && tipoEgreso == "FIJO")
            {
                MessageBox.Show("El campo de frecuencia no puede estar vacío.");
                return;
            }

            if (usuarios[pos] != null)
            {
                if (tipoEgreso == "FIJO")
                {
                    double cantEgreso = Convert.ToDouble(txtCantEgreso.Text);
                    string asuntoEgreso = txtAsuntoEgreso.Text.ToUpper();
                    int frecuenciaEgreso = Convert.ToInt32(txtFrecuenciaEgreso.Text);
                    DateTime FechaEgreso = fechaEgreso.Value;
                    usuarios[pos].RegistrarEF(cantEgreso, asuntoEgreso, frecuenciaEgreso, FechaEgreso);
                    usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                    string FK = usuarios[pos].correo;
                    Egreso nuevoEgreso = new Egreso
                    {
                        egreso = cantEgreso,
                        asunto = asuntoEgreso,
                        frecuencia = frecuenciaEgreso,
                        fechaInicio = FechaEgreso
                    };
                    bool resultadoGuardar = usuarioBLL.GuardarEgreso(nuevoEgreso, FK);
                    if (!resultadoGuardar)
                    {
                        MessageBox.Show("ERROR... NO SE PUDO REGSTRAR EL EGRESO");
                    }
                    else
                    {
                        MessageBox.Show("REGISTRADO EGRESO FIJO");
                    }
                }
                else
                {
                    if (tipoEgreso == "EVENTUAL")
                    {
                        double cantEgreso = Convert.ToDouble(txtCantEgreso.Text);
                        string asuntoEgreso = txtAsuntoEgreso.Text.ToUpper();
                        DateTime FechaEgreso = fechaEgreso.Value;
                        usuarios[pos].RegistrarEE(cantEgreso, asuntoEgreso, FechaEgreso);
                        usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                        string FK = usuarios[pos].correo;
                        Egreso nuevoEgreso = new Egreso
                        {
                            egreso = cantEgreso,
                            asunto = asuntoEgreso,
                            fechaInicio = FechaEgreso
                        };
                        bool resultadoGuardar = usuarioBLL.GuardarEgreso(nuevoEgreso, FK);
                        if (!resultadoGuardar)
                        {
                            MessageBox.Show("ERROR... NO SE PUDO REGSTRAR EL EGRESO");
                        }
                        else
                        {
                            MessageBox.Show("REGISTRADO EGRESO EVENTUAL");
                        }
                    }
                }
            }

            lbSaldo.Text = $"${usuarios[pos].saldo}";
            cmbTipoEgreso.SelectedIndex = 0;
            txtCantEgreso.Text = "";
            txtAsuntoEgreso.Text = "";
            txtFrecuenciaEgreso.Text = "";
            fechaEgreso.Value = DateTime.Now;
        }

        private void cmbTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoIngreso.SelectedItem != null)
            {
                if (cmbTipoIngreso.SelectedItem.ToString() == "Eventual")
                {
                    txtFrecuenciaIngreso.Enabled = false;
                }
                else
                {
                    txtFrecuenciaIngreso.Enabled = true;
                }
            }
        }

        private void cmbTipoEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEgreso.SelectedItem != null)
            {
                if (cmbTipoEgreso.SelectedItem.ToString() == "Eventual")
                {
                    txtFrecuenciaEgreso.Enabled = false;
                }
                else
                {
                    txtFrecuenciaEgreso.Enabled = true;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultarForm = new Consultar(pos);
            AbrirFormulario(consultarForm);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelHome.Controls)
            {
                if (control is Form)
                {
                    control.Hide();
                }
            }
            this.Show();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Cuenta cuentaForm = new Cuenta(pos);
            AbrirFormulario(cuentaForm);
        }

        private void txtCantIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtFrecuenciaIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCantEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtFrecuenciaEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
