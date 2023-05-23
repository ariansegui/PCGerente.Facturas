namespace EFactura
{
    partial class EFacturas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_NewItem = new System.Windows.Forms.Button();
            this.tb_PriceUnit = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_ProductName = new System.Windows.Forms.TextBox();
            this.cb_TaxRate = new System.Windows.Forms.CheckBox();
            this.dt_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tb_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.btn_NewInvoice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Invoices = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridItems);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cb_TaxRate);
            this.groupBox1.Controls.Add(this.dt_InvoiceDate);
            this.groupBox1.Controls.Add(this.tb_InvoiceNumber);
            this.groupBox1.Controls.Add(this.tb_CustomerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 388);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // dataGridItems
            // 
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Location = new System.Drawing.Point(216, 22);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowTemplate.Height = 25;
            this.dataGridItems.Size = new System.Drawing.Size(549, 353);
            this.dataGridItems.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_NewItem);
            this.groupBox2.Controls.Add(this.tb_PriceUnit);
            this.groupBox2.Controls.Add(this.tb_Quantity);
            this.groupBox2.Controls.Add(this.tb_ProductName);
            this.groupBox2.Location = new System.Drawing.Point(10, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 183);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // bt_NewItem
            // 
            this.bt_NewItem.Location = new System.Drawing.Point(79, 145);
            this.bt_NewItem.Name = "bt_NewItem";
            this.bt_NewItem.Size = new System.Drawing.Size(115, 23);
            this.bt_NewItem.TabIndex = 7;
            this.bt_NewItem.Text = "Agregar Producto";
            this.bt_NewItem.UseVisualStyleBackColor = true;
            this.bt_NewItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_PriceUnit
            // 
            this.tb_PriceUnit.Location = new System.Drawing.Point(6, 106);
            this.tb_PriceUnit.Name = "tb_PriceUnit";
            this.tb_PriceUnit.PlaceholderText = "Precio x Unidad";
            this.tb_PriceUnit.Size = new System.Drawing.Size(188, 23);
            this.tb_PriceUnit.TabIndex = 6;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(6, 63);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.PlaceholderText = "Cantidad";
            this.tb_Quantity.Size = new System.Drawing.Size(188, 23);
            this.tb_Quantity.TabIndex = 5;
            // 
            // tb_ProductName
            // 
            this.tb_ProductName.Location = new System.Drawing.Point(6, 22);
            this.tb_ProductName.Name = "tb_ProductName";
            this.tb_ProductName.PlaceholderText = "Nombre del Producto";
            this.tb_ProductName.Size = new System.Drawing.Size(188, 23);
            this.tb_ProductName.TabIndex = 4;
            // 
            // cb_TaxRate
            // 
            this.cb_TaxRate.AutoSize = true;
            this.cb_TaxRate.Location = new System.Drawing.Point(134, 156);
            this.cb_TaxRate.Name = "cb_TaxRate";
            this.cb_TaxRate.Size = new System.Drawing.Size(76, 19);
            this.cb_TaxRate.TabIndex = 3;
            this.cb_TaxRate.Text = "Grava IVA";
            this.cb_TaxRate.UseVisualStyleBackColor = true;
            // 
            // dt_InvoiceDate
            // 
            this.dt_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_InvoiceDate.Location = new System.Drawing.Point(6, 66);
            this.dt_InvoiceDate.Name = "dt_InvoiceDate";
            this.dt_InvoiceDate.Size = new System.Drawing.Size(200, 23);
            this.dt_InvoiceDate.TabIndex = 0;
            // 
            // tb_InvoiceNumber
            // 
            this.tb_InvoiceNumber.Location = new System.Drawing.Point(6, 113);
            this.tb_InvoiceNumber.Name = "tb_InvoiceNumber";
            this.tb_InvoiceNumber.PlaceholderText = "Código de Factura";
            this.tb_InvoiceNumber.Size = new System.Drawing.Size(204, 23);
            this.tb_InvoiceNumber.TabIndex = 2;
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Location = new System.Drawing.Point(6, 22);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.PlaceholderText = "Nombre del Cliente";
            this.tb_CustomerName.Size = new System.Drawing.Size(204, 23);
            this.tb_CustomerName.TabIndex = 1;
            // 
            // btn_NewInvoice
            // 
            this.btn_NewInvoice.Location = new System.Drawing.Point(107, 406);
            this.btn_NewInvoice.Name = "btn_NewInvoice";
            this.btn_NewInvoice.Size = new System.Drawing.Size(115, 23);
            this.btn_NewInvoice.TabIndex = 8;
            this.btn_NewInvoice.Text = "Agregar Factura";
            this.btn_NewInvoice.UseVisualStyleBackColor = true;
            this.btn_NewInvoice.Click += new System.EventHandler(this.btn_NewInvoice_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.Location = new System.Drawing.Point(561, 406);
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.Size = new System.Drawing.Size(123, 23);
            this.btn_Invoices.TabIndex = 103;
            this.btn_Invoices.Text = "Ver Facturas";
            this.btn_Invoices.UseVisualStyleBackColor = true;
            this.btn_Invoices.Click += new System.EventHandler(this.btn_Invoices_Click);
            // 
            // EFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 434);
            this.Controls.Add(this.btn_Invoices);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_NewInvoice);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EFacturas";
            this.Text = "Facturas Electronicas";
            this.Load += new System.EventHandler(this.EFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_InvoiceNumber;
        private TextBox tb_CustomerName;
        private DateTimePicker dt_InvoiceDate;
        private CheckBox cb_TaxRate;
        private GroupBox groupBox2;
        private TextBox tb_PriceUnit;
        private TextBox tb_Quantity;
        private TextBox tb_ProductName;
        private DataGridView dataGridItems;
        private Button bt_NewItem;
        private Button btn_NewInvoice;
        private Button button3;
        private Button btn_Invoices;
    }
}