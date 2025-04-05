namespace DanikDotNet.ceo_view
{
    partial class ShipmentsView
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
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.shipmentTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.ShipmentTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.SuppliersTableAdapter();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.StoresTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.EmployeesTableAdapter();
            this.supplyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shippingcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Состав поставки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Поставки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplyidDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.shipmentdescriptionDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.shippingcostDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(918, 235);
            this.dataGridView1.TabIndex = 15;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // supplyidDataGridViewTextBoxColumn
            // 
            this.supplyidDataGridViewTextBoxColumn.DataPropertyName = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.HeaderText = "Код поставки";
            this.supplyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplyidDataGridViewTextBoxColumn.Name = "supplyidDataGridViewTextBoxColumn";
            this.supplyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.DataSource = this.suppliersBindingSource;
            this.supplieridDataGridViewTextBoxColumn.DisplayMember = "supplier_name";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplieridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplieridDataGridViewTextBoxColumn.ValueMember = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.arrivaldateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            this.arrivaldateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shipmentdescriptionDataGridViewTextBoxColumn
            // 
            this.shipmentdescriptionDataGridViewTextBoxColumn.DataPropertyName = "shipment_description";
            this.shipmentdescriptionDataGridViewTextBoxColumn.HeaderText = "Описание поставки";
            this.shipmentdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shipmentdescriptionDataGridViewTextBoxColumn.Name = "shipmentdescriptionDataGridViewTextBoxColumn";
            this.shipmentdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.DataSource = this.storesBindingSource;
            this.storeidDataGridViewTextBoxColumn.DisplayMember = "store_name";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.storeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            this.storeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeidDataGridViewTextBoxColumn.ValueMember = "store_id";
            this.storeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // shippingcostDataGridViewTextBoxColumn
            // 
            this.shippingcostDataGridViewTextBoxColumn.DataPropertyName = "shipping_cost";
            this.shippingcostDataGridViewTextBoxColumn.HeaderText = "Стоимость доставки";
            this.shippingcostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shippingcostDataGridViewTextBoxColumn.Name = "shippingcostDataGridViewTextBoxColumn";
            this.shippingcostDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.DataSource = this.employeesBindingSource;
            this.employeeidDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "Ответственный сотрудник";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeidDataGridViewTextBoxColumn.ValueMember = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // ShipmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 471);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ShipmentsView";
            this.Text = "ShipmentsView";
            this.Load += new System.EventHandler(this.ShipmentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private danik_store_dbDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private danik_store_dbDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private danik_store_dbDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private danik_store_dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeidDataGridViewTextBoxColumn;
    }
}