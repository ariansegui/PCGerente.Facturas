using SQLAccess.Models;

namespace EFactura
{
    public partial class EFacturas : Form
    {
        public List<InvoiceItem> Items { get; set; } = new();

        public EFacturas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EFacturas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridItems.Columns.Clear();

            DataGridViewTextBoxColumn col_ProductName = new()
            {
                DataPropertyName = "ProductName",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }; dataGridItems.Columns.Add(col_ProductName);

            DataGridViewTextBoxColumn col_Quantity = new()
            {
                DataPropertyName = "Quantity",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }; dataGridItems.Columns.Add(col_Quantity);

            DataGridViewTextBoxColumn col_PricexUnit = new()
            {
                DataPropertyName = "PriceUnit",
                HeaderText = "Precio Unidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridItems.Columns.Add(col_PricexUnit);

            DataGridViewTextBoxColumn col_Amount = new()
            {
                DataPropertyName = "Amount",
                HeaderText = "Monto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridItems.Columns.Add(col_Amount);

            dataGridItems.DataSource = Items;

            dataGridItems.Columns["InvoiceId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FieldsItemEmpty())
            {
                MessageBox.Show("Complete los campos del Producto");
            }
            else
            {
                Items.Add(new InvoiceItem
                {
                    ProductName = tb_ProductName.Text.Trim(),
                    Quantity = Decimal.Parse(tb_Quantity.Text.Trim()),
                    PriceUnit = Decimal.Parse(tb_PriceUnit.Text.Trim()),
                });

                dataGridItems.DataSource = null;
                LoadData();
                tb_ProductName.Text = tb_Quantity.Text = tb_PriceUnit.Text = String.Empty;

                tb_ProductName.Focus();
            }
        }
        /// <summary>
        /// Comprobar si alguno o todos los campos del producto estan vacios.
        /// </summary>
        /// <returns>True o False</returns>
        private bool FieldsItemEmpty()
        {
            return (tb_ProductName.Text.Trim() == string.Empty ||
                tb_Quantity.Text.Trim() == string.Empty ||
                tb_PriceUnit.Text.Trim() == string.Empty);
        }

        private bool InvoiceFieldsEmpty()
        {
            return (tb_CustomerName.Text.Trim() == string.Empty ||
                tb_InvoiceNumber.Text.Trim() == string.Empty);
        }

        private void btn_NewInvoice_Click(object sender, EventArgs e)
        {
            if (InvoiceFieldsEmpty())
            {
                MessageBox.Show("Complete los campos de la factura");
            }
            else
            {
                Invoice invoice = new()
                {
                    CustomerName = tb_CustomerName.Text.Trim(),
                    InvoiceDate = dt_InvoiceDate.Value,
                    InvoiceNumber = tb_InvoiceNumber.Text.Trim(),
                    TaxRate = cb_TaxRate.Checked,
                };
                invoice.Items = Items;

                InvoicesController.CreateInvoice(invoice);
            }

            ClearFields();
        }

        private void ClearFields()
        {
            tb_CustomerName.Text = tb_InvoiceNumber.Text = string.Empty;
            cb_TaxRate.Checked = false;
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            var form = new InvoicesForm();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}