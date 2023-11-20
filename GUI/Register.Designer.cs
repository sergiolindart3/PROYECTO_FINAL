namespace GUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panelRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNameR = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMostrar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnOcultar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPasswordR = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtCorreoR = new Guna.UI2.WinForms.Guna2TextBox();
            this.hpIniciarSesion = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panelRegister.Controls.Add(this.txtNameR);
            this.panelRegister.Controls.Add(this.btnMostrar);
            this.panelRegister.Controls.Add(this.btnOcultar);
            this.panelRegister.Controls.Add(this.txtPasswordR);
            this.panelRegister.Controls.Add(this.btnRegistrar);
            this.panelRegister.Controls.Add(this.txtCorreoR);
            this.panelRegister.Controls.Add(this.hpIniciarSesion);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(276, 64);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(437, 410);
            this.panelRegister.TabIndex = 2;
            // 
            // txtNameR
            // 
            this.txtNameR.BorderRadius = 8;
            this.txtNameR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameR.DefaultText = "";
            this.txtNameR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtNameR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameR.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNameR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameR.Location = new System.Drawing.Point(57, 158);
            this.txtNameR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNameR.Name = "txtNameR";
            this.txtNameR.PasswordChar = '\0';
            this.txtNameR.PlaceholderText = "Nombre";
            this.txtNameR.SelectedText = "";
            this.txtNameR.Size = new System.Drawing.Size(322, 39);
            this.txtNameR.TabIndex = 15;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnMostrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnMostrar.Image = global::GUI.Properties.Resources.icons8_ver_24__1_;
            this.btnMostrar.ImageRotate = 0F;
            this.btnMostrar.Location = new System.Drawing.Point(338, 266);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(24, 24);
            this.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnOcultar.Image = global::GUI.Properties.Resources.icons8_ocultar_24;
            this.btnOcultar.ImageRotate = 0F;
            this.btnOcultar.Location = new System.Drawing.Point(338, 266);
            this.btnOcultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(24, 24);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnOcultar.TabIndex = 14;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.BorderRadius = 8;
            this.txtPasswordR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordR.DefaultText = "";
            this.txtPasswordR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtPasswordR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordR.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPasswordR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordR.Location = new System.Drawing.Point(57, 262);
            this.txtPasswordR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.PasswordChar = '*';
            this.txtPasswordR.PlaceholderText = "Password";
            this.txtPasswordR.SelectedText = "";
            this.txtPasswordR.Size = new System.Drawing.Size(322, 39);
            this.txtPasswordR.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 8;
            this.btnRegistrar.BorderThickness = 1;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(57, 326);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(322, 46);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCorreoR
            // 
            this.txtCorreoR.BorderRadius = 8;
            this.txtCorreoR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoR.DefaultText = "";
            this.txtCorreoR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreoR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreoR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtCorreoR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoR.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCorreoR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoR.Location = new System.Drawing.Point(57, 210);
            this.txtCorreoR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCorreoR.Name = "txtCorreoR";
            this.txtCorreoR.PasswordChar = '\0';
            this.txtCorreoR.PlaceholderText = "E-mail";
            this.txtCorreoR.SelectedText = "";
            this.txtCorreoR.Size = new System.Drawing.Size(322, 39);
            this.txtCorreoR.TabIndex = 10;
            // 
            // hpIniciarSesion
            // 
            this.hpIniciarSesion.ActiveLinkColor = System.Drawing.Color.SlateGray;
            this.hpIniciarSesion.AutoSize = true;
            this.hpIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpIniciarSesion.LinkColor = System.Drawing.Color.RoyalBlue;
            this.hpIniciarSesion.Location = new System.Drawing.Point(258, 100);
            this.hpIniciarSesion.Name = "hpIniciarSesion";
            this.hpIniciarSesion.Size = new System.Drawing.Size(110, 23);
            this.hpIniciarSesion.TabIndex = 9;
            this.hpIniciarSesion.TabStop = true;
            this.hpIniciarSesion.Text = "Iniciar Sesión";
            this.hpIniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hpIniciarSesion_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "¿Ya tienes una cuenta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 38F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(268, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = "GO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 38F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wallet";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panelRegister;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(998, 517);
            this.Controls.Add(this.panelRegister);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelRegister;
        private Guna.UI2.WinForms.Guna2PictureBox btnMostrar;
        private Guna.UI2.WinForms.Guna2PictureBox btnOcultar;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordR;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreoR;
        private System.Windows.Forms.LinkLabel hpIniciarSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNameR;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}