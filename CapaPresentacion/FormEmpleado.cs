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
    public partial class FormEmpleado : Form
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
        private bool cerrandoSesion = false;
        private static Usuario usuarioActual;
        public FormEmpleado(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;
            InitializeComponent();
            //usuarioActual = objusuario;
            this.FormClosing += FormColaborador_FormClosing;
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
  
        private void btn_cerrar_sesion_Click_1(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrandoSesion && e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            lbl_Nombre.Text = usuarioActual.NombreCompleto;
            lbl_Email.Text = usuarioActual.Correo;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
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
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProveedores());
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
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
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_VentaRegistro_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistroVentas(usuarioActual));
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_VentaDetalle_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDetalleVenta());
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_CompraRegistro_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistroCompras(usuarioActual));
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_CompraDetalle_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDetalleCompras());
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_ReporteVenta_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteVentas());
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_ReporteCompra_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteCompras());
            PanelVentas.Visible = false;
            PanelCompras.Visible = false;
            PanelReportes.Visible = false;
        }

        private void btn_Informacion_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }
    }
}
