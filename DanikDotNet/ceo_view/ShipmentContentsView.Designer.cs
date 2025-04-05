namespace DanikDotNet.ceo_view
{
    partial class ShipmentContentsView
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
            this.shipmentContentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.shipmentContentsTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ShipmentContentsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ProductsTableAdapter();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ShipmentTableAdapter();
            this.supplycontentsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentContentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Товары в поставке";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplycontentsidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.supplyidDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shipmentContentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 13;
            // 
            // shipmentContentsBindingSource
            // 
            this.shipmentContentsBindingSource.DataMember = "ShipmentContents";
            this.shipmentContentsBindingSource.DataSource = this.danik_store_dbDataSet;
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
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shipmentContentsTableAdapter
            // 
            this.shipmentContentsTableAdapter.ClearBeforeFill = true;
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
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // supplycontentsidDataGridViewTextBoxColumn
            // 
            this.supplycontentsidDataGridViewTextBoxColumn.DataPropertyName = "supply_contents_id";
            this.supplycontentsidDataGridViewTextBoxColumn.HeaderText = "supply_contents_id";
            this.supplycontentsidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplycontentsidDataGridViewTextBoxColumn.Name = "supplycontentsidDataGridViewTextBoxColumn";
            this.supplycontentsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplycontentsidDataGridViewTextBoxColumn.Visible = false;
            this.supplycontentsidDataGridViewTextBoxColumn.Width = 150;
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
            // supplyidDataGridViewTextBoxColumn
            // 
            this.supplyidDataGridViewTextBoxColumn.DataPropertyName = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.DataSource = this.shipmentBindingSource;
            this.supplyidDataGridViewTextBoxColumn.DisplayMember = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.HeaderText = "Код поставки";
            this.supplyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplyidDataGridViewTextBoxColumn.Name = "supplyidDataGridViewTextBoxColumn";
            this.supplyidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplyidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplyidDataGridViewTextBoxColumn.ValueMember = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "Количество товара";
            this.productquantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            this.productquantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // ShipmentContentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ShipmentContentsView";
            this.Text = "ShipmentContentsView";
            this.Load += new System.EventHandler(this.ShipmentContentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentContentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource shipmentContentsBindingSource;
        private danik_store_dbDataSetTableAdapters.ShipmentContentsTableAdapter shipmentContentsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private danik_store_dbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private danik_store_dbDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplycontentsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
    }
}