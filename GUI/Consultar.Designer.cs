namespace GUI
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.Tabla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.fechaFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.fechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnConsultarFecha = new Guna.UI2.WinForms.Guna2Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(729, 640);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 31);
            label2.TabIndex = 19;
            label2.Text = "Fecha Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(78, 640);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 31);
            label1.TabIndex = 17;
            label1.Text = "Fecha Inicio";
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToAddRows = false;
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.AllowUserToResizeColumns = false;
            this.Tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabla.ColumnHeadersHeight = 40;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCantidad,
            this.clmAsunto,
            this.clmFrecuencia,
            this.clmFecha});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.Tabla.Location = new System.Drawing.Point(75, 199);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4);
            this.Tabla.MultiSelect = false;
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.RowHeadersVisible = false;
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 40;
            this.Tabla.Size = new System.Drawing.Size(1136, 402);
            this.Tabla.TabIndex = 7;
            this.Tabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.Tabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Tabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Tabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Tabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Tabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Tabla.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.Tabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.Tabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.Tabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.Tabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tabla.ThemeStyle.HeaderStyle.Height = 40;
            this.Tabla.ThemeStyle.ReadOnly = true;
            this.Tabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Tabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Tabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Tabla.ThemeStyle.RowsStyle.Height = 40;
            this.Tabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Tabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.FillWeight = 97.4202F;
            this.ClmCantidad.HeaderText = "CANTIDAD";
            this.ClmCantidad.MinimumWidth = 6;
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.ReadOnly = true;
            this.ClmCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmAsunto
            // 
            this.clmAsunto.FillWeight = 135.6498F;
            this.clmAsunto.HeaderText = "ASUNTO";
            this.clmAsunto.MinimumWidth = 6;
            this.clmAsunto.Name = "clmAsunto";
            this.clmAsunto.ReadOnly = true;
            this.clmAsunto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmFrecuencia
            // 
            this.clmFrecuencia.FillWeight = 102.111F;
            this.clmFrecuencia.HeaderText = "FRECUENCIA";
            this.clmFrecuencia.MinimumWidth = 6;
            this.clmFrecuencia.Name = "clmFrecuencia";
            this.clmFrecuencia.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.FillWeight = 118.4088F;
            this.clmFecha.HeaderText = "FECHA INICIO";
            this.clmFecha.MinimumWidth = 6;
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.AutoRoundedCorners = true;
            this.cmbTipoFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.cmbTipoFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoFiltro.BorderRadius = 17;
            this.cmbTipoFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoFiltro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoFiltro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cmbTipoFiltro.ItemHeight = 30;
            this.cmbTipoFiltro.Items.AddRange(new object[] {
            "INGRESOS",
            "EGRESOS"});
            this.cmbTipoFiltro.Location = new System.Drawing.Point(75, 114);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(276, 36);
            this.cmbTipoFiltro.TabIndex = 9;
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.Tabla;
            // 
            // fechaFinal
            // 
            this.fechaFinal.AutoRoundedCorners = true;
            this.fechaFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaFinal.BorderRadius = 25;
            this.fechaFinal.Checked = true;
            this.fechaFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaFinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaFinal.Location = new System.Drawing.Point(876, 629);
            this.fechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(335, 53);
            this.fechaFinal.TabIndex = 18;
            this.fechaFinal.Value = new System.DateTime(2023, 10, 18, 16, 46, 3, 846);
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoRoundedCorners = true;
            this.fechaInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaInicio.BorderRadius = 25;
            this.fechaInicio.Checked = true;
            this.fechaInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaInicio.Location = new System.Drawing.Point(225, 629);
            this.fechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(335, 53);
            this.fechaInicio.TabIndex = 16;
            this.fechaInicio.Value = new System.DateTime(2023, 10, 18, 16, 46, 3, 846);
            // 
            // btnConsultarFecha
            // 
            this.btnConsultarFecha.AutoRoundedCorners = true;
            this.btnConsultarFecha.BorderRadius = 23;
            this.btnConsultarFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.btnConsultarFecha.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnConsultarFecha.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFecha.Location = new System.Drawing.Point(530, 699);
            this.btnConsultarFecha.Name = "btnConsultarFecha";
            this.btnConsultarFecha.Size = new System.Drawing.Size(255, 49);
            this.btnConsultarFecha.TabIndex = 20;
            this.btnConsultarFecha.Text = "Consultar";
            this.btnConsultarFecha.Click += new System.EventHandler(this.btnConsultarFecha_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1321, 863);
            this.Controls.Add(this.btnConsultarFecha);
            this.Controls.Add(label2);
            this.Controls.Add(this.fechaFinal);
            this.Controls.Add(label1);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.cmbTipoFiltro);
            this.Controls.Add(this.Tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAsunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoFiltro;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaFinal;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaInicio;
        private Guna.UI2.WinForms.Guna2Button btnConsultarFecha;
    }
}