namespace GUI
{
    partial class Home
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCuenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.elipseHome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseIngreso = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelIngreso = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCrearIngreso = new Guna.UI2.WinForms.Guna2Button();
            this.txtFrecuenciaIngreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsuntoIngreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaIngreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCantIngreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoIngreso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.elipseEgreso = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelEgreso = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCrearEgreso = new Guna.UI2.WinForms.Guna2Button();
            this.txtFrecuenciaEgreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAsuntoEgreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fechaEgreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCantEgreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTipoEgreso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.panelHome = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelIngreso.SuspendLayout();
            this.panelEgreso.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(17, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(156, 31);
            label1.TabIndex = 0;
            label1.Text = "Crear Ingreso";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.White;
            label16.Location = new System.Drawing.Point(17, 11);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(147, 31);
            label16.TabIndex = 0;
            label16.Text = "Crear Egreso";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1547, 30);
            this.panelTop.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageRotate = 0F;
            this.btnMin.Location = new System.Drawing.Point(1489, 6);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(16, 16);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(1516, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.guna2Panel1.Controls.Add(this.btnCuenta);
            this.guna2Panel1.Controls.Add(this.btnSalir);
            this.guna2Panel1.Controls.Add(this.btnConsultar);
            this.guna2Panel1.Controls.Add(this.btnInicio);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(228, 860);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnCuenta
            // 
            this.btnCuenta.AutoRoundedCorners = true;
            this.btnCuenta.BorderRadius = 25;
            this.btnCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnCuenta.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Image = global::GUI.Properties.Resources.user_solid_1;
            this.btnCuenta.Location = new System.Drawing.Point(24, 255);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(177, 52);
            this.btnCuenta.TabIndex = 17;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::GUI.Properties.Resources.right_from_bracket_solid_1;
            this.btnSalir.Location = new System.Drawing.Point(23, 764);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSalir.Size = new System.Drawing.Size(59, 52);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoRoundedCorners = true;
            this.btnConsultar.BorderRadius = 25;
            this.btnConsultar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(23, 182);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(177, 52);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.AutoRoundedCorners = true;
            this.btnInicio.BorderRadius = 25;
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::GUI.Properties.Resources.house_solid_1;
            this.btnInicio.Location = new System.Drawing.Point(23, 112);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(177, 52);
            this.btnInicio.TabIndex = 14;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(147, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 53);
            this.label5.TabIndex = 12;
            this.label5.Text = "GO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 53);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wallet";
            // 
            // elipseHome
            // 
            this.elipseHome.TargetControl = this;
            // 
            // elipseIngreso
            // 
            this.elipseIngreso.BorderRadius = 20;
            this.elipseIngreso.TargetControl = this.panelIngreso;
            // 
            // panelIngreso
            // 
            this.panelIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panelIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panelIngreso.Controls.Add(label1);
            this.panelIngreso.Controls.Add(this.btnCrearIngreso);
            this.panelIngreso.Controls.Add(this.txtFrecuenciaIngreso);
            this.panelIngreso.Controls.Add(this.label9);
            this.panelIngreso.Controls.Add(this.txtAsuntoIngreso);
            this.panelIngreso.Controls.Add(this.label2);
            this.panelIngreso.Controls.Add(this.label10);
            this.panelIngreso.Controls.Add(this.fechaIngreso);
            this.panelIngreso.Controls.Add(this.txtCantIngreso);
            this.panelIngreso.Controls.Add(this.label8);
            this.panelIngreso.Controls.Add(this.cmbTipoIngreso);
            this.panelIngreso.Controls.Add(this.label7);
            this.panelIngreso.Location = new System.Drawing.Point(64, 245);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(577, 574);
            this.panelIngreso.TabIndex = 22;
            // 
            // btnCrearIngreso
            // 
            this.btnCrearIngreso.AutoRoundedCorners = true;
            this.btnCrearIngreso.BorderRadius = 23;
            this.btnCrearIngreso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearIngreso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.btnCrearIngreso.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnCrearIngreso.ForeColor = System.Drawing.Color.White;
            this.btnCrearIngreso.Location = new System.Drawing.Point(149, 498);
            this.btnCrearIngreso.Name = "btnCrearIngreso";
            this.btnCrearIngreso.Size = new System.Drawing.Size(255, 49);
            this.btnCrearIngreso.TabIndex = 19;
            this.btnCrearIngreso.Text = "Crear Ingreso";
            this.btnCrearIngreso.Click += new System.EventHandler(this.btnCrearIngreso_Click);
            // 
            // txtFrecuenciaIngreso
            // 
            this.txtFrecuenciaIngreso.AutoRoundedCorners = true;
            this.txtFrecuenciaIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtFrecuenciaIngreso.BorderRadius = 21;
            this.txtFrecuenciaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrecuenciaIngreso.DefaultText = "";
            this.txtFrecuenciaIngreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrecuenciaIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrecuenciaIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuenciaIngreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuenciaIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtFrecuenciaIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuenciaIngreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFrecuenciaIngreso.ForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaIngreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuenciaIngreso.Location = new System.Drawing.Point(18, 336);
            this.txtFrecuenciaIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrecuenciaIngreso.Name = "txtFrecuenciaIngreso";
            this.txtFrecuenciaIngreso.PasswordChar = '\0';
            this.txtFrecuenciaIngreso.PlaceholderText = "Frecuencia";
            this.txtFrecuenciaIngreso.SelectedText = "";
            this.txtFrecuenciaIngreso.Size = new System.Drawing.Size(537, 44);
            this.txtFrecuenciaIngreso.TabIndex = 16;
            this.txtFrecuenciaIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuenciaIngreso_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label9.Location = new System.Drawing.Point(18, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Frecuencia (Dias)";
            // 
            // txtAsuntoIngreso
            // 
            this.txtAsuntoIngreso.AutoRoundedCorners = true;
            this.txtAsuntoIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAsuntoIngreso.BorderRadius = 21;
            this.txtAsuntoIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsuntoIngreso.DefaultText = "";
            this.txtAsuntoIngreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAsuntoIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAsuntoIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsuntoIngreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsuntoIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAsuntoIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsuntoIngreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtAsuntoIngreso.ForeColor = System.Drawing.Color.White;
            this.txtAsuntoIngreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsuntoIngreso.Location = new System.Drawing.Point(18, 248);
            this.txtAsuntoIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsuntoIngreso.Name = "txtAsuntoIngreso";
            this.txtAsuntoIngreso.PasswordChar = '\0';
            this.txtAsuntoIngreso.PlaceholderText = "Digite el Asunto";
            this.txtAsuntoIngreso.SelectedText = "";
            this.txtAsuntoIngreso.Size = new System.Drawing.Size(537, 44);
            this.txtAsuntoIngreso.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(18, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asunto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label10.Location = new System.Drawing.Point(18, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Fecha";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoRoundedCorners = true;
            this.fechaIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaIngreso.BorderRadius = 21;
            this.fechaIngreso.Checked = true;
            this.fechaIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaIngreso.Location = new System.Drawing.Point(18, 422);
            this.fechaIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaIngreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(537, 44);
            this.fechaIngreso.TabIndex = 11;
            this.fechaIngreso.Value = new System.DateTime(2023, 10, 18, 16, 46, 3, 846);
            // 
            // txtCantIngreso
            // 
            this.txtCantIngreso.AutoRoundedCorners = true;
            this.txtCantIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtCantIngreso.BorderRadius = 21;
            this.txtCantIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantIngreso.DefaultText = "";
            this.txtCantIngreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantIngreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtCantIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantIngreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCantIngreso.ForeColor = System.Drawing.Color.White;
            this.txtCantIngreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantIngreso.Location = new System.Drawing.Point(18, 162);
            this.txtCantIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantIngreso.Name = "txtCantIngreso";
            this.txtCantIngreso.PasswordChar = '\0';
            this.txtCantIngreso.PlaceholderText = "Digite la Cantidad";
            this.txtCantIngreso.SelectedText = "";
            this.txtCantIngreso.Size = new System.Drawing.Size(537, 44);
            this.txtCantIngreso.TabIndex = 10;
            this.txtCantIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantIngreso_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(18, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad";
            // 
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.AutoRoundedCorners = true;
            this.cmbTipoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.cmbTipoIngreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoIngreso.BorderRadius = 17;
            this.cmbTipoIngreso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoIngreso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cmbTipoIngreso.ItemHeight = 30;
            this.cmbTipoIngreso.Items.AddRange(new object[] {
            "Fijo",
            "Eventual"});
            this.cmbTipoIngreso.Location = new System.Drawing.Point(18, 83);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(537, 36);
            this.cmbTipoIngreso.StartIndex = 0;
            this.cmbTipoIngreso.TabIndex = 8;
            this.cmbTipoIngreso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoIngreso_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(18, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo";
            // 
            // elipseEgreso
            // 
            this.elipseEgreso.BorderRadius = 20;
            this.elipseEgreso.TargetControl = this.panelEgreso;
            // 
            // panelEgreso
            // 
            this.panelEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panelEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panelEgreso.Controls.Add(this.btnCrearEgreso);
            this.panelEgreso.Controls.Add(this.txtFrecuenciaEgreso);
            this.panelEgreso.Controls.Add(this.label11);
            this.panelEgreso.Controls.Add(this.txtAsuntoEgreso);
            this.panelEgreso.Controls.Add(this.label12);
            this.panelEgreso.Controls.Add(this.label13);
            this.panelEgreso.Controls.Add(this.fechaEgreso);
            this.panelEgreso.Controls.Add(this.txtCantEgreso);
            this.panelEgreso.Controls.Add(this.label14);
            this.panelEgreso.Controls.Add(this.cmbTipoEgreso);
            this.panelEgreso.Controls.Add(this.label15);
            this.panelEgreso.Controls.Add(label16);
            this.panelEgreso.Location = new System.Drawing.Point(685, 245);
            this.panelEgreso.Name = "panelEgreso";
            this.panelEgreso.Size = new System.Drawing.Size(577, 574);
            this.panelEgreso.TabIndex = 23;
            // 
            // btnCrearEgreso
            // 
            this.btnCrearEgreso.AutoRoundedCorners = true;
            this.btnCrearEgreso.BorderRadius = 23;
            this.btnCrearEgreso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEgreso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEgreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearEgreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.btnCrearEgreso.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnCrearEgreso.ForeColor = System.Drawing.Color.White;
            this.btnCrearEgreso.Location = new System.Drawing.Point(149, 498);
            this.btnCrearEgreso.Name = "btnCrearEgreso";
            this.btnCrearEgreso.Size = new System.Drawing.Size(255, 49);
            this.btnCrearEgreso.TabIndex = 19;
            this.btnCrearEgreso.Text = "Crear Egreso";
            this.btnCrearEgreso.Click += new System.EventHandler(this.btnCrearEgreso_Click);
            // 
            // txtFrecuenciaEgreso
            // 
            this.txtFrecuenciaEgreso.AutoRoundedCorners = true;
            this.txtFrecuenciaEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtFrecuenciaEgreso.BorderRadius = 21;
            this.txtFrecuenciaEgreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrecuenciaEgreso.DefaultText = "";
            this.txtFrecuenciaEgreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrecuenciaEgreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrecuenciaEgreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuenciaEgreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuenciaEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtFrecuenciaEgreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuenciaEgreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFrecuenciaEgreso.ForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaEgreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuenciaEgreso.Location = new System.Drawing.Point(18, 336);
            this.txtFrecuenciaEgreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrecuenciaEgreso.Name = "txtFrecuenciaEgreso";
            this.txtFrecuenciaEgreso.PasswordChar = '\0';
            this.txtFrecuenciaEgreso.PlaceholderText = "Frecuencia";
            this.txtFrecuenciaEgreso.SelectedText = "";
            this.txtFrecuenciaEgreso.Size = new System.Drawing.Size(537, 44);
            this.txtFrecuenciaEgreso.TabIndex = 16;
            this.txtFrecuenciaEgreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuenciaEgreso_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label11.Location = new System.Drawing.Point(18, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "Frecuencia (Dias)";
            // 
            // txtAsuntoEgreso
            // 
            this.txtAsuntoEgreso.AutoRoundedCorners = true;
            this.txtAsuntoEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAsuntoEgreso.BorderRadius = 21;
            this.txtAsuntoEgreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsuntoEgreso.DefaultText = "";
            this.txtAsuntoEgreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAsuntoEgreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAsuntoEgreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsuntoEgreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsuntoEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAsuntoEgreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsuntoEgreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtAsuntoEgreso.ForeColor = System.Drawing.Color.White;
            this.txtAsuntoEgreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsuntoEgreso.Location = new System.Drawing.Point(18, 248);
            this.txtAsuntoEgreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsuntoEgreso.Name = "txtAsuntoEgreso";
            this.txtAsuntoEgreso.PasswordChar = '\0';
            this.txtAsuntoEgreso.PlaceholderText = "Digite el Asunto";
            this.txtAsuntoEgreso.SelectedText = "";
            this.txtAsuntoEgreso.Size = new System.Drawing.Size(537, 44);
            this.txtAsuntoEgreso.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label12.Location = new System.Drawing.Point(18, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "Asunto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label13.Location = new System.Drawing.Point(18, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fecha";
            // 
            // fechaEgreso
            // 
            this.fechaEgreso.AutoRoundedCorners = true;
            this.fechaEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaEgreso.BorderRadius = 21;
            this.fechaEgreso.Checked = true;
            this.fechaEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.fechaEgreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.fechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaEgreso.Location = new System.Drawing.Point(18, 422);
            this.fechaEgreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaEgreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaEgreso.Name = "fechaEgreso";
            this.fechaEgreso.Size = new System.Drawing.Size(537, 44);
            this.fechaEgreso.TabIndex = 11;
            this.fechaEgreso.Value = new System.DateTime(2023, 10, 18, 16, 46, 3, 846);
            // 
            // txtCantEgreso
            // 
            this.txtCantEgreso.AutoRoundedCorners = true;
            this.txtCantEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtCantEgreso.BorderRadius = 21;
            this.txtCantEgreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantEgreso.DefaultText = "";
            this.txtCantEgreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantEgreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantEgreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantEgreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtCantEgreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantEgreso.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCantEgreso.ForeColor = System.Drawing.Color.White;
            this.txtCantEgreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantEgreso.Location = new System.Drawing.Point(18, 162);
            this.txtCantEgreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantEgreso.Name = "txtCantEgreso";
            this.txtCantEgreso.PasswordChar = '\0';
            this.txtCantEgreso.PlaceholderText = "Digite la Cantidad";
            this.txtCantEgreso.SelectedText = "";
            this.txtCantEgreso.Size = new System.Drawing.Size(537, 44);
            this.txtCantEgreso.TabIndex = 10;
            this.txtCantEgreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantEgreso_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label14.Location = new System.Drawing.Point(18, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 28);
            this.label14.TabIndex = 9;
            this.label14.Text = "Cantidad";
            // 
            // cmbTipoEgreso
            // 
            this.cmbTipoEgreso.AutoRoundedCorners = true;
            this.cmbTipoEgreso.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoEgreso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoEgreso.BorderRadius = 17;
            this.cmbTipoEgreso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEgreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cmbTipoEgreso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoEgreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoEgreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cmbTipoEgreso.ItemHeight = 30;
            this.cmbTipoEgreso.Items.AddRange(new object[] {
            "Fijo",
            "Eventual"});
            this.cmbTipoEgreso.Location = new System.Drawing.Point(18, 83);
            this.cmbTipoEgreso.Name = "cmbTipoEgreso";
            this.cmbTipoEgreso.Size = new System.Drawing.Size(537, 36);
            this.cmbTipoEgreso.StartIndex = 0;
            this.cmbTipoEgreso.TabIndex = 8;
            this.cmbTipoEgreso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEgreso_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label15.Location = new System.Drawing.Point(18, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 28);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(74, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 45);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cantidad Total";
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lbBienvenido.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.ForeColor = System.Drawing.Color.White;
            this.lbBienvenido.Location = new System.Drawing.Point(55, 22);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(0, 54);
            this.lbBienvenido.TabIndex = 26;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lbSaldo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.ForeColor = System.Drawing.Color.White;
            this.lbSaldo.Location = new System.Drawing.Point(73, 149);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 54);
            this.lbSaldo.TabIndex = 27;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.lbSaldo);
            this.panelHome.Controls.Add(this.lbBienvenido);
            this.panelHome.Controls.Add(this.panelIngreso);
            this.panelHome.Controls.Add(this.panelEgreso);
            this.panelHome.Location = new System.Drawing.Point(223, 27);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1321, 863);
            this.panelHome.TabIndex = 28;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1547, 890);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelIngreso.ResumeLayout(false);
            this.panelIngreso.PerformLayout();
            this.panelEgreso.ResumeLayout(false);
            this.panelEgreso.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2PictureBox btnMin;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2CircleButton btnSalir;
        private Guna.UI2.WinForms.Guna2Elipse elipseHome;
        private Guna.UI2.WinForms.Guna2Elipse elipseIngreso;
        private Guna.UI2.WinForms.Guna2Elipse elipseEgreso;
        private Guna.UI2.WinForms.Guna2Button btnCuenta;
        private Guna.UI2.WinForms.Guna2Panel panelIngreso;
        private Guna.UI2.WinForms.Guna2Button btnCrearIngreso;
        private Guna.UI2.WinForms.Guna2TextBox txtFrecuenciaIngreso;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAsuntoIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaIngreso;
        private Guna.UI2.WinForms.Guna2TextBox txtCantIngreso;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoIngreso;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel panelEgreso;
        private Guna.UI2.WinForms.Guna2Button btnCrearEgreso;
        private Guna.UI2.WinForms.Guna2TextBox txtFrecuenciaEgreso;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtAsuntoEgreso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaEgreso;
        private Guna.UI2.WinForms.Guna2TextBox txtCantEgreso;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoEgreso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label lbSaldo;
        private Guna.UI2.WinForms.Guna2Panel panelHome;
    }
}