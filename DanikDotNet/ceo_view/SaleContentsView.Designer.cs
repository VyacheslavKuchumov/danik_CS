namespace DanikDotNet.ceo_view
{
    partial class SaleContentsView
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleContentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.saleContentsTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.SaleContentsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ProductsTableAdapter();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.SalesTableAdapter();
            this.salecontentsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surchargepercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleContentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Товары в продаже";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salecontentsidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.saleidDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn,
            this.surchargepercentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saleContentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 9;
            // 
            // saleContentsBindingSource
            // 
            this.saleContentsBindingSource.DataMember = "SaleContents";
            this.saleContentsBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saleContentsTableAdapter
            // 
            this.saleContentsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salecontentsidDataGridViewTextBoxColumn
            // 
            this.salecontentsidDataGridViewTextBoxColumn.DataPropertyName = "sale_contents_id";
            this.salecontentsidDataGridViewTextBoxColumn.HeaderText = "sale_contents_id";
            this.salecontentsidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salecontentsidDataGridViewTextBoxColumn.Name = "salecontentsidDataGridViewTextBoxColumn";
            this.salecontentsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.salecontentsidDataGridViewTextBoxColumn.Visible = false;
            this.salecontentsidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.DataSource = this.productsBindingSource;
            this.productidDataGridViewTextBoxColumn.DisplayMember = "product_name";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productidDataGridViewTextBoxColumn.ValueMember = "product_id";
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "sale_id";
            this.saleidDataGridViewTextBoxColumn.DataSource = this.salesBindingSource;
            this.saleidDataGridViewTextBoxColumn.DisplayMember = "sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "Код продажи";
            this.saleidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.saleidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.saleidDataGridViewTextBoxColumn.ValueMember = "sale_id";
            this.saleidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "Количество товаров";
            this.productquantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            this.productquantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // surchargepercentageDataGridViewTextBoxColumn
            // 
            this.surchargepercentageDataGridViewTextBoxColumn.DataPropertyName = "surcharge_percentage";
            this.surchargepercentageDataGridViewTextBoxColumn.HeaderText = "Наценка за ед. товара (%)";
            this.surchargepercentageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.surchargepercentageDataGridViewTextBoxColumn.Name = "surchargepercentageDataGridViewTextBoxColumn";
            this.surchargepercentageDataGridViewTextBoxColumn.Width = 150;
            // 
            // SaleContentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SaleContentsView";
            this.Text = "SaleContentsView";
            this.Load += new System.EventHandler(this.SaleContentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleContentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource saleContentsBindingSource;
        private danik_store_dbDataSetTableAdapters.SaleContentsTableAdapter saleContentsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private danik_store_dbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private danik_store_dbDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salecontentsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surchargepercentageDataGridViewTextBoxColumn;
    }
}