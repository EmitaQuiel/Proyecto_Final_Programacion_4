﻿namespace CapaPresentacion
{
    partial class FormReporteVentas
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
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new Guna.UI.WinForms.GunaDataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_FechaFin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_FechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btn_DescargarExcel = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Busqueda = new Guna.UI.WinForms.GunaTextBox();
            this.Combo_Busqueda = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Buscarpor = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnbuscarreporte = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(1144, 128);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 241;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(1093, 128);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(42, 23);
            this.btnbuscar.TabIndex = 240;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
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
            this.dgvdata.Location = new System.Drawing.Point(11, 224);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(1250, 382);
            this.dgvdata.TabIndex = 243;
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
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento Cliente";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
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
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(354, 67);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel1.TabIndex = 247;
            this.gunaLabel1.Text = "Fecha Fin";
            // 
            // txt_FechaFin
            // 
            this.txt_FechaFin.BackColor = System.Drawing.Color.Transparent;
            this.txt_FechaFin.BaseColor = System.Drawing.Color.White;
            this.txt_FechaFin.BorderColor = System.Drawing.Color.Silver;
            this.txt_FechaFin.CustomFormat = "dd/MM/yyyy";
            this.txt_FechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_FechaFin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FechaFin.ForeColor = System.Drawing.Color.Black;
            this.txt_FechaFin.Location = new System.Drawing.Point(428, 67);
            this.txt_FechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_FechaFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_FechaFin.Name = "txt_FechaFin";
            this.txt_FechaFin.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_FechaFin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaFin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaFin.OnPressedColor = System.Drawing.Color.Black;
            this.txt_FechaFin.Radius = 10;
            this.txt_FechaFin.Size = new System.Drawing.Size(223, 30);
            this.txt_FechaFin.TabIndex = 246;
            this.txt_FechaFin.Text = "viernes, 16 de junio de 2023";
            this.txt_FechaFin.Value = new System.DateTime(2023, 6, 16, 16, 59, 20, 539);
            // 
            // txt_FechaInicio
            // 
            this.txt_FechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.txt_FechaInicio.BaseColor = System.Drawing.Color.White;
            this.txt_FechaInicio.BorderColor = System.Drawing.Color.Silver;
            this.txt_FechaInicio.CustomFormat = "dd/MM/yyyy";
            this.txt_FechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_FechaInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FechaInicio.ForeColor = System.Drawing.Color.Black;
            this.txt_FechaInicio.Location = new System.Drawing.Point(104, 67);
            this.txt_FechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_FechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_FechaInicio.Name = "txt_FechaInicio";
            this.txt_FechaInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_FechaInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FechaInicio.OnPressedColor = System.Drawing.Color.Black;
            this.txt_FechaInicio.Radius = 10;
            this.txt_FechaInicio.Size = new System.Drawing.Size(223, 30);
            this.txt_FechaInicio.TabIndex = 245;
            this.txt_FechaInicio.Text = "viernes, 16 de junio de 2023";
            this.txt_FechaInicio.Value = new System.DateTime(2023, 6, 16, 16, 59, 20, 539);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(28, 67);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 15);
            this.gunaLabel2.TabIndex = 244;
            this.gunaLabel2.Text = "Fecha Inicio";
            // 
            // btn_DescargarExcel
            // 
            this.btn_DescargarExcel.Animated = true;
            this.btn_DescargarExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_DescargarExcel.BorderRadius = 15;
            this.btn_DescargarExcel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_DescargarExcel.CheckedState.Parent = this.btn_DescargarExcel;
            this.btn_DescargarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DescargarExcel.CustomImages.Parent = this.btn_DescargarExcel;
            this.btn_DescargarExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_DescargarExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DescargarExcel.ForeColor = System.Drawing.Color.White;
            this.btn_DescargarExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_DescargarExcel.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_DescargarExcel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_DescargarExcel.HoverState.Parent = this.btn_DescargarExcel;
            this.btn_DescargarExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DescargarExcel.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_DescargarExcel.Location = new System.Drawing.Point(23, 181);
            this.btn_DescargarExcel.Name = "btn_DescargarExcel";
            this.btn_DescargarExcel.ShadowDecoration.Parent = this.btn_DescargarExcel;
            this.btn_DescargarExcel.Size = new System.Drawing.Size(156, 27);
            this.btn_DescargarExcel.TabIndex = 248;
            this.btn_DescargarExcel.Text = "Descargar Excel";
            this.btn_DescargarExcel.Click += new System.EventHandler(this.btn_DescargarExcel_Click);
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.Color.Transparent;
            this.txt_Busqueda.BaseColor = System.Drawing.Color.White;
            this.txt_Busqueda.BorderColor = System.Drawing.Color.Silver;
            this.txt_Busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Busqueda.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Busqueda.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Busqueda.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Busqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Busqueda.Location = new System.Drawing.Point(933, 92);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.PasswordChar = '\0';
            this.txt_Busqueda.Radius = 10;
            this.txt_Busqueda.SelectedText = "";
            this.txt_Busqueda.Size = new System.Drawing.Size(253, 30);
            this.txt_Busqueda.TabIndex = 249;
            // 
            // Combo_Busqueda
            // 
            this.Combo_Busqueda.BackColor = System.Drawing.Color.Transparent;
            this.Combo_Busqueda.BaseColor = System.Drawing.Color.White;
            this.Combo_Busqueda.BorderColor = System.Drawing.Color.Silver;
            this.Combo_Busqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Busqueda.FocusedColor = System.Drawing.Color.Empty;
            this.Combo_Busqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_Busqueda.ForeColor = System.Drawing.Color.Black;
            this.Combo_Busqueda.FormattingEnabled = true;
            this.Combo_Busqueda.Location = new System.Drawing.Point(933, 56);
            this.Combo_Busqueda.Name = "Combo_Busqueda";
            this.Combo_Busqueda.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_Busqueda.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_Busqueda.Radius = 10;
            this.Combo_Busqueda.Size = new System.Drawing.Size(253, 26);
            this.Combo_Busqueda.TabIndex = 250;
            // 
            // lbl_Buscarpor
            // 
            this.lbl_Buscarpor.AutoSize = true;
            this.lbl_Buscarpor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscarpor.Location = new System.Drawing.Point(811, 56);
            this.lbl_Buscarpor.Name = "lbl_Buscarpor";
            this.lbl_Buscarpor.Size = new System.Drawing.Size(102, 25);
            this.lbl_Buscarpor.TabIndex = 251;
            this.lbl_Buscarpor.Text = "Buscar por";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 19);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(192, 30);
            this.gunaLabel3.TabIndex = 252;
            this.gunaLabel3.Text = "Reporte de Ventas";
            // 
            // btnbuscarreporte
            // 
            this.btnbuscarreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarreporte.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarreporte.IconColor = System.Drawing.Color.Black;
            this.btnbuscarreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarreporte.IconSize = 17;
            this.btnbuscarreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarreporte.Location = new System.Drawing.Point(683, 67);
            this.btnbuscarreporte.Name = "btnbuscarreporte";
            this.btnbuscarreporte.Size = new System.Drawing.Size(78, 21);
            this.btnbuscarreporte.TabIndex = 253;
            this.btnbuscarreporte.Text = "Buscar";
            this.btnbuscarreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarreporte.UseVisualStyleBackColor = true;
            this.btnbuscarreporte.Click += new System.EventHandler(this.btnbuscarreporte_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvdata;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1354, 702);
            this.Controls.Add(this.btnbuscarreporte);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.Combo_Busqueda);
            this.Controls.Add(this.lbl_Buscarpor);
            this.Controls.Add(this.btn_DescargarExcel);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_FechaFin);
            this.Controls.Add(this.txt_FechaInicio);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteVentas";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Guna.UI.WinForms.GunaDataGridView dgvdata;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker txt_FechaFin;
        private Guna.UI.WinForms.GunaDateTimePicker txt_FechaInicio;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_DescargarExcel;
        private Guna.UI.WinForms.GunaTextBox txt_Busqueda;
        private Guna.UI.WinForms.GunaComboBox Combo_Busqueda;
        private Guna.UI.WinForms.GunaLabel lbl_Buscarpor;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnbuscarreporte;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}