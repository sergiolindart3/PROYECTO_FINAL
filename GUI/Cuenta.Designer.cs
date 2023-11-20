namespace GUI
{
    partial class Cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta));
            this.panelCuenta = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNuevaPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAntiguaPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnActualizarPass = new Guna.UI2.WinForms.Guna2Button();
            this.elipseCuenta = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panelCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(21, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 31);
            label1.TabIndex = 1;
            label1.Text = "Editar Cuenta";
            // 
            // panelCuenta
            // 
            this.panelCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panelCuenta.Controls.Add(this.txtNuevaPassword);
            this.panelCuenta.Controls.Add(this.txtAntiguaPassword);
            this.panelCuenta.Controls.Add(this.btnActualizarPass);
            this.panelCuenta.Controls.Add(label1);
            this.panelCuenta.Location = new System.Drawing.Point(359, 276);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(596, 307);
            this.panelCuenta.TabIndex = 0;
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.AutoRoundedCorners = true;
            this.txtNuevaPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtNuevaPassword.BorderRadius = 21;
            this.txtNuevaPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevaPassword.DefaultText = "";
            this.txtNuevaPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtNuevaPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNuevaPassword.ForeColor = System.Drawing.Color.White;
            this.txtNuevaPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaPassword.Location = new System.Drawing.Point(27, 155);
            this.txtNuevaPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.PasswordChar = '\0';
            this.txtNuevaPassword.PlaceholderText = "Nueva Contraseña";
            this.txtNuevaPassword.SelectedText = "";
            this.txtNuevaPassword.Size = new System.Drawing.Size(537, 44);
            this.txtNuevaPassword.TabIndex = 18;
            // 
            // txtAntiguaPassword
            // 
            this.txtAntiguaPassword.AutoRoundedCorners = true;
            this.txtAntiguaPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAntiguaPassword.BorderRadius = 21;
            this.txtAntiguaPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAntiguaPassword.DefaultText = "";
            this.txtAntiguaPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAntiguaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAntiguaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAntiguaPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAntiguaPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.txtAntiguaPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAntiguaPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtAntiguaPassword.ForeColor = System.Drawing.Color.White;
            this.txtAntiguaPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAntiguaPassword.Location = new System.Drawing.Point(27, 91);
            this.txtAntiguaPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAntiguaPassword.Name = "txtAntiguaPassword";
            this.txtAntiguaPassword.PasswordChar = '\0';
            this.txtAntiguaPassword.PlaceholderText = "Antigua Contraseña";
            this.txtAntiguaPassword.SelectedText = "";
            this.txtAntiguaPassword.Size = new System.Drawing.Size(537, 44);
            this.txtAntiguaPassword.TabIndex = 17;
            // 
            // btnActualizarPass
            // 
            this.btnActualizarPass.AutoRoundedCorners = true;
            this.btnActualizarPass.BorderRadius = 25;
            this.btnActualizarPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(178)))), ((int)(((byte)(68)))));
            this.btnActualizarPass.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnActualizarPass.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPass.Location = new System.Drawing.Point(377, 224);
            this.btnActualizarPass.Name = "btnActualizarPass";
            this.btnActualizarPass.Size = new System.Drawing.Size(187, 52);
            this.btnActualizarPass.TabIndex = 16;
            this.btnActualizarPass.Text = "Actualizar";
            this.btnActualizarPass.Click += new System.EventHandler(this.btnActualizarPass_Click);
            // 
            // elipseCuenta
            // 
            this.elipseCuenta.BorderRadius = 20;
            this.elipseCuenta.TargetControl = this.panelCuenta;
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1321, 863);
            this.Controls.Add(this.panelCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cuenta";
            this.Text = "Cuenta";
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCuenta;
        private Guna.UI2.WinForms.Guna2Elipse elipseCuenta;
        private Guna.UI2.WinForms.Guna2Button btnActualizarPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevaPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtAntiguaPassword;
    }
}