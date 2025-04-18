﻿namespace DanikDotNet.ceo_view
{
    partial class SalesView
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
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.SalesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.StoresTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.EmployeesTableAdapter();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Продажи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidDataGridViewTextBoxColumn,
            this.saledateDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.danik_store_dbDataSet;
            // 
            // danik_store_dbDataSet
            // 
            this.danik_store_dbDataSet.DataSetName = "danik_store_dbDataSet";
            this.danik_store_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Состав продажи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "Код продажи";
            this.saleidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleidDataGridViewTextBoxColumn.Width = 150;
            // 
            // saledateDataGridViewTextBoxColumn
            // 
            this.saledateDataGridViewTextBoxColumn.DataPropertyName = "sale_date";
            this.saledateDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.saledateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saledateDataGridViewTextBoxColumn.Name = "saledateDataGridViewTextBoxColumn";
            this.saledateDataGridViewTextBoxColumn.Width = 150;
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
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.DataSource = this.employeesBindingSource;
            this.employeeidDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "Продавец";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeidDataGridViewTextBoxColumn.ValueMember = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SalesView";
            this.Text = "SalesView";
            this.Load += new System.EventHandler(this.SalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private danik_store_dbDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private danik_store_dbDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private danik_store_dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeidDataGridViewTextBoxColumn;
    }
}