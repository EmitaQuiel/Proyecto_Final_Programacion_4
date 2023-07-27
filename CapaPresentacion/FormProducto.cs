using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdata.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Combo_Estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            Combo_Estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            Combo_Estado.DisplayMember = "Texto";
            Combo_Estado.ValueMember = "Valor";
            Combo_Estado.SelectedIndex = 0;


            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                Combo_Categoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            Combo_Categoria.DisplayMember = "Texto";
            Combo_Categoria.ValueMember = "Valor";
            Combo_Categoria.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    Combo_Busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            Combo_Busqueda.DisplayMember = "Texto";
            Combo_Busqueda.ValueMember = "Valor";
            Combo_Busqueda.SelectedIndex = 0;



            //MOSTRAR TODOS LOS USUARIOS
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {

                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

        }
        private void Limpiar()
        {

            txt_Indice.Text = "-1";
            txt_Id.Text = "0";
            txt_Codigo.Text = "";
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            Combo_Categoria.SelectedIndex = 0;
            Combo_Estado.SelectedIndex = 0;

            txt_Codigo.Select();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txt_Id.Text),
                Codigo = txt_Codigo.Text,
                Nombre = txt_Nombre.Text,
                Descripcion = txt_Descripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)Combo_Categoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)Combo_Estado.SelectedItem).Valor) == 1 ? true : false
            };

            int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

            if (idgenerado != 0)
            {

                dgvdata.Rows.Add(new object[] {
                        "",
                       idgenerado,
                       txt_Codigo.Text,
                       txt_Nombre.Text,
                       txt_Descripcion.Text,
                       ((OpcionCombo)Combo_Categoria.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)Combo_Categoria.SelectedItem).Texto.ToString(),
                       "0",
                       "0.00",
                       "0.00",
                       ((OpcionCombo)Combo_Estado.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)Combo_Estado.SelectedItem).Texto.ToString()
                    });

                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txt_Id.Text),
                Codigo = txt_Codigo.Text,
                Nombre = txt_Nombre.Text,
                Descripcion = txt_Descripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)Combo_Categoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)Combo_Estado.SelectedItem).Valor) == 1 ? true : false
            };

            bool resultado = new CN_Producto().Editar(obj, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txt_Indice.Text)];
                row.Cells["Id"].Value = txt_Id.Text;
                row.Cells["Codigo"].Value = txt_Codigo.Text;
                row.Cells["Nombre"].Value = txt_Nombre.Text;
                row.Cells["Descripcion"].Value = txt_Descripcion.Text;
                row.Cells["IdCategoria"].Value = ((OpcionCombo)Combo_Categoria.SelectedItem).Valor.ToString();
                row.Cells["Categoria"].Value = ((OpcionCombo)Combo_Categoria.SelectedItem).Texto.ToString();
                row.Cells["EstadoValor"].Value = ((OpcionCombo)Combo_Estado.SelectedItem).Valor.ToString();
                row.Cells["Estado"].Value = ((OpcionCombo)Combo_Estado.SelectedItem).Texto.ToString();

                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_Id.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txt_Id.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txt_Indice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)Combo_Busqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_Busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[11].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }

        private void dtg_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    txt_Indice.Text = indice.ToString();
                    txt_Id.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();

                    txt_Codigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txt_Nombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txt_Descripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in Combo_Categoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = Combo_Categoria.Items.IndexOf(oc);
                            Combo_Categoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    foreach (OpcionCombo oc in Combo_Estado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = Combo_Estado.Items.IndexOf(oc);
                            Combo_Estado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }


            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
