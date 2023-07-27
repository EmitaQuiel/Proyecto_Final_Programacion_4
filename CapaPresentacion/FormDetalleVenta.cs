﻿using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormDetalleVenta : Form
    {
        public FormDetalleVenta()
        {
            InitializeComponent();
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdata.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txt_DocumentoArchivo.Select();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txt_DocumentoArchivo.Text);

            if (oVenta.IdVenta != 0) {

                txt_NumeroDocumento.Text = oVenta.NumeroDocumento;

                txt_Fecha.Text = oVenta.FechaRegistro;
                txt_TipoDocumento.Text = oVenta.TipoDocumento;
                txt_Usuario.Text = oVenta.oUsuario.NombreCompleto;


                txt_DocCliente.Text = oVenta.DocumentoCliente;
                txt_NombreCliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txt_MontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                txt_MontoPago.Text = oVenta.MontoPago.ToString("0.00");
                txt_MontoCambio.Text = oVenta.MontoCambio.ToString("0.00");


            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txt_Fecha.Text = "";
            txt_TipoDocumento.Text = "";
            txt_Usuario.Text = "";
            txt_DocCliente.Text = "";
            txt_NombreCliente.Text = "";

            dgvdata.Rows.Clear();
            txt_MontoTotal.Text = "0.00";
            txt_MontoPago.Text = "0.00";
            txt_MontoCambio.Text = "0.00";
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (txt_TipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txt_TipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txt_NumeroDocumento.Text);


            Texto_Html = Texto_Html.Replace("@doccliente", txt_DocCliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txt_NombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txt_Fecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txt_Usuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txt_MontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txt_MontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txt_MontoCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txt_NumeroDocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
