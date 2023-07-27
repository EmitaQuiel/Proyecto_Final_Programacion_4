using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRegistroCompras : Form
    {

        private Usuario _Usuario;

        public FormRegistroCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdata.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            Combo_TipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            Combo_TipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            Combo_TipoDocumento.DisplayMember = "Texto";
            Combo_TipoDocumento.ValueMember = "Valor";
            Combo_TipoDocumento.SelectedIndex = 0;

            txt_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txt_IdProveedor.Text = "0";
            txt_IdProducto.Text = "0";
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor()) {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_IdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txt_DocumentoProveedor.Text = modal._Proveedor.Documento;
                    txt_RazonSocial.Text = modal._Proveedor.RazonSocial;
                }
                else {
                    txt_DocumentoProveedor.Select();
                }

            }
        }

        private void txt_CodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txt_CodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txt_CodigoProducto.BackColor = Color.Honeydew;
                    txt_IdProducto.Text = oProducto.IdProducto.ToString();
                    txt_Producto.Text = oProducto.Nombre;
                    txt_PrecioCompra.Select();
                }
                else {
                    txt_CodigoProducto.BackColor = Color.MistyRose;
                    txt_IdProducto.Text = "0";
                    txt_Producto.Text = "";
                }


            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txt_IdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_PrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_PrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(txt_PrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_PrecioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txt_IdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe) {

                dgvdata.Rows.Add(new object[] {
                    txt_IdProducto.Text,
                    txt_Producto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    num_Cantidad.Value.ToString(),
                    (num_Cantidad.Value * preciocompra).ToString("0.00")

                });

                calcularTotal();
                limpiarProducto();
                txt_CodigoProducto.Select();

            }
            
        }

        private void limpiarProducto()
        {
            txt_IdProducto.Text = "0";
            txt_CodigoProducto.Text = "";
            txt_CodigoProducto.BackColor = Color.White;
            txt_Producto.Text = "";
            txt_PrecioCompra.Text = "";
            txt_PrecioVenta.Text = "";
            num_Cantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txt_Total.Text = total.ToString("0.00");
        }
        private void txt_PrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                if (txt_PrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txt_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_PrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_IdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows) {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() {IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txt_IdProveedor.Text) },
                TipoDocumento = ((OpcionCombo)Combo_TipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txt_Total.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra,detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txt_IdProveedor.Text = "0";
                txt_DocumentoProveedor.Text = "";
                txt_RazonSocial.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                
            }
            else {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_IdProducto.Text = modal._Producto.IdProducto.ToString();
                    txt_CodigoProducto.Text = modal._Producto.Codigo;
                    txt_Producto.Text = modal._Producto.Nombre;
                    txt_PrecioCompra.Select();
                }
                else
                {
                    txt_CodigoProducto.Select();
                }

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
