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
    public partial class FormRegistroVentas : Form
    {

        private Usuario _Usuario;
        public FormRegistroVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdata.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            Combo_TipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            Combo_TipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            Combo_TipoDocumento.DisplayMember = "Texto";
            Combo_TipoDocumento.ValueMember = "Valor";
            Combo_TipoDocumento.SelectedIndex = 0;

            txt_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txt_PagaCon.Text = "";
            txt_Cambio.Text = "";
            txt_Total.Text = "0";
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_DocumentoCliente.Text = modal._Cliente.Documento;
                    txt_NombreCliente.Text = modal._Cliente.NombreCompleto;
                    txt_CodigoProducto.Select();
                }
                else
                {
                    txt_DocumentoCliente.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txt_CodigoProducto.Text = modal._Producto.Codigo;
                    txt_Producto.Text = modal._Producto.Nombre;
                    txt_Precio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txt_Stock.Text = modal._Producto.Stock.ToString();
                    num_Cantidad.Select();
                }
                else
                {
                    txt_CodigoProducto.Select();
                }

            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_Precio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Precio.Select();
                return;
            }

            if (Convert.ToInt32(txt_Stock.Text) < Convert.ToInt32(num_Cantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe) {
                
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(num_Cantidad.Value.ToString())
                    );

                if (respuesta) {
                    dgvdata.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txt_Producto.Text,
                        precio.ToString("0.00"),
                        num_Cantidad.Value.ToString(),
                        (num_Cantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txt_CodigoProducto.Select();
                }
            }

            

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

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txt_CodigoProducto.Text = "";
            txt_Producto.Text = "";
            txt_Precio.Text = "";
            txt_Stock.Text = "";
            num_Cantidad.Value = 1;
        }

        private void calcularcambio() {

            if (txt_Total.Text.Trim() == "") {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(txt_Total.Text);

            if (txt_PagaCon.Text.Trim() == "") {
                txt_PagaCon.Text = "0";
            }

            if (decimal.TryParse(txt_PagaCon.Text.Trim(), out pagacon)) {

                if (pagacon < total)
                {
                    txt_Cambio.Text = "0.00";
                }
                else {
                    decimal cambio = pagacon - total;
                    txt_Cambio.Text = cambio.ToString("0.00");

                }
            }



        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {

            if (txt_DocumentoCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txt_NombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)Combo_TipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txt_DocumentoCliente.Text,
                NombreCliente = txt_NombreCliente.Text,
                MontoPago = Convert.ToDecimal(txt_PagaCon.Text),
                MontoCambio = Convert.ToDecimal(txt_Cambio.Text),
                MontoTotal = Convert.ToDecimal(txt_Total.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta) {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txt_DocumentoCliente.Text = "";
                txt_NombreCliente.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txt_PagaCon.Text = "";
                txt_Cambio.Text = "";
            }else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }

                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
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

        private void txt_PagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txt_PagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_PagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_Precio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txt_CodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txt_CodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txt_CodigoProducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txt_Producto.Text = oProducto.Nombre;
                    txt_Precio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txt_Stock.Text = oProducto.Stock.ToString();
                    num_Cantidad.Select();
                }
                else
                {
                    txt_CodigoProducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txt_Producto.Text = "";
                    txt_Precio.Text = "";
                    txt_Stock.Text = "";
                    num_Cantidad.Value = 1;
                }
            }
        }
    }
}
