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
    public partial class Consultar : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        List<Ingreso> listIngresos = new List<Ingreso>();
        List<Egreso> listEgresos = new List<Egreso>();
        List<Ingreso> ingresosFiltrados = new List<Ingreso>();
        List<Egreso> egresosFiltrados = new List<Egreso>();

        List<Usuario> listUsers = new List<Usuario>();
        int pos;
        public Consultar(int posicion)
        {
            InitializeComponent();
            listUsers = usuarioBLL.ConsultarUsers();
            pos = posicion;
            ActualizarGridView();
        }

        private void ActualizarGridView()
        {
            Tabla.Rows.Clear();
            string tipoFiltro = cmbTipoFiltro.Text;
            string FK = listUsers[pos].correo;

            if (cmbTipoFiltro.SelectedIndex == -1)
            {
                listIngresos = usuarioBLL.ConsultarIngresos(FK);

                if (listIngresos != null)
                {
                    foreach (Ingreso ingreso in listIngresos)
                    {
                        int rowIndex = Tabla.Rows.Add();
                        Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"+ {ingreso.ingreso}";
                        Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = ingreso.asunto;
                        if (ingreso.frecuencia != 0)
                        {
                            Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = ingreso.frecuencia;
                        }
                        Tabla.Rows[rowIndex].Cells["clmFecha"].Value = ingreso.fechaInicio.ToString("dd/MM/yyyy");
                    }
                }

                listEgresos = usuarioBLL.ConsultarEgresos(FK);
                if (listEgresos != null)
                {
                    foreach (Egreso egreso in listEgresos)
                    {
                        int rowIndex = Tabla.Rows.Add();
                        Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"- {egreso.egreso}";
                        Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = egreso.asunto;
                        if (egreso.frecuencia != 0)
                        {
                            Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = egreso.frecuencia;
                        }
                        Tabla.Rows[rowIndex].Cells["clmFecha"].Value = egreso.fechaInicio.ToString("dd/MM/yyyy");
                    }
                }
            }
            if (tipoFiltro == "INGRESOS")
            {
                listIngresos = usuarioBLL.ConsultarIngresos(FK);

                if (listIngresos.Count != 0)
                {
                    foreach (Ingreso ingreso in listIngresos)
                    {
                        int rowIndex = Tabla.Rows.Add();
                        Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"+ {ingreso.ingreso}";
                        Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = ingreso.asunto;
                        if (ingreso.frecuencia != 0)
                        {
                            Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = ingreso.frecuencia;
                        }
                        Tabla.Rows[rowIndex].Cells["clmFecha"].Value = ingreso.fechaInicio.ToString("dd/MM/yyyy");

                    }
                }
                else
                {
                    MessageBox.Show("ERROR... No hay Ingresos Registrados");
                }
            }
            else
            {
                if (tipoFiltro == "EGRESOS")
                {
                    listEgresos = usuarioBLL.ConsultarEgresos(FK);

                    if (listEgresos.Count != 0)
                    {
                        foreach (Egreso egreso in listEgresos)
                        {
                            int rowIndex = Tabla.Rows.Add();
                            Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"- {egreso.egreso}";
                            Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = egreso.asunto;
                            if (egreso.frecuencia != 0)
                            {
                                Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = egreso.frecuencia;
                            }
                            Tabla.Rows[rowIndex].Cells["clmFecha"].Value = egreso.fechaInicio.ToString("dd/MM/yyyy");

                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR... No hay Egresos Registrados");
                    }
                }
            }

        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGridView();
        }

        private void btnConsultarFecha_Click(object sender, EventArgs e)
        {
            Tabla.Rows.Clear();
            string FK = listUsers[pos].correo;
            DateTime FechaInicio = fechaInicio.Value;
            DateTime FechaFinal = fechaFinal.Value;
            ingresosFiltrados = usuarioBLL.FiltrarIngreso(FK, FechaInicio, FechaFinal);
            egresosFiltrados = usuarioBLL.FiltrarEgreso(FK, FechaInicio, FechaFinal);

            if (ingresosFiltrados != null)
            {
                foreach (Ingreso ingreso in ingresosFiltrados)
                {
                    int rowIndex = Tabla.Rows.Add();
                    Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"+ {ingreso.ingreso}";
                    Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = ingreso.asunto;
                    if (ingreso.frecuencia != 0)
                    {
                        Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = ingreso.frecuencia;
                    }
                    Tabla.Rows[rowIndex].Cells["clmFecha"].Value = ingreso.fechaInicio.ToString("dd/MM/yyyy");
                }
            }

            if (egresosFiltrados != null)
            {
                foreach (Egreso egreso in egresosFiltrados)
                {
                    int rowIndex = Tabla.Rows.Add();
                    Tabla.Rows[rowIndex].Cells["clmCantidad"].Value = $"- {egreso.egreso}";
                    Tabla.Rows[rowIndex].Cells["clmAsunto"].Value = egreso.asunto;
                    if (egreso.frecuencia != 0)
                    {
                        Tabla.Rows[rowIndex].Cells["clmFrecuencia"].Value = egreso.frecuencia;
                    }
                    Tabla.Rows[rowIndex].Cells["clmFecha"].Value = egreso.fechaInicio.ToString("dd/MM/yyyy");
                }
            }
        }
    }
}
