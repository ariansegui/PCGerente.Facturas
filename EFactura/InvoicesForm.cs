using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SQLAccess.Models;

namespace EFactura
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var invoices = InvoicesController.GetAllInvoices();

            DataGridViewTextBoxColumn col_InvoiceId = new()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            }; dataGridInvoices.Columns.Add(col_InvoiceId);

            DataGridViewTextBoxColumn col_InvoiceNumber = new()
            {
                DataPropertyName = "InvoiceNumber",
                HeaderText = "Número de Factura",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_InvoiceNumber);

            DataGridViewTextBoxColumn col_InvoiceDate = new()
            {
                DataPropertyName = "InvoiceDate",
                HeaderText = "Fecha de Factura",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_InvoiceDate);

            DataGridViewTextBoxColumn col_CustomerName = new()
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Cliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_CustomerName);

            DataGridViewTextBoxColumn col_Amount = new()
            {
                DataPropertyName = "TOTAL",
                HeaderText = "Subtotal",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_Amount);

            DataGridViewTextBoxColumn col_TaxRate = new()
            {
                DataPropertyName = "TaxRate",
                HeaderText = "IVA",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_TaxRate);

            DataGridViewTextBoxColumn col_TotalTaxRate = new()
            {
                DataPropertyName = "TOTAL_TAX",
                HeaderText = "Total",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridInvoices.Columns.Add(col_TotalTaxRate);

            dataGridInvoices.DataSource = invoices;
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            if (dataGridInvoices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridInvoices.SelectedRows[0];
                Invoice selectedInvoice = (Invoice)selectedRow.DataBoundItem;

                Print_PDF(selectedInvoice);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void Print_PDF(Invoice selectedInvoice)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.FileName = selectedInvoice.InvoiceNumber + ".pdf";
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";

            string htmlPage = Properties.Resources.template.ToString();
            htmlPage = htmlPage.Replace("@Customer", selectedInvoice.CustomerName);
            htmlPage = htmlPage.Replace("@InvoiceNumber", selectedInvoice.InvoiceNumber);
            htmlPage = htmlPage.Replace("@InvoiceDate", selectedInvoice.InvoiceDate.ToString());

            string rows = string.Empty;
            decimal subtotal = selectedInvoice.TOTAL;
            string taxRate = selectedInvoice.TaxRate ? "12%" : "0%";
            decimal total = selectedInvoice.TOTAL_TAX;

            foreach (var item in selectedInvoice.Items)
            {
                rows += "<tr>";
                rows += "<td>" + item.Quantity + "</td>";
                rows += "<td>" + item.ProductName + "</td>";
                rows += "<td>" + (decimal)item.PriceUnit + "</td>";
                rows += "<td>" + (decimal)item.Amount + "</td>";
                rows += "</tr>";
            }
            htmlPage = htmlPage.Replace("@Rows", rows);
            htmlPage = htmlPage.Replace("@Subtotal", subtotal.ToString());
            htmlPage = htmlPage.Replace("@TaxRate", taxRate.ToString());
            htmlPage = htmlPage.Replace("@TOTAL", total.ToString());


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(htmlPage))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void dataGridInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridInvoices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridInvoices.SelectedRows[0];
                Invoice selectedInvoice = (Invoice)selectedRow.DataBoundItem;

                Print_PDF(selectedInvoice);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
