using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdata.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Combo_Estado.Items.Add(new OpcionCombo() { Valor = 1 , Texto = "Activo" });
            Combo_Estado.Items.Add(new OpcionCombo() { Valor = 0 , Texto = "No Activo" });
            Combo_Estado.DisplayMember = "Texto";
            Combo_Estado.ValueMember = "Valor";
            Combo_Estado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol) {
                Combo_Rol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            Combo_Rol.DisplayMember = "Texto";
            Combo_Rol.ValueMember = "Valor";
            Combo_Rol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns) {

                if (columna.Visible == true && columna.Name != "btnseleccionar") {
                    Combo_Busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }
            Combo_Busqueda.DisplayMember = "Texto";
            Combo_Busqueda.ValueMember = "Valor";
            Combo_Busqueda.SelectedIndex = 0;



            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

        }

        private void Limpiar() {

            txt_Indice.Text = "-1";
            txt_Id.Text = "0";
            txt_Documento.Text = "";
            txt_NombreCompleto.Text = "";
            txt_Correo.Text = "";
            txt_Clave.Text = "";
            txt_ConfirmarClave.Text = "";
            Combo_Rol.SelectedIndex = 0;
            Combo_Estado.SelectedIndex = 0;

            txt_Documento.Select();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txt_Id.Text),
                Documento = txt_Documento.Text,
                NombreCompleto = txt_NombreCompleto.Text,
                Correo = txt_Correo.Text,
                Clave = txt_Clave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)Combo_Rol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)Combo_Estado.SelectedItem).Valor) == 1 ? true : false
            };

            int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

            if (idusuariogenerado != 0)
            {

                dgvdata.Rows.Add(new object[] {"",idusuariogenerado,txt_Documento.Text,txt_NombreCompleto.Text,txt_Correo.Text,txt_Clave.Text,
                ((OpcionCombo)Combo_Rol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)Combo_Rol.SelectedItem).Texto.ToString(),
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

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txt_Id.Text),
                Documento = txt_Documento.Text,
                NombreCompleto = txt_NombreCompleto.Text,
                Correo = txt_Correo.Text,
                Clave = txt_Clave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)Combo_Rol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)Combo_Estado.SelectedItem).Valor) == 1 ? true : false
            };

            bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txt_Indice.Text)];
                row.Cells["Id"].Value = txt_Id.Text;
                row.Cells["Documento"].Value = txt_Documento.Text;
                row.Cells["NombreCompleto"].Value = txt_NombreCompleto.Text;
                row.Cells["Correo"].Value = txt_Correo.Text;
                row.Cells["Clave"].Value = txt_Clave.Text;
                row.Cells["IdRol"].Value = ((OpcionCombo)Combo_Rol.SelectedItem).Valor.ToString();
                row.Cells["Rol"].Value = ((OpcionCombo)Combo_Rol.SelectedItem).Texto.ToString();
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
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txt_Id.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txt_Indice    .Text));
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    txt_Indice.Text = indice.ToString();
                    txt_Id.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txt_Documento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txt_NombreCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txt_Correo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txt_Clave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txt_ConfirmarClave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (OpcionCombo oc in Combo_Rol.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = Combo_Rol.Items.IndexOf(oc);
                            Combo_Rol.SelectedIndex = indice_combo;
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
    }
}
