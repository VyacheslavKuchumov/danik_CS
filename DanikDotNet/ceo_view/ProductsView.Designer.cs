namespace DanikDotNet.ceo_view
{
    partial class ProductsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ProductsTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Товары";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn,
            this.costperunitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // costperunitDataGridViewTextBoxColumn
            // 
            this.costperunitDataGridViewTextBoxColumn.DataPropertyName = "cost_per_unit";
            this.costperunitDataGridViewTextBoxColumn.HeaderText = "cost_per_unit";
            this.costperunitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costperunitDataGridViewTextBoxColumn.Name = "costperunitDataGridViewTextBoxColumn";
            this.costperunitDataGridViewTextBoxColumn.Width = 150;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ProductsView";
            this.Text = "ProductsView";
            this.Load += new System.EventHandler(this.ProductsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private danik_store_dbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costperunitDataGridViewTextBoxColumn;
    }
}