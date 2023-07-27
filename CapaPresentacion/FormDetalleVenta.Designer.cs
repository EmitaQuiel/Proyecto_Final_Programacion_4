namespace CapaPresentacion
{
    partial class FormDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DocumentoArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Usuario = new Guna.UI.WinForms.GunaTextBox();
            this.txt_NumeroDocumento = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txt_NombreCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DocCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_TipoDocumento = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Fecha = new Guna.UI.WinForms.GunaTextBox();
            this.txt_MontoTotal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_MontoPago = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_MontoCambio = new Guna.UI.WinForms.GunaTextBox();
            this.dgvdata = new Guna.UI.WinForms.GunaDataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(761, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 21);
            this.btnbuscar.TabIndex = 208;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(845, 14);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(78, 21);
            this.btnborrar.TabIndex = 210;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btndescargar.IconColor = System.Drawing.Color.Black;
            this.btndescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargar.IconSize = 17;
            this.btndescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndescargar.Location = new System.Drawing.Point(789, 194);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(134, 21);
            this.btndescargar.TabIndex = 220;
            this.btndescargar.Text = "Descargar en PDF";
            this.btndescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(19)))));
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox4.Controls.Add(this.txt_DocumentoArchivo);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox4.Controls.Add(this.btndescargar);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox4.Controls.Add(this.txt_Usuario);
            this.gunaGroupBox4.Controls.Add(this.txt_NumeroDocumento);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel11);
            this.gunaGroupBox4.Controls.Add(this.txt_NombreCliente);
            this.gunaGroupBox4.Controls.Add(this.btnbuscar);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel10);
            this.gunaGroupBox4.Controls.Add(this.btnborrar);
            this.gunaGroupBox4.Controls.Add(this.txt_DocCliente);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox4.Controls.Add(this.txt_TipoDocumento);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox4.Controls.Add(this.txt_Fecha);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.Location = new System.Drawing.Point(75, 78);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Radius = 20;
            this.gunaGroupBox4.Size = new System.Drawing.Size(936, 238);
            this.gunaGroupBox4.TabIndex = 221;
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 133);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(185, 21);
            this.gunaLabel3.TabIndex = 201;
            this.gunaLabel3.Text = "Informacion de Cliente";
            // 
            // txt_DocumentoArchivo
            // 
            this.txt_DocumentoArchivo.BackColor = System.Drawing.Color.Transparent;
            this.txt_DocumentoArchivo.BaseColor = System.Drawing.Color.White;
            this.txt_DocumentoArchivo.BorderColor = System.Drawing.Color.Silver;
            this.txt_DocumentoArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DocumentoArchivo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DocumentoArchivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DocumentoArchivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DocumentoArchivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DocumentoArchivo.Location = new System.Drawing.Point(529, 3);
            this.txt_DocumentoArchivo.Name = "txt_DocumentoArchivo";
            this.txt_DocumentoArchivo.PasswordChar = '\0';
            this.txt_DocumentoArchivo.Radius = 10;
            this.txt_DocumentoArchivo.SelectedText = "";
            this.txt_DocumentoArchivo.Size = new System.Drawing.Size(173, 30);
            this.txt_DocumentoArchivo.TabIndex = 200;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(390, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 15);
            this.gunaLabel2.TabIndex = 199;
            this.gunaLabel2.Text = "Numero de Documento";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(476, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(47, 15);
            this.gunaLabel1.TabIndex = 42;
            this.gunaLabel1.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_Usuario.BaseColor = System.Drawing.Color.White;
            this.txt_Usuario.BorderColor = System.Drawing.Color.Silver;
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Usuario.Location = new System.Drawing.Point(475, 64);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PasswordChar = '\0';
            this.txt_Usuario.Radius = 10;
            this.txt_Usuario.SelectedText = "";
            this.txt_Usuario.Size = new System.Drawing.Size(173, 30);
            this.txt_Usuario.TabIndex = 41;
            // 
            // txt_NumeroDocumento
            // 
            this.txt_NumeroDocumento.BaseColor = System.Drawing.Color.White;
            this.txt_NumeroDocumento.BorderColor = System.Drawing.Color.Silver;
            this.txt_NumeroDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NumeroDocumento.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_NumeroDocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_NumeroDocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_NumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NumeroDocumento.Location = new System.Drawing.Point(908, 156);
            this.txt_NumeroDocumento.Name = "txt_NumeroDocumento";
            this.txt_NumeroDocumento.PasswordChar = '\0';
            this.txt_NumeroDocumento.SelectedText = "";
            this.txt_NumeroDocumento.Size = new System.Drawing.Size(25, 30);
            this.txt_NumeroDocumento.TabIndex = 40;
            this.txt_NumeroDocumento.Visible = false;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel11.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel11.TabIndex = 28;
            this.gunaLabel11.Text = "Informacion Venta";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_NombreCliente.BaseColor = System.Drawing.Color.White;
            this.txt_NombreCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_NombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NombreCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_NombreCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_NombreCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_NombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NombreCliente.Location = new System.Drawing.Point(275, 185);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.PasswordChar = '\0';
            this.txt_NombreCliente.Radius = 10;
            this.txt_NombreCliente.SelectedText = "";
            this.txt_NombreCliente.Size = new System.Drawing.Size(173, 30);
            this.txt_NombreCliente.TabIndex = 26;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel10.Location = new System.Drawing.Point(272, 165);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(91, 15);
            this.gunaLabel10.TabIndex = 25;
            this.gunaLabel10.Text = "Nombre Cliente";
            // 
            // txt_DocCliente
            // 
            this.txt_DocCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_DocCliente.BaseColor = System.Drawing.Color.White;
            this.txt_DocCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_DocCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DocCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DocCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DocCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DocCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DocCliente.Location = new System.Drawing.Point(7, 185);
            this.txt_DocCliente.Name = "txt_DocCliente";
            this.txt_DocCliente.PasswordChar = '\0';
            this.txt_DocCliente.Radius = 10;
            this.txt_DocCliente.SelectedText = "";
            this.txt_DocCliente.Size = new System.Drawing.Size(253, 30);
            this.txt_DocCliente.TabIndex = 24;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel8.Location = new System.Drawing.Point(4, 167);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(117, 15);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "Numero Documento";
            // 
            // txt_TipoDocumento
            // 
            this.txt_TipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.txt_TipoDocumento.BaseColor = System.Drawing.Color.White;
            this.txt_TipoDocumento.BorderColor = System.Drawing.Color.Silver;
            this.txt_TipoDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TipoDocumento.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TipoDocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TipoDocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TipoDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TipoDocumento.Location = new System.Drawing.Point(275, 64);
            this.txt_TipoDocumento.Name = "txt_TipoDocumento";
            this.txt_TipoDocumento.PasswordChar = '\0';
            this.txt_TipoDocumento.Radius = 10;
            this.txt_TipoDocumento.SelectedText = "";
            this.txt_TipoDocumento.Size = new System.Drawing.Size(173, 30);
            this.txt_TipoDocumento.TabIndex = 21;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel12.Location = new System.Drawing.Point(4, 46);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel12.TabIndex = 18;
            this.gunaLabel12.Text = "Fecha";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel13.Location = new System.Drawing.Point(272, 46);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(96, 15);
            this.gunaLabel13.TabIndex = 20;
            this.gunaLabel13.Text = "Tipo Documento";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.txt_Fecha.BaseColor = System.Drawing.Color.White;
            this.txt_Fecha.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fecha.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fecha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Fecha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Fecha.Location = new System.Drawing.Point(7, 64);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.PasswordChar = '\0';
            this.txt_Fecha.Radius = 10;
            this.txt_Fecha.SelectedText = "";
            this.txt_Fecha.Size = new System.Drawing.Size(253, 30);
            this.txt_Fecha.TabIndex = 5;
            // 
            // txt_MontoTotal
            // 
            this.txt_MontoTotal.BackColor = System.Drawing.Color.Transparent;
            this.txt_MontoTotal.BaseColor = System.Drawing.Color.White;
            this.txt_MontoTotal.BorderColor = System.Drawing.Color.Silver;
            this.txt_MontoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MontoTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MontoTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MontoTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MontoTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MontoTotal.Location = new System.Drawing.Point(1035, 109);
            this.txt_MontoTotal.Name = "txt_MontoTotal";
            this.txt_MontoTotal.PasswordChar = '\0';
            this.txt_MontoTotal.Radius = 10;
            this.txt_MontoTotal.SelectedText = "";
            this.txt_MontoTotal.Size = new System.Drawing.Size(99, 30);
            this.txt_MontoTotal.TabIndex = 212;
            this.txt_MontoTotal.Text = "0";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.Location = new System.Drawing.Point(1032, 78);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(71, 15);
            this.gunaLabel14.TabIndex = 213;
            this.gunaLabel14.Text = "Monto Total";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel4.Location = new System.Drawing.Point(508, 31);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(143, 30);
            this.gunaLabel4.TabIndex = 222;
            this.gunaLabel4.Text = "Detalle Venta";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(1032, 169);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel5.TabIndex = 214;
            this.gunaLabel5.Text = "Monto Pago";
            // 
            // txt_MontoPago
            // 
            this.txt_MontoPago.BackColor = System.Drawing.Color.Transparent;
            this.txt_MontoPago.BaseColor = System.Drawing.Color.White;
            this.txt_MontoPago.BorderColor = System.Drawing.Color.Silver;
            this.txt_MontoPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MontoPago.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MontoPago.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MontoPago.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MontoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MontoPago.Location = new System.Drawing.Point(1035, 201);
            this.txt_MontoPago.Name = "txt_MontoPago";
            this.txt_MontoPago.PasswordChar = '\0';
            this.txt_MontoPago.Radius = 10;
            this.txt_MontoPago.SelectedText = "";
            this.txt_MontoPago.Size = new System.Drawing.Size(99, 30);
            this.txt_MontoPago.TabIndex = 223;
            this.txt_MontoPago.Text = "0";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(1032, 263);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(88, 15);
            this.gunaLabel6.TabIndex = 224;
            this.gunaLabel6.Text = "Monto Cambio";
            // 
            // txt_MontoCambio
            // 
            this.txt_MontoCambio.BackColor = System.Drawing.Color.Transparent;
            this.txt_MontoCambio.BaseColor = System.Drawing.Color.White;
            this.txt_MontoCambio.BorderColor = System.Drawing.Color.Silver;
            this.txt_MontoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MontoCambio.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MontoCambio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MontoCambio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MontoCambio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MontoCambio.Location = new System.Drawing.Point(1035, 286);
            this.txt_MontoCambio.Name = "txt_MontoCambio";
            this.txt_MontoCambio.PasswordChar = '\0';
            this.txt_MontoCambio.Radius = 10;
            this.txt_MontoCambio.SelectedText = "";
            this.txt_MontoCambio.Size = new System.Drawing.Size(99, 30);
            this.txt_MontoCambio.TabIndex = 225;
            this.txt_MontoCambio.Text = "0";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeight = 21;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvdata.Location = new System.Drawing.Point(120, 355);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(936, 322);
            this.dgvdata.TabIndex = 235;
            this.dgvdata.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepOrange;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdata.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvdata.ThemeStyle.ReadOnly = true;
            this.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvdata.ThemeStyle.RowsStyle.Height = 22;
            this.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            this.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvdata;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1238, 698);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txt_MontoCambio);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txt_MontoPago);
            this.Controls.Add(this.txt_MontoTotal);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel14);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaGroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleVenta";
            this.Text = "frmDetalleVenta";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btndescargar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaTextBox txt_MontoTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_DocumentoArchivo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_Usuario;
        private Guna.UI.WinForms.GunaTextBox txt_NumeroDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txt_NombreCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txt_DocCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txt_TipoDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaTextBox txt_Fecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txt_MontoPago;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txt_MontoCambio;
        private Guna.UI.WinForms.GunaDataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}