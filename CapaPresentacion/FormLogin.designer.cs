namespace Presentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_Documento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.Picture_Error = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Animated = true;
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.txt_Contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.txt_Contraseña.BorderRadius = 20;
            this.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Contraseña.DefaultText = "Contraseña";
            this.txt_Contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contraseña.DisabledState.Parent = this.txt_Contraseña;
            this.txt_Contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.txt_Contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contraseña.FocusedState.Parent = this.txt_Contraseña;
            this.txt_Contraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contraseña.HoverState.Parent = this.txt_Contraseña;
            this.txt_Contraseña.IconRightSize = new System.Drawing.Size(0, 0);
            this.txt_Contraseña.Location = new System.Drawing.Point(549, 226);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '\0';
            this.txt_Contraseña.PlaceholderText = "";
            this.txt_Contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Contraseña.SelectedText = "";
            this.txt_Contraseña.SelectionStart = 10;
            this.txt_Contraseña.ShadowDecoration.Parent = this.txt_Contraseña;
            this.txt_Contraseña.Size = new System.Drawing.Size(230, 44);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Contraseña_Enter);
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            this.txt_Contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Contraseña_KeyUp);
            this.txt_Contraseña.Leave += new System.EventHandler(this.txt_Contraseña_Leave);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Animated = true;
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.btn_Ingresar.BorderRadius = 20;
            this.btn_Ingresar.CheckedState.Parent = this.btn_Ingresar;
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.CustomImages.Parent = this.btn_Ingresar;
            this.btn_Ingresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(227)))));
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.HoverState.Parent = this.btn_Ingresar;
            this.btn_Ingresar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ingresar.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_Ingresar.Location = new System.Drawing.Point(583, 325);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.ShadowDecoration.Parent = this.btn_Ingresar;
            this.btn_Ingresar.Size = new System.Drawing.Size(162, 44);
            this.btn_Ingresar.TabIndex = 64;
            this.btn_Ingresar.Text = "Iniciar sesion";
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(855, 37);
            this.guna2Panel1.TabIndex = 66;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(768, -3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(43, 40);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(807, -3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(48, 40);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Animated = true;
            this.txt_Documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.txt_Documento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.txt_Documento.BorderRadius = 20;
            this.txt_Documento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Documento.DefaultText = "Nro Documento";
            this.txt_Documento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Documento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Documento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Documento.DisabledState.Parent = this.txt_Documento;
            this.txt_Documento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Documento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.txt_Documento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Documento.FocusedState.Parent = this.txt_Documento;
            this.txt_Documento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Documento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Documento.HoverState.Parent = this.txt_Documento;
            this.txt_Documento.IconRightSize = new System.Drawing.Size(0, 0);
            this.txt_Documento.Location = new System.Drawing.Point(549, 151);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.PasswordChar = '\0';
            this.txt_Documento.PlaceholderText = "";
            this.txt_Documento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Documento.SelectedText = "";
            this.txt_Documento.SelectionStart = 13;
            this.txt_Documento.ShadowDecoration.Parent = this.txt_Documento;
            this.txt_Documento.Size = new System.Drawing.Size(230, 44);
            this.txt_Documento.TabIndex = 68;
            this.txt_Documento.Enter += new System.EventHandler(this.txt_Documento_Enter);
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            this.txt_Documento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Documento_KeyUp);
            this.txt_Documento.Leave += new System.EventHandler(this.txt_Documento_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(215)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(563, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Inicio de Sesión";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(215)))), ((int)(((byte)(209)))));
            this.lbl_Error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Error.Location = new System.Drawing.Point(34, 230);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Error.Size = new System.Drawing.Size(96, 16);
            this.lbl_Error.TabIndex = 70;
            this.lbl_Error.Text = "Error message";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.gunaShadowPanel1.Controls.Add(this.lbl_Error);
            this.gunaShadowPanel1.Controls.Add(this.Picture_Error);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(512, 61);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 20;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(305, 368);
            this.gunaShadowPanel1.TabIndex = 74;
            this.gunaShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // Picture_Error
            // 
            this.Picture_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(76)))), ((int)(((byte)(31)))));
            this.Picture_Error.Image = global::CapaPresentacion.Properties.Resources.Login_Error;
            this.Picture_Error.Location = new System.Drawing.Point(15, 228);
            this.Picture_Error.Name = "Picture_Error";
            this.Picture_Error.Size = new System.Drawing.Size(21, 20);
            this.Picture_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Error.TabIndex = 71;
            this.Picture_Error.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Logo_Principal;
            this.pictureBox3.Location = new System.Drawing.Point(-132, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(492, 177);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.GrupoCharizard;
            this.pictureBox2.Location = new System.Drawing.Point(30, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 371);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(855, 457);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Documento);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_Contraseña;
        private Guna.UI2.WinForms.Guna2Button btn_Ingresar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.PictureBox Picture_Error;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}

