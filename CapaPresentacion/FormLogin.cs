using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;
using Guna.UI2.WinForms.Suite;

namespace Presentacion
{

    public partial class FormLogin : Form
    {
        private Control hiddenControl;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            hiddenControl = new Control();
            hiddenControl.Location = new Point(-100, -100);
            hiddenControl.Size = new Size(1, 1);
            Controls.Add(hiddenControl);
            hiddenControl.Select();
            Picture_Error.Visible = false;
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
           List<Usuario> usuarios = new CN_Usuario().Listar();
        Usuario usuario = usuarios.FirstOrDefault(u => u.Documento == txt_Documento.Text && u.Clave == txt_Contraseña.Text);

        if (usuario != null)
        {
            if (usuario.oRol.Descripcion == "ADMINISTRADOR")
            {
                FormAdministrador form = new FormAdministrador(usuario);
                this.Hide();
                FormBienvenida welcome = new FormBienvenida();
                welcome.ShowDialog();
                form.Show();
                    form.FormClosing += frm_closing;
                }
            else if (usuario.oRol.Descripcion == "EMPLEADO")
            {
                FormEmpleado form = new FormEmpleado(usuario);
                this.Hide();
                FormBienvenida welcome = new FormBienvenida();
                welcome.ShowDialog();
                form.Show();
                    form.FormClosing += frm_closing;
                }
            else
            {
                msgError("Rol de usuario no válido.");
            }
        }
        else
        {
            msgError("Documento o contraseña incorrecta.");
        }
        }

        private void cerrar_sesion(object sender, FormClosedEventArgs e)
        {
            txt_Contraseña.Text = "Contraseña";
            txt_Contraseña.UseSystemPasswordChar = false;
            txt_Documento.Text = "Nro Documento";
            lbl_Error.Visible = false;
            Picture_Error.Visible = false;
            this.Show();
        }

        private void msgError(string msg)
        {
            lbl_Error.Text = "  " + msg;
            lbl_Error.Visible = true;
            Picture_Error.Visible = true;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txt_Documento.Text = "";
            txt_Contraseña.Text = "";
            this.Show();
        }

        private void txt_Documento_Enter(object sender, EventArgs e)
        {
            if (txt_Documento.Text == "Nro Documento")
            {
                txt_Documento.Text = "";
                txt_Documento.ForeColor = Color.DarkRed;
            }
        }

        private void txt_Documento_Leave(object sender, EventArgs e)
        {
            if (txt_Documento.Text == "")
            {
                txt_Documento.Text = "Nro Documento";
                txt_Documento.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "Contraseña")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.DarkRed;
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "Contraseña";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;

            }
        }

        private void txt_Documento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Ingresar.PerformClick();
            }
        }

        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_Ingresar.PerformClick();
            }
        }

        private void txt_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Ingresar.PerformClick();
            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_Ingresar.PerformClick();
            }
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
