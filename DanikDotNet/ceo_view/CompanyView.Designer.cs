namespace DanikDotNet.ceo_view
{
    partial class CompanyView
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
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danikstoredbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.companyTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.CompanyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.storesCompanyStoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.StoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceofullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danikstoredbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesCompanyStoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.danikstoredbDataSetBindingSource;
            // 
            // danikstoredbDataSetBindingSource
            // 
            this.danikstoredbDataSetBindingSource.DataSource = this.danik_store_dbDataSet;
            this.danikstoredbDataSetBindingSource.Position = 0;
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storesCompanyStoresBindingSource
            // 
            this.storesCompanyStoresBindingSource.DataMember = "Stores$CompanyStores";
            this.storesCompanyStoresBindingSource.DataSource = this.companyBindingSource;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyidDataGridViewTextBoxColumn,
            this.ceofullnameDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(63, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.danik_store_dbDataSet;
            // 
            // companyidDataGridViewTextBoxColumn
            // 
            this.companyidDataGridViewTextBoxColumn.DataPropertyName = "company_id";
            this.companyidDataGridViewTextBoxColumn.HeaderText = "company_id";
            this.companyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyidDataGridViewTextBoxColumn.Name = "companyidDataGridViewTextBoxColumn";
            this.companyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // ceofullnameDataGridViewTextBoxColumn
            // 
            this.ceofullnameDataGridViewTextBoxColumn.DataPropertyName = "ceo_full_name";
            this.ceofullnameDataGridViewTextBoxColumn.HeaderText = "ceo_full_name";
            this.ceofullnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ceofullnameDataGridViewTextBoxColumn.Name = "ceofullnameDataGridViewTextBoxColumn";
            this.ceofullnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Компания";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "CompanyView";
            this.Text = "CompanyView";
            this.Load += new System.EventHandler(this.CompanyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danikstoredbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesCompanyStoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource danikstoredbDataSetBindingSource;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private danik_store_dbDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource storesCompanyStoresBindingSource;
        private danik_store_dbDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceofullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}