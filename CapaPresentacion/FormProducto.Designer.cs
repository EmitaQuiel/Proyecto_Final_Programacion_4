namespace CapaPresentacion
{
    partial class FormProducto
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
            this.SubPanelUsuario = new Guna.UI.WinForms.GunaPanel();
            this.txt_Indice = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Guardar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Id = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Combo_Estado = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Estado = new Guna.UI.WinForms.GunaLabel();
            this.Combo_Categoria = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_Descripcion = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Nombre = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Codigo = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_Descripcion = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Nombre = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Codigo = new Guna.UI.WinForms.GunaLabel();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Limpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Buscar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Busqueda = new Guna.UI.WinForms.GunaTextBox();
            this.Combo_Busqueda = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Buscarpor = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dgvdata = new Guna.UI.WinForms.GunaDataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubPanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubPanelUsuario
            // 
            this.SubPanelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(13)))));
            this.SubPanelUsuario.Controls.Add(this.txt_Indice);
            this.SubPanelUsuario.Controls.Add(this.btn_Editar);
            this.SubPanelUsuario.Controls.Add(this.btn_Eliminar);
            this.SubPanelUsuario.Controls.Add(this.btn_Guardar);
            this.SubPanelUsuario.Controls.Add(this.txt_Id);
            this.SubPanelUsuario.Controls.Add(this.gunaLabel1);
            this.SubPanelUsuario.Controls.Add(this.Combo_Estado);
            this.SubPanelUsuario.Controls.Add(this.lbl_Estado);
            this.SubPanelUsuario.Controls.Add(this.Combo_Categoria);
            this.SubPanelUsuario.Controls.Add(this.lbl_Categoria);
            this.SubPanelUsuario.Controls.Add(this.txt_Descripcion);
            this.SubPanelUsuario.Controls.Add(this.txt_Nombre);
            this.SubPanelUsuario.Controls.Add(this.txt_Codigo);
            this.SubPanelUsuario.Controls.Add(this.lbl_Descripcion);
            this.SubPanelUsuario.Controls.Add(this.lbl_Nombre);
            this.SubPanelUsuario.Controls.Add(this.lbl_Codigo);
            this.SubPanelUsuario.Location = new System.Drawing.Point(0, 0);
            this.SubPanelUsuario.Name = "SubPanelUsuario";
            this.SubPanelUsuario.Size = new System.Drawing.Size(317, 712);
            this.SubPanelUsuario.TabIndex = 210;
            // 
            // txt_Indice
            // 
            this.txt_Indice.BaseColor = System.Drawing.Color.White;
            this.txt_Indice.BorderColor = System.Drawing.Color.Silver;
            this.txt_Indice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Indice.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Indice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Indice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Indice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Indice.Location = new System.Drawing.Point(226, 55);
            this.txt_Indice.Name = "txt_Indice";
            this.txt_Indice.PasswordChar = '\0';
            this.txt_Indice.SelectedText = "";
            this.txt_Indice.Size = new System.Drawing.Size(25, 30);
            this.txt_Indice.TabIndex = 22;
            this.txt_Indice.Text = "-1";
            this.txt_Indice.Visible = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Animated = true;
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(13)))));
            this.btn_Editar.BorderRadius = 15;
            this.btn_Editar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Editar.CheckedState.Parent = this.btn_Editar;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.CustomImages.Parent = this.btn_Editar;
            this.btn_Editar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Editar.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.HoverState.Parent = this.btn_Editar;
            this.btn_Editar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Editar.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Editar.Location = new System.Drawing.Point(48, 439);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.ShadowDecoration.Parent = this.btn_Editar;
            this.btn_Editar.Size = new System.Drawing.Size(210, 45);
            this.btn_Editar.TabIndex = 21;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Animated = true;
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(13)))));
            this.btn_Eliminar.BorderRadius = 15;
            this.btn_Eliminar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Eliminar.CheckedState.Parent = this.btn_Eliminar;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.CustomImages.Parent = this.btn_Eliminar;
            this.btn_Eliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Eliminar.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Eliminar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.HoverState.Parent = this.btn_Eliminar;
            this.btn_Eliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Eliminar.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Eliminar.Location = new System.Drawing.Point(48, 511);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.ShadowDecoration.Parent = this.btn_Eliminar;
            this.btn_Eliminar.Size = new System.Drawing.Size(210, 45);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Animated = true;
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(13)))));
            this.btn_Guardar.BorderRadius = 15;
            this.btn_Guardar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Guardar.CheckedState.Parent = this.btn_Guardar;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.CustomImages.Parent = this.btn_Guardar;
            this.btn_Guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Guardar.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Guardar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.HoverState.Parent = this.btn_Guardar;
            this.btn_Guardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Guardar.Location = new System.Drawing.Point(48, 367);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.ShadowDecoration.Parent = this.btn_Guardar;
            this.btn_Guardar.Size = new System.Drawing.Size(210, 45);
            this.btn_Guardar.TabIndex = 19;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.BaseColor = System.Drawing.Color.White;
            this.txt_Id.BorderColor = System.Drawing.Color.Silver;
            this.txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Id.Location = new System.Drawing.Point(257, 55);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.PasswordChar = '\0';
            this.txt_Id.SelectedText = "";
            this.txt_Id.Size = new System.Drawing.Size(25, 30);
            this.txt_Id.TabIndex = 18;
            this.txt_Id.Text = "0";
            this.txt_Id.Visible = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(168, 30);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Detalle Producto";
            // 
            // Combo_Estado
            // 
            this.Combo_Estado.BackColor = System.Drawing.Color.Transparent;
            this.Combo_Estado.BaseColor = System.Drawing.Color.White;
            this.Combo_Estado.BorderColor = System.Drawing.Color.Silver;
            this.Combo_Estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Estado.FocusedColor = System.Drawing.Color.Empty;
            this.Combo_Estado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_Estado.ForeColor = System.Drawing.Color.Black;
            this.Combo_Estado.FormattingEnabled = true;
            this.Combo_Estado.Location = new System.Drawing.Point(29, 309);
            this.Combo_Estado.Name = "Combo_Estado";
            this.Combo_Estado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_Estado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_Estado.Radius = 10;
            this.Combo_Estado.Size = new System.Drawing.Size(253, 26);
            this.Combo_Estado.TabIndex = 13;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Estado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Estado.Location = new System.Drawing.Point(27, 291);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(42, 15);
            this.lbl_Estado.TabIndex = 12;
            this.lbl_Estado.Text = "Estado";
            // 
            // Combo_Categoria
            // 
            this.Combo_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.Combo_Categoria.BaseColor = System.Drawing.Color.White;
            this.Combo_Categoria.BorderColor = System.Drawing.Color.Silver;
            this.Combo_Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Categoria.FocusedColor = System.Drawing.Color.Empty;
            this.Combo_Categoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_Categoria.ForeColor = System.Drawing.Color.Black;
            this.Combo_Categoria.FormattingEnabled = true;
            this.Combo_Categoria.Location = new System.Drawing.Point(29, 262);
            this.Combo_Categoria.Name = "Combo_Categoria";
            this.Combo_Categoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_Categoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_Categoria.Radius = 10;
            this.Combo_Categoria.Size = new System.Drawing.Size(253, 26);
            this.Combo_Categoria.TabIndex = 11;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Categoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Categoria.Location = new System.Drawing.Point(26, 244);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_Categoria.TabIndex = 10;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.txt_Descripcion.BaseColor = System.Drawing.Color.White;
            this.txt_Descripcion.BorderColor = System.Drawing.Color.Silver;
            this.txt_Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Descripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Descripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Descripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Descripcion.Location = new System.Drawing.Point(29, 204);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.PasswordChar = '\0';
            this.txt_Descripcion.Radius = 10;
            this.txt_Descripcion.SelectedText = "";
            this.txt_Descripcion.Size = new System.Drawing.Size(253, 30);
            this.txt_Descripcion.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_Nombre.BaseColor = System.Drawing.Color.White;
            this.txt_Nombre.BorderColor = System.Drawing.Color.Silver;
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Nombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Nombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Nombre.Location = new System.Drawing.Point(28, 151);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PasswordChar = '\0';
            this.txt_Nombre.Radius = 10;
            this.txt_Nombre.SelectedText = "";
            this.txt_Nombre.Size = new System.Drawing.Size(253, 30);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.Transparent;
            this.txt_Codigo.BaseColor = System.Drawing.Color.White;
            this.txt_Codigo.BorderColor = System.Drawing.Color.Silver;
            this.txt_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Codigo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Codigo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Codigo.Location = new System.Drawing.Point(27, 100);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.PasswordChar = '\0';
            this.txt_Codigo.Radius = 10;
            this.txt_Codigo.SelectedText = "";
            this.txt_Codigo.Size = new System.Drawing.Size(253, 30);
            this.txt_Codigo.TabIndex = 3;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Descripcion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Descripcion.Location = new System.Drawing.Point(26, 186);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(69, 15);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Nombre.Location = new System.Drawing.Point(25, 133);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Codigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Codigo.Location = new System.Drawing.Point(24, 82);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Animated = true;
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.btn_Excel.BorderRadius = 15;
            this.btn_Excel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Excel.CheckedState.Parent = this.btn_Excel;
            this.btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excel.CustomImages.Parent = this.btn_Excel;
            this.btn_Excel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Excel.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Excel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.HoverState.Parent = this.btn_Excel;
            this.btn_Excel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Excel.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Excel.Location = new System.Drawing.Point(955, 163);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(150, 38);
            this.btn_Excel.TabIndex = 211;
            this.btn_Excel.Text = "Descargar Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Animated = true;
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.btn_Limpiar.BorderRadius = 15;
            this.btn_Limpiar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Limpiar.CheckedState.Parent = this.btn_Limpiar;
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.CustomImages.Parent = this.btn_Limpiar;
            this.btn_Limpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.btn_Limpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Limpiar.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Limpiar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.HoverState.Parent = this.btn_Limpiar;
            this.btn_Limpiar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Limpiar.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Limpiar.Location = new System.Drawing.Point(1048, 100);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.ShadowDecoration.Parent = this.btn_Limpiar;
            this.btn_Limpiar.Size = new System.Drawing.Size(102, 36);
            this.btn_Limpiar.TabIndex = 216;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Animated = true;
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.btn_Buscar.BorderRadius = 15;
            this.btn_Buscar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Buscar.CheckedState.Parent = this.btn_Buscar;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.CustomImages.Parent = this.btn_Buscar;
            this.btn_Buscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(135)))), ((int)(((byte)(144)))));
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btn_Buscar.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.HoverState.Parent = this.btn_Buscar;
            this.btn_Buscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Buscar.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Buscar.Location = new System.Drawing.Point(897, 100);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.ShadowDecoration.Parent = this.btn_Buscar;
            this.btn_Buscar.Size = new System.Drawing.Size(102, 36);
            this.btn_Buscar.TabIndex = 215;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BaseColor = System.Drawing.Color.White;
            this.txt_Busqueda.BorderColor = System.Drawing.Color.Silver;
            this.txt_Busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Busqueda.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Busqueda.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Busqueda.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Busqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Busqueda.Location = new System.Drawing.Point(897, 58);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.PasswordChar = '\0';
            this.txt_Busqueda.SelectedText = "";
            this.txt_Busqueda.Size = new System.Drawing.Size(253, 30);
            this.txt_Busqueda.TabIndex = 212;
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
            this.Combo_Busqueda.Location = new System.Drawing.Point(897, 22);
            this.Combo_Busqueda.Name = "Combo_Busqueda";
            this.Combo_Busqueda.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Combo_Busqueda.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Combo_Busqueda.Size = new System.Drawing.Size(253, 26);
            this.Combo_Busqueda.TabIndex = 213;
            // 
            // lbl_Buscarpor
            // 
            this.lbl_Buscarpor.AutoSize = true;
            this.lbl_Buscarpor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscarpor.Location = new System.Drawing.Point(775, 22);
            this.lbl_Buscarpor.Name = "lbl_Buscarpor";
            this.lbl_Buscarpor.Size = new System.Drawing.Size(102, 25);
            this.lbl_Buscarpor.TabIndex = 214;
            this.lbl_Buscarpor.Text = "Buscar por";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(607, 186);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(270, 40);
            this.gunaLabel4.TabIndex = 217;
            this.gunaLabel4.Text = "Lista de Productos";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeight = 21;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvdata.Location = new System.Drawing.Point(344, 230);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(894, 456);
            this.dgvdata.TabIndex = 218;
            this.dgvdata.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdata.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvdata.ThemeStyle.ReadOnly = true;
            this.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvdata.ThemeStyle.RowsStyle.Height = 22;
            this.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Usuarios_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvdata;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Charizard_Portada;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 219;
            this.pictureBox1.TabStop = false;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 91.37056F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 101.7259F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 101.7259F;
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 101.7259F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 101.7259F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 101.7259F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1272, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.Combo_Busqueda);
            this.Controls.Add(this.lbl_Buscarpor);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.SubPanelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.SubPanelUsuario.ResumeLayout(false);
            this.SubPanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel SubPanelUsuario;
        private Guna.UI.WinForms.GunaTextBox txt_Indice;
        private Guna.UI2.WinForms.Guna2Button btn_Editar;
        private Guna.UI2.WinForms.Guna2Button btn_Eliminar;
        private Guna.UI2.WinForms.Guna2Button btn_Guardar;
        private Guna.UI.WinForms.GunaTextBox txt_Id;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox Combo_Estado;
        private Guna.UI.WinForms.GunaLabel lbl_Estado;
        private Guna.UI.WinForms.GunaComboBox Combo_Categoria;
        private Guna.UI.WinForms.GunaLabel lbl_Categoria;
        private Guna.UI.WinForms.GunaTextBox txt_Descripcion;
        private Guna.UI.WinForms.GunaTextBox txt_Nombre;
        private Guna.UI.WinForms.GunaTextBox txt_Codigo;
        private Guna.UI.WinForms.GunaLabel lbl_Descripcion;
        private Guna.UI.WinForms.GunaLabel lbl_Nombre;
        private Guna.UI.WinForms.GunaLabel lbl_Codigo;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private Guna.UI2.WinForms.Guna2Button btn_Limpiar;
        private Guna.UI2.WinForms.Guna2Button btn_Buscar;
        private Guna.UI.WinForms.GunaTextBox txt_Busqueda;
        private Guna.UI.WinForms.GunaComboBox Combo_Busqueda;
        private Guna.UI.WinForms.GunaLabel lbl_Buscarpor;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}