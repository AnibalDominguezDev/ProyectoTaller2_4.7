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
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.Properties;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class DetalleVenta : Form
    {
        private int idVenta;
        public DetalleVenta(int id_venta)
        {
            this.idVenta = id_venta;
            InitializeComponent();
            cargarDetalle();        
        }

        public int getIdVenta()
        {
            return this.idVenta;
        }

        private void cargarDetalle()
        {
            Ventas venta = new Ventas().obtenerVentaPorId(this.idVenta);
            lblFecha.Text = $"Fecha: {venta.getFecha()}";
            lblVendedor.Text = $"Vendedor: {Usuarios.getNombreCompleto(venta.getIdUsuario())}";
            lblCliente.Text = $"Cliente: {Clientes.getNombreCliente(venta.getIdCliente())}";

            lblPrecioTotal.Text = $"Total: ${venta.getTotalVenta()}";

            lblDetalleDeVenta.Text = $"Detalle de la venta Nro: # {this.idVenta}";

            formatoDataGrid();
            dgbDetalleProductos.DataSource = Ventas.obtenerDatosVenta(getIdVenta());
        }

        private void formatoDataGrid()
        {
            dgbDetalleProductos.AutoGenerateColumns = false;

            dgbDetalleProductos.Columns["productoId"].DataPropertyName = "codProducto";
            dgbDetalleProductos.Columns["colNombre"].DataPropertyName = "producto";
            dgbDetalleProductos.Columns["colDescripcion"].DataPropertyName = "productoDesc";
            dgbDetalleProductos.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgbDetalleProductos.Columns["colPrecioUnitario"].DataPropertyName = "precio";
            dgbDetalleProductos.Columns["colSubTotal"].DataPropertyName = "subTotal";
        }

        private void guardarPDF()
        {

            Ventas venta = new Ventas().obtenerVentaPorId(this.idVenta);

            if (dgbDetalleProductos.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf) | *.pdf";
                save.FileName = $"Factura de la venta {this.getIdVenta()}.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch
                    {

                        ErrorMessage = true;
                        MessageBox.Show("No se pudo guardar el pdf");
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgbDetalleProductos.ColumnCount);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            foreach (DataGridViewColumn col in dgbDetalleProductos.Columns)
                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow row in dgbDetalleProductos.Rows)
                            {
                                foreach (DataGridViewCell dcell in row.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
                            {

                                string imgPath = Path.Combine(Environment.CurrentDirectory, "logo.jpg");

                                string imgPath2 = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/logo.jpg");

                                

                                

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter pw = PdfWriter.GetInstance(document, fs);

                                Image logo = Image.GetInstance(imgPath2);

                                Console.WriteLine(document.GetTop(3));

                                // logo.SetAbsolutePosition(document.LeftMargin, pw.PageSize.GetTop(document.TopMargin) + 2);

                                logo.ScaleAbsolute(150f, 150f);
                                logo.Border = 1;
                                
                                logo.SetAbsolutePosition(2,717);
                                


                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED);
                                Font titleFont = new Font(bf, 12, 0, BaseColor.BLACK);
                                titleFont.Size = 20;

                                BaseFont bbf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                                Font textFont = new Font(bf, 12, 0, BaseColor.BLACK);
                                textFont.Size = 16;


                                PdfPTable tbHeader = new PdfPTable(3);
                                tbHeader.WidthPercentage = 100;
                                tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                                tbHeader.DefaultCell.Border = 0;

                                PdfPTable tBody = new PdfPTable(3);
                                tBody.WidthPercentage = 100;
                                tBody.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                                tBody.DefaultCell.Border = 0;

                                PdfPTable tDetalle = new PdfPTable(3);
                                tDetalle.WidthPercentage = 100;
                                tDetalle.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                                tDetalle.DefaultCell.Border = 0;

                                PdfPCell cfechaVenta = new PdfPCell(new Paragraph($"Fecha de la venta: {venta.getFecha()}", textFont));
                                cfechaVenta.HorizontalAlignment = Element.ALIGN_LEFT;
                                cfechaVenta.Border = 0;

                                PdfPCell cVendedor = new PdfPCell(new Paragraph($"Vendedor: {Usuarios.getNombreCompleto(venta.getIdUsuario())}", textFont));
                                cVendedor.HorizontalAlignment = Element.ALIGN_LEFT;
                                cVendedor.Border = 0;

                                PdfPCell cCliente = new PdfPCell(new Paragraph($"Cliente: {Clientes.getNombreCliente(venta.getIdCliente())}", textFont));
                                cCliente.HorizontalAlignment = Element.ALIGN_LEFT;
                                cCliente.Border = 0;

                                PdfPCell cDetalle = new PdfPCell(new Paragraph($"Detalle de la venta:",textFont));
                                cDetalle.HorizontalAlignment = Element.ALIGN_LEFT;
                                cDetalle.Border = 0;


                                tBody.AddCell(cfechaVenta);
                                tBody.AddCell(cVendedor);
                                tBody.AddCell(cCliente);

                                tDetalle.AddCell(cDetalle);
                                tDetalle.AddCell(new Paragraph());
                                tDetalle.AddCell(new Paragraph());
                                


                                PdfPTable tFooter = new PdfPTable(3);
                                tFooter.WidthPercentage = 100;
                                tFooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                                tbHeader.DefaultCell.Border = 0;

                                PdfPCell whitecell = new PdfPCell(new Paragraph(""));
                                whitecell.HorizontalAlignment = Element.ALIGN_CENTER;
                                whitecell.Border = 0;

                                PdfPCell cMetodopago = new PdfPCell(new Paragraph($"Metodo de pago: {Ventas.getMetodoPagobyId(venta.getMetodoPago())}"));
                                cMetodopago.HorizontalAlignment = Element.ALIGN_CENTER;
                                cMetodopago.Border = 0;


                                tFooter.AddCell(whitecell);
                                tFooter.AddCell(cMetodopago);

                                PdfPCell vTotal = new PdfPCell(new Paragraph($"Total: ${venta.getTotalVenta()}",textFont));
                                vTotal.HorizontalAlignment = Element.ALIGN_RIGHT;
                                vTotal.Border = 0;

                                tFooter.AddCell(vTotal);

                                PdfPCell _cell = new PdfPCell(new Paragraph($"Factura de la venta #{this.idVenta}",titleFont));
                                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell.Border = 0;

                                tbHeader.AddCell(new Paragraph());
                                tbHeader.AddCell(_cell);
                                tbHeader.AddCell(new Paragraph());


                                document.Open();
                                
                                tDetalle.WriteSelectedRows(0, -1, document.LeftMargin, pw.PageSize.GetTop(document.TopMargin) + 40, pw.DirectContent);
                                //tFooter.WriteSelectedRows(0, -1, document.LeftMargin, pw.PageSize.GetTop(document.TopMargin) + 40, pw.DirectContent);


                                document.Add(logo);
                                document.Add(tbHeader);
                                document.Add(new Paragraph("\n\n"));
                                document.Add(tBody);
                                document.Add(new Paragraph("\n"));
                                document.Add(tDetalle);
                                document.Add(new Paragraph(""));
                                document.Add(pTable);
                                document.Add(new Paragraph("\n"));
                                document.Add(tFooter);
                                document.Close();
                                fs.Close();
                            }

                            MessageBox.Show("Se guardo la factura correctamente!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }

        }

        private void btnGuardarPdf_Click(object sender, EventArgs e)
        {
            guardarPDF();
        }
    }
}
