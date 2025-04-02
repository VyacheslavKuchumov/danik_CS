namespace DanikDotNet.ceo_view
{
    partial class StoresView
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
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.StoresTableAdapter();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Магазины";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeidDataGridViewTextBoxColumn,
            this.storenameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.companyidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "store_id";
            this.storeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            this.storeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // storenameDataGridViewTextBoxColumn
            // 
            this.storenameDataGridViewTextBoxColumn.DataPropertyName = "store_name";
            this.storenameDataGridViewTextBoxColumn.HeaderText = "store_name";
            this.storenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.storenameDataGridViewTextBoxColumn.Name = "storenameDataGridViewTextBoxColumn";
            this.storenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyidDataGridViewTextBoxColumn
            // 
            this.companyidDataGridViewTextBoxColumn.DataPropertyName = "company_id";
            this.companyidDataGridViewTextBoxColumn.HeaderText = "company_id";
            this.companyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyidDataGridViewTextBoxColumn.Name = "companyidDataGridViewTextBoxColumn";
            this.companyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // StoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "StoresView";
            this.Text = "StoresView";
            this.Load += new System.EventHandler(this.StoresView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private danik_store_dbDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyidDataGridViewTextBoxColumn;
    }
}