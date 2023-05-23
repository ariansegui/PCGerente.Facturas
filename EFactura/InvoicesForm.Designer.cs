namespace EFactura
{
    partial class InvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridInvoices = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInvoices
            // 
            this.dataGridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvoices.Location = new System.Drawing.Point(12, 12);
            this.dataGridInvoices.Name = "dataGridInvoices";
            this.dataGridInvoices.RowTemplate.Height = 25;
            this.dataGridInvoices.Size = new System.Drawing.Size(867, 385);
            this.dataGridInvoices.TabIndex = 0;
            this.dataGridInvoices.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridInvoices_RowHeaderMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PDF
            // 
            this.btn_PDF.Location = new System.Drawing.Point(674, 415);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(104, 23);
            this.btn_PDF.TabIndex = 2;
            this.btn_PDF.Text = "Imprimir PDF";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURAS";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridInvoices;
        private Button button1;
        private Button btn_PDF;
    }
}