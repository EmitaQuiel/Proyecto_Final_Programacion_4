namespace CapaPresentacion
{
    partial class FormRegistroCompras
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
            this.btnregistrar = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Fecha = new Guna.UI.WinForms.GunaTextBox();
            this.Combo_TipoDocumento = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DocumentoProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_IdProducto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.num_Cantidad = new Guna.UI.WinForms.GunaNumeric();
            this.txt_PrecioVenta = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PrecioCompra = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Producto = new Guna.UI.WinForms.GunaTextBox();
            this.btn_BuscarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodigoProducto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Total = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.dgvdata = new Guna.UI.WinForms.GunaDataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_BuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txt_RazonSocial = new Guna.UI.WinForms.GunaTextBox();
            this.txt_IdProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnregistrar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrar.IconSize = 30;
            this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistrar.Location = new System.Drawing.Point(1128, 650);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnregistrar.Size = new System.Drawing.Size(98, 36);
            this.btnregistrar.TabIndex = 203;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 30;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(1131, 373);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(95, 69);
            this.btnagregarproducto.TabIndex = 200;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(19)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.txt_Fecha);
            this.gunaGroupBox1.Controls.Add(this.Combo_TipoDocumento);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(17, 84);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 20;
            this.gunaGroupBox1.Size = new System.Drawing.Size(269, 189);
            this.gunaGroupBox1.TabIndex = 204;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Fecha";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 89);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 15);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "Tipo Documento";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BaseColor = System.Drawing.Color.White;
            this.txt_Fecha.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fecha.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fecha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Fecha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Fecha.Location = new System.Drawing.Point(6, 39);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.PasswordChar = '\0';
            this.txt_Fecha.Radius = 10;
            this.txt_Fecha.SelectedText = "";
            this.txt_Fecha.Size = new System.Drawing.Size(253, 30);
            this.txt_Fecha.TabIndex = 5;
            // 
            // Combo_TipoDocumento
            // 
            this.Combo_TipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.Combo_TipoDocumento.BaseColor = System.Drawing.Color.White;
            this.Combo_TipoDocumento.BorderColor = System.Drawing.Color.Silver;
            this.Combo_TipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_TipoDocumento.FocusedColor = System.Drawing.Color.Empty;
            this.Combo_TipoDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_TipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.Combo_TipoDocumento.FormattingEnabled = true;
            this.Combo_TipoDocumento.Location = new System.Drawing.Point(6, 128);
            this.Combo_TipoDocumento.Name = "Combo_TipoDocumento";
            this.Combo_TipoDocumento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_TipoDocumento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_TipoDocumento.Radius = 10;
            this.Combo_TipoDocumento.Size = new System.Drawing.Size(253, 26);
            this.Combo_TipoDocumento.TabIndex = 19;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(38, 47);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(214, 30);
            this.gunaLabel6.TabIndex = 206;
            this.gunaLabel6.Text = "Informacion compra";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(535, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(183, 30);
            this.gunaLabel1.TabIndex = 205;
            this.gunaLabel1.Text = "Registrar Compra";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(19)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txt_IdProveedor);
            this.gunaGroupBox2.Controls.Add(this.txt_RazonSocial);
            this.gunaGroupBox2.Controls.Add(this.btn_BuscarProveedor);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Controls.Add(this.txt_DocumentoProveedor);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.Location = new System.Drawing.Point(301, 84);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 20;
            this.gunaGroupBox2.Size = new System.Drawing.Size(341, 189);
            this.gunaGroupBox2.TabIndex = 207;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(10, 21);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 15);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Numero Documento";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 89);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel5.TabIndex = 20;
            this.gunaLabel5.Text = "Razon Social";
            // 
            // txt_DocumentoProveedor
            // 
            this.txt_DocumentoProveedor.BaseColor = System.Drawing.Color.White;
            this.txt_DocumentoProveedor.BorderColor = System.Drawing.Color.Silver;
            this.txt_DocumentoProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DocumentoProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DocumentoProveedor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DocumentoProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DocumentoProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DocumentoProveedor.Location = new System.Drawing.Point(13, 39);
            this.txt_DocumentoProveedor.Name = "txt_DocumentoProveedor";
            this.txt_DocumentoProveedor.PasswordChar = '\0';
            this.txt_DocumentoProveedor.Radius = 10;
            this.txt_DocumentoProveedor.SelectedText = "";
            this.txt_DocumentoProveedor.Size = new System.Drawing.Size(253, 30);
            this.txt_DocumentoProveedor.TabIndex = 5;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(350, 47);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(241, 30);
            this.gunaLabel7.TabIndex = 208;
            this.gunaLabel7.Text = "Informacion Proveedor";
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(19)))));
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Controls.Add(this.txt_IdProducto);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel11);
            this.gunaGroupBox4.Controls.Add(this.num_Cantidad);
            this.gunaGroupBox4.Controls.Add(this.txt_PrecioVenta);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel10);
            this.gunaGroupBox4.Controls.Add(this.txt_PrecioCompra);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox4.Controls.Add(this.txt_Producto);
            this.gunaGroupBox4.Controls.Add(this.btn_BuscarProducto);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox4.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox4.Controls.Add(this.txt_CodigoProducto);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.Location = new System.Drawing.Point(668, 84);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Radius = 20;
            this.gunaGroupBox4.Size = new System.Drawing.Size(558, 189);
            this.gunaGroupBox4.TabIndex = 209;
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.BaseColor = System.Drawing.Color.White;
            this.txt_IdProducto.BorderColor = System.Drawing.Color.Silver;
            this.txt_IdProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IdProducto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_IdProducto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_IdProducto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_IdProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IdProducto.Location = new System.Drawing.Point(6, 6);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.PasswordChar = '\0';
            this.txt_IdProducto.Radius = 5;
            this.txt_IdProducto.SelectedText = "";
            this.txt_IdProducto.Size = new System.Drawing.Size(25, 30);
            this.txt_IdProducto.TabIndex = 40;
            this.txt_IdProducto.Visible = false;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(460, 105);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel11.TabIndex = 28;
            this.gunaLabel11.Text = "Cantidad";
            // 
            // num_Cantidad
            // 
            this.num_Cantidad.BaseColor = System.Drawing.Color.White;
            this.num_Cantidad.BorderColor = System.Drawing.Color.Silver;
            this.num_Cantidad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.num_Cantidad.ButtonForeColor = System.Drawing.Color.White;
            this.num_Cantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.num_Cantidad.ForeColor = System.Drawing.Color.Black;
            this.num_Cantidad.Location = new System.Drawing.Point(463, 125);
            this.num_Cantidad.Maximum = ((long)(9999999));
            this.num_Cantidad.Minimum = ((long)(0));
            this.num_Cantidad.Name = "num_Cantidad";
            this.num_Cantidad.Radius = 5;
            this.num_Cantidad.Size = new System.Drawing.Size(75, 30);
            this.num_Cantidad.TabIndex = 27;
            this.num_Cantidad.Text = "gunaNumeric1";
            this.num_Cantidad.Value = ((long)(1));
            // 
            // txt_PrecioVenta
            // 
            this.txt_PrecioVenta.BaseColor = System.Drawing.Color.White;
            this.txt_PrecioVenta.BorderColor = System.Drawing.Color.Silver;
            this.txt_PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrecioVenta.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PrecioVenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PrecioVenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PrecioVenta.Location = new System.Drawing.Point(274, 125);
            this.txt_PrecioVenta.Name = "txt_PrecioVenta";
            this.txt_PrecioVenta.PasswordChar = '\0';
            this.txt_PrecioVenta.Radius = 10;
            this.txt_PrecioVenta.SelectedText = "";
            this.txt_PrecioVenta.Size = new System.Drawing.Size(173, 30);
            this.txt_PrecioVenta.TabIndex = 26;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(271, 105);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel10.TabIndex = 25;
            this.gunaLabel10.Text = "Precio Venta";
            // 
            // txt_PrecioCompra
            // 
            this.txt_PrecioCompra.BaseColor = System.Drawing.Color.White;
            this.txt_PrecioCompra.BorderColor = System.Drawing.Color.Silver;
            this.txt_PrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrecioCompra.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PrecioCompra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PrecioCompra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PrecioCompra.Location = new System.Drawing.Point(6, 125);
            this.txt_PrecioCompra.Name = "txt_PrecioCompra";
            this.txt_PrecioCompra.PasswordChar = '\0';
            this.txt_PrecioCompra.Radius = 10;
            this.txt_PrecioCompra.SelectedText = "";
            this.txt_PrecioCompra.Size = new System.Drawing.Size(253, 30);
            this.txt_PrecioCompra.TabIndex = 24;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(3, 107);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(86, 15);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "Precio Compra";
            // 
            // txt_Producto
            // 
            this.txt_Producto.BaseColor = System.Drawing.Color.White;
            this.txt_Producto.BorderColor = System.Drawing.Color.Silver;
            this.txt_Producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Producto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Producto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Producto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Producto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Producto.Location = new System.Drawing.Point(274, 57);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.PasswordChar = '\0';
            this.txt_Producto.Radius = 10;
            this.txt_Producto.SelectedText = "";
            this.txt_Producto.Size = new System.Drawing.Size(173, 30);
            this.txt_Producto.TabIndex = 21;
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.Animated = true;
            this.btn_BuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarProducto.BorderRadius = 10;
            this.btn_BuscarProducto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_BuscarProducto.CheckedState.Parent = this.btn_BuscarProducto;
            this.btn_BuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProducto.CustomImages.Parent = this.btn_BuscarProducto;
            this.btn_BuscarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_BuscarProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_BuscarProducto.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_BuscarProducto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarProducto.HoverState.Parent = this.btn_BuscarProducto;
            this.btn_BuscarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_BuscarProducto.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_BuscarProducto.Location = new System.Drawing.Point(160, 93);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.ShadowDecoration.Parent = this.btn_BuscarProducto;
            this.btn_BuscarProducto.Size = new System.Drawing.Size(99, 27);
            this.btn_BuscarProducto.TabIndex = 22;
            this.btn_BuscarProducto.Text = "Buscar";
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.Location = new System.Drawing.Point(3, 39);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(117, 15);
            this.gunaLabel12.TabIndex = 18;
            this.gunaLabel12.Text = "Codigo del producto";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.Location = new System.Drawing.Point(271, 39);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel13.TabIndex = 20;
            this.gunaLabel13.Text = "Producto";
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.BaseColor = System.Drawing.Color.White;
            this.txt_CodigoProducto.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodigoProducto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CodigoProducto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodigoProducto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CodigoProducto.Location = new System.Drawing.Point(6, 57);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.PasswordChar = '\0';
            this.txt_CodigoProducto.Radius = 10;
            this.txt_CodigoProducto.SelectedText = "";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(253, 30);
            this.txt_CodigoProducto.TabIndex = 5;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.Location = new System.Drawing.Point(793, 47);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(267, 30);
            this.gunaLabel9.TabIndex = 210;
            this.gunaLabel9.Text = "Informacion del producto";
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.Transparent;
            this.txt_Total.BaseColor = System.Drawing.Color.White;
            this.txt_Total.BorderColor = System.Drawing.Color.Silver;
            this.txt_Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Total.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Total.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Total.Location = new System.Drawing.Point(1131, 323);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.PasswordChar = '\0';
            this.txt_Total.Radius = 10;
            this.txt_Total.SelectedText = "";
            this.txt_Total.Size = new System.Drawing.Size(92, 30);
            this.txt_Total.TabIndex = 211;
            this.txt_Total.Text = "0";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.Location = new System.Drawing.Point(1149, 299);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(74, 15);
            this.gunaLabel14.TabIndex = 212;
            this.gunaLabel14.Text = "Total a pagar";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeight = 21;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
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
            this.dgvdata.Location = new System.Drawing.Point(23, 314);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(1092, 372);
            this.dgvdata.TabIndex = 213;
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
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
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
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            // 
            // btn_BuscarProveedor
            // 
            this.btn_BuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_BuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btn_BuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BuscarProveedor.IconSize = 18;
            this.btn_BuscarProveedor.Location = new System.Drawing.Point(276, 39);
            this.btn_BuscarProveedor.Name = "btn_BuscarProveedor";
            this.btn_BuscarProveedor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_BuscarProveedor.Size = new System.Drawing.Size(49, 30);
            this.btn_BuscarProveedor.TabIndex = 87;
            this.btn_BuscarProveedor.UseVisualStyleBackColor = true;
            this.btn_BuscarProveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.BaseColor = System.Drawing.Color.White;
            this.txt_RazonSocial.BorderColor = System.Drawing.Color.Silver;
            this.txt_RazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RazonSocial.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_RazonSocial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_RazonSocial.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_RazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_RazonSocial.Location = new System.Drawing.Point(13, 128);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.PasswordChar = '\0';
            this.txt_RazonSocial.Radius = 10;
            this.txt_RazonSocial.SelectedText = "";
            this.txt_RazonSocial.Size = new System.Drawing.Size(253, 30);
            this.txt_RazonSocial.TabIndex = 21;
            // 
            // txt_IdProveedor
            // 
            this.txt_IdProveedor.BaseColor = System.Drawing.Color.White;
            this.txt_IdProveedor.BorderColor = System.Drawing.Color.Silver;
            this.txt_IdProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IdProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_IdProveedor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_IdProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_IdProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IdProveedor.Location = new System.Drawing.Point(288, 128);
            this.txt_IdProveedor.Name = "txt_IdProveedor";
            this.txt_IdProveedor.PasswordChar = '\0';
            this.txt_IdProveedor.Radius = 5;
            this.txt_IdProveedor.SelectedText = "";
            this.txt_IdProveedor.Size = new System.Drawing.Size(37, 30);
            this.txt_IdProveedor.TabIndex = 40;
            this.txt_IdProveedor.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvdata;
            // 
            // FormRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1238, 698);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.gunaLabel14);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaGroupBox4);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnagregarproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_Fecha;
        private Guna.UI.WinForms.GunaComboBox Combo_TipoDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txt_DocumentoProveedor;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaTextBox txt_IdProducto;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaNumeric num_Cantidad;
        private Guna.UI.WinForms.GunaTextBox txt_PrecioVenta;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txt_PrecioCompra;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txt_Producto;
        private Guna.UI2.WinForms.Guna2Button btn_BuscarProducto;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaTextBox txt_CodigoProducto;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txt_Total;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaDataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private Guna.UI.WinForms.GunaTextBox txt_IdProveedor;
        private Guna.UI.WinForms.GunaTextBox txt_RazonSocial;
        private FontAwesome.Sharp.IconButton btn_BuscarProveedor;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}