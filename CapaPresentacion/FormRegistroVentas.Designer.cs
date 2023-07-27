namespace CapaPresentacion
{
    partial class FormRegistroVentas
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
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.txt_Fecha = new Guna.UI.WinForms.GunaTextBox();
            this.Combo_TipoDocumento = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_NombreCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DocumentoCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Total = new Guna.UI.WinForms.GunaTextBox();
            this.txt_PagaCon = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Cambio = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CodigoProducto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Producto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Precio = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Stock = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.num_Cantidad = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.dgvdata = new Guna.UI.WinForms.GunaDataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 18;
            this.btnbuscarcliente.Location = new System.Drawing.Point(1175, 116);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarcliente.Size = new System.Drawing.Size(51, 26);
            this.btnbuscarcliente.TabIndex = 87;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(1146, 228);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(32, 20);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(238, 231);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(44, 30);
            this.btnbuscarproducto.TabIndex = 2;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 30;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(1083, 264);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(95, 69);
            this.btnagregarproducto.TabIndex = 200;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // btncrearventa
            // 
            this.btncrearventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrearventa.Location = new System.Drawing.Point(1080, 625);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearventa.Size = new System.Drawing.Size(98, 36);
            this.btncrearventa.TabIndex = 208;
            this.btncrearventa.Text = "Crear Venta";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncrearventa.UseVisualStyleBackColor = true;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
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
            this.txt_Fecha.Location = new System.Drawing.Point(50, 116);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.PasswordChar = '\0';
            this.txt_Fecha.Radius = 10;
            this.txt_Fecha.SelectedText = "";
            this.txt_Fecha.Size = new System.Drawing.Size(253, 26);
            this.txt_Fecha.TabIndex = 209;
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
            this.Combo_TipoDocumento.Location = new System.Drawing.Point(334, 116);
            this.Combo_TipoDocumento.Name = "Combo_TipoDocumento";
            this.Combo_TipoDocumento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_TipoDocumento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_TipoDocumento.Radius = 10;
            this.Combo_TipoDocumento.Size = new System.Drawing.Size(253, 26);
            this.Combo_TipoDocumento.TabIndex = 210;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(47, 94);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(41, 17);
            this.gunaLabel2.TabIndex = 211;
            this.gunaLabel2.Text = "Fecha";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(319, 94);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(105, 17);
            this.gunaLabel3.TabIndex = 212;
            this.gunaLabel3.Text = "Tipo Documento";
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
            this.txt_NombreCliente.Location = new System.Drawing.Point(902, 116);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.PasswordChar = '\0';
            this.txt_NombreCliente.Radius = 10;
            this.txt_NombreCliente.SelectedText = "";
            this.txt_NombreCliente.Size = new System.Drawing.Size(253, 26);
            this.txt_NombreCliente.TabIndex = 21;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(619, 94);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(127, 17);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Numero Documento";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(899, 94);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(118, 17);
            this.gunaLabel5.TabIndex = 20;
            this.gunaLabel5.Text = "Nombre Completo";
            // 
            // txt_DocumentoCliente
            // 
            this.txt_DocumentoCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_DocumentoCliente.BaseColor = System.Drawing.Color.White;
            this.txt_DocumentoCliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_DocumentoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DocumentoCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DocumentoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DocumentoCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DocumentoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DocumentoCliente.Location = new System.Drawing.Point(618, 116);
            this.txt_DocumentoCliente.Name = "txt_DocumentoCliente";
            this.txt_DocumentoCliente.PasswordChar = '\0';
            this.txt_DocumentoCliente.Radius = 10;
            this.txt_DocumentoCliente.SelectedText = "";
            this.txt_DocumentoCliente.Size = new System.Drawing.Size(253, 26);
            this.txt_DocumentoCliente.TabIndex = 5;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(46, 62);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel11.TabIndex = 214;
            this.gunaLabel11.Text = "Informacion Venta";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(513, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(162, 30);
            this.gunaLabel1.TabIndex = 215;
            this.gunaLabel1.Text = "Registrar Venta";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(618, 62);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel6.TabIndex = 216;
            this.gunaLabel6.Text = "Informacion Venta";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(1083, 364);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(95, 20);
            this.gunaLabel7.TabIndex = 217;
            this.gunaLabel7.Text = "Total a Pagar";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(1097, 446);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(69, 20);
            this.gunaLabel8.TabIndex = 218;
            this.gunaLabel8.Text = "Paga con";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(1105, 530);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel9.TabIndex = 219;
            this.gunaLabel9.Text = "Cambio";
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
            this.txt_Total.Location = new System.Drawing.Point(1086, 387);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.PasswordChar = '\0';
            this.txt_Total.Radius = 10;
            this.txt_Total.SelectedText = "";
            this.txt_Total.Size = new System.Drawing.Size(92, 30);
            this.txt_Total.TabIndex = 220;
            this.txt_Total.Text = "0";
            // 
            // txt_PagaCon
            // 
            this.txt_PagaCon.BackColor = System.Drawing.Color.Transparent;
            this.txt_PagaCon.BaseColor = System.Drawing.Color.White;
            this.txt_PagaCon.BorderColor = System.Drawing.Color.Silver;
            this.txt_PagaCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PagaCon.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PagaCon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PagaCon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PagaCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PagaCon.Location = new System.Drawing.Point(1086, 470);
            this.txt_PagaCon.Name = "txt_PagaCon";
            this.txt_PagaCon.PasswordChar = '\0';
            this.txt_PagaCon.Radius = 10;
            this.txt_PagaCon.SelectedText = "";
            this.txt_PagaCon.Size = new System.Drawing.Size(92, 30);
            this.txt_PagaCon.TabIndex = 221;
            this.txt_PagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PagaCon_KeyDown);
            this.txt_PagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PagaCon_KeyPress);
            // 
            // txt_Cambio
            // 
            this.txt_Cambio.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cambio.BaseColor = System.Drawing.Color.White;
            this.txt_Cambio.BorderColor = System.Drawing.Color.Silver;
            this.txt_Cambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cambio.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cambio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cambio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cambio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Cambio.Location = new System.Drawing.Point(1086, 553);
            this.txt_Cambio.Name = "txt_Cambio";
            this.txt_Cambio.PasswordChar = '\0';
            this.txt_Cambio.Radius = 10;
            this.txt_Cambio.SelectedText = "";
            this.txt_Cambio.Size = new System.Drawing.Size(92, 30);
            this.txt_Cambio.TabIndex = 222;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.Location = new System.Drawing.Point(46, 204);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(206, 21);
            this.gunaLabel10.TabIndex = 223;
            this.gunaLabel10.Text = "Informacion del Producto";
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.txt_CodigoProducto.BaseColor = System.Drawing.Color.White;
            this.txt_CodigoProducto.BorderColor = System.Drawing.Color.Silver;
            this.txt_CodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CodigoProducto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CodigoProducto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CodigoProducto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CodigoProducto.Location = new System.Drawing.Point(50, 264);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.PasswordChar = '\0';
            this.txt_CodigoProducto.Radius = 10;
            this.txt_CodigoProducto.SelectedText = "";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(253, 30);
            this.txt_CodigoProducto.TabIndex = 224;
            this.txt_CodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CodigoProducto_KeyDown);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(47, 244);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(130, 17);
            this.gunaLabel12.TabIndex = 225;
            this.gunaLabel12.Text = "Codigo del Producto";
            // 
            // txt_Producto
            // 
            this.txt_Producto.BackColor = System.Drawing.Color.Transparent;
            this.txt_Producto.BaseColor = System.Drawing.Color.White;
            this.txt_Producto.BorderColor = System.Drawing.Color.Silver;
            this.txt_Producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Producto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Producto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Producto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Producto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Producto.Location = new System.Drawing.Point(326, 264);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.PasswordChar = '\0';
            this.txt_Producto.Radius = 10;
            this.txt_Producto.SelectedText = "";
            this.txt_Producto.Size = new System.Drawing.Size(173, 30);
            this.txt_Producto.TabIndex = 226;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(323, 244);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(61, 17);
            this.gunaLabel13.TabIndex = 227;
            this.gunaLabel13.Text = "Producto";
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.Color.Transparent;
            this.txt_Precio.BaseColor = System.Drawing.Color.White;
            this.txt_Precio.BorderColor = System.Drawing.Color.Silver;
            this.txt_Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Precio.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Precio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Precio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Precio.Location = new System.Drawing.Point(522, 264);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.PasswordChar = '\0';
            this.txt_Precio.Radius = 10;
            this.txt_Precio.SelectedText = "";
            this.txt_Precio.Size = new System.Drawing.Size(173, 30);
            this.txt_Precio.TabIndex = 228;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.Location = new System.Drawing.Point(515, 243);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(44, 17);
            this.gunaLabel14.TabIndex = 229;
            this.gunaLabel14.Text = "Precio";
            // 
            // txt_Stock
            // 
            this.txt_Stock.BackColor = System.Drawing.Color.Transparent;
            this.txt_Stock.BaseColor = System.Drawing.Color.White;
            this.txt_Stock.BorderColor = System.Drawing.Color.Silver;
            this.txt_Stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Stock.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Stock.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Stock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Stock.Location = new System.Drawing.Point(718, 264);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.PasswordChar = '\0';
            this.txt_Stock.Radius = 10;
            this.txt_Stock.SelectedText = "";
            this.txt_Stock.Size = new System.Drawing.Size(173, 30);
            this.txt_Stock.TabIndex = 230;
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel15.Location = new System.Drawing.Point(715, 243);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(39, 17);
            this.gunaLabel15.TabIndex = 231;
            this.gunaLabel15.Text = "Stock";
            // 
            // num_Cantidad
            // 
            this.num_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.num_Cantidad.BaseColor = System.Drawing.Color.White;
            this.num_Cantidad.BorderColor = System.Drawing.Color.Silver;
            this.num_Cantidad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.num_Cantidad.ButtonForeColor = System.Drawing.Color.White;
            this.num_Cantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.num_Cantidad.ForeColor = System.Drawing.Color.Black;
            this.num_Cantidad.Location = new System.Drawing.Point(931, 264);
            this.num_Cantidad.Maximum = ((long)(9999999));
            this.num_Cantidad.Minimum = ((long)(0));
            this.num_Cantidad.Name = "num_Cantidad";
            this.num_Cantidad.Radius = 10;
            this.num_Cantidad.Size = new System.Drawing.Size(75, 30);
            this.num_Cantidad.TabIndex = 232;
            this.num_Cantidad.Text = "gunaNumeric1";
            this.num_Cantidad.Value = ((long)(1));
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel16.Location = new System.Drawing.Point(928, 243);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(60, 17);
            this.gunaLabel16.TabIndex = 233;
            this.gunaLabel16.Text = "Cantidad";
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
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvdata.Location = new System.Drawing.Point(50, 339);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(956, 322);
            this.dgvdata.TabIndex = 234;
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
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvdata;
            // 
            // FormRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1238, 698);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.gunaLabel16);
            this.Controls.Add(this.num_Cantidad);
            this.Controls.Add(this.gunaLabel15);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.gunaLabel14);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.txt_CodigoProducto);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.txt_Cambio);
            this.Controls.Add(this.txt_PagaCon);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txt_DocumentoCliente);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.Combo_TipoDocumento);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.btnagregarproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private Guna.UI.WinForms.GunaTextBox txt_Fecha;
        private Guna.UI.WinForms.GunaComboBox Combo_TipoDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_NombreCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txt_DocumentoCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txt_Total;
        private Guna.UI.WinForms.GunaTextBox txt_PagaCon;
        private Guna.UI.WinForms.GunaTextBox txt_Cambio;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txt_CodigoProducto;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txt_Producto;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaTextBox txt_Precio;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaTextBox txt_Stock;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaNumeric num_Cantidad;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaDataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}