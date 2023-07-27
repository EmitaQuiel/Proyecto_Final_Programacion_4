using CapaPresentacion;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;

namespace Presentacion
{
    public partial class FormAdministrador : Form
    {
        private static FormUsuarios _formUsuarios;
        private static FormCategoria _formCategoria;
        private static FormProducto _formProducto;
        private static FormNegocio _formNegocio;
        private static FormRegistroVentas _formRegistroVenta;
        private static FormDetalleVenta _formDetalleVenta;
        private static FormRegistroCompras _formRegistroCompra;
        private static FormDetalleCompras _formDetalleCompra;
        private static FormClientes _formClientes;
        private static FormProveedores _formProveedores;
        private static FormReporteVentas _formReporteVenta;
        private static FormReporteCompras _formReporteCompra;
        //private static FormAcercaDe _formAcercaDe;

        private bool cerrandoSesion = false;

        private static Usuario usuarioActual;
        //public FormAdministrador(Usuario objusuario)
        public FormAdministrador(Usuario objusuario = null)

        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;
            InitializeComponent();
            //usuarioActual = objusuario;
            this.FormClosing += FormAdministrador_FormClosing;
        }
        private Form activeForm = null; //utilizar varios formularios
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;

            PanelHijo.Controls.Add(childform);
            PanelHijo.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            lbl_Nombre.Text = usuarioActual.NombreCompleto;
            lbl_Email.Text = usuarioActual.Correo;
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PanelHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrandoSesion && e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsuarios());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;

            if (!PanelMantenimiento.Visible)
            {
                PanelMantenimiento.BringToFront();
                PanelMantenimiento.Visible = true;
            }

            else
            {
                PanelMantenimiento.Visible = false;
            }
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;

            if (!PanelVentas.Visible)
            {
                PanelVentas.BringToFront();
                PanelVentas.Visible = true;
            }

            else
            {
                PanelVentas.Visible = false;
            }
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelReportes.Visible = false;

            if (!PanelCompras.Visible)
            {
                PanelCompras.BringToFront();
                PanelCompras.Visible = true;
            }

            else
            {
                PanelCompras.Visible = false;
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClientes());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProveedores());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;

            if (!PanelReportes.Visible)
            {
                PanelReportes.BringToFront();
                PanelReportes.Visible = true;
            }

            else
            {
                PanelReportes.Visible = false;
            }
        }

        private void btn_Acerca_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReportes());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategoria());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;

        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProducto());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;

        }

        private void btn_Negocio_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNegocio());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_VentaRegistro_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistroVentas(usuarioActual));
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;

        }

        private void btn_VentaDetalle_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDetalleVenta());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_CompraRegistro_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistroCompras(usuarioActual));
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_CompraDetalle_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDetalleCompras());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_ReporteVenta_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteVentas());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_ReporteCompra_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteCompras());
            PanelMantenimiento.Visible = false;
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Informacion_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelVentas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMantenimiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }
    }
}
