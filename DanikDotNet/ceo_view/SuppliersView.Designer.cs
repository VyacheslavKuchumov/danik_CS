﻿namespace DanikDotNet.ceo_view
{
    partial class SuppliersView
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
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danik_store_dbDataSet = new DanikDotNet.danik_store_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.suppliersTableAdapter = new DanikDotNet.danik_store_dbDataSetTableAdapters.SuppliersTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceofullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поставщики";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.ceofullnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suppliersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 235);
            this.dataGridView1.TabIndex = 8;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.danik_store_dbDataSet;
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
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(455, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Договор";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplieridDataGridViewTextBoxColumn.Visible = false;
            this.supplieridDataGridViewTextBoxColumn.Width = 150;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Название поставщика ";
            this.suppliernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Контактный телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // ceofullnameDataGridViewTextBoxColumn
            // 
            this.ceofullnameDataGridViewTextBoxColumn.DataPropertyName = "ceo_full_name";
            this.ceofullnameDataGridViewTextBoxColumn.HeaderText = "ФИО директора";
            this.ceofullnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ceofullnameDataGridViewTextBoxColumn.Name = "ceofullnameDataGridViewTextBoxColumn";
            this.ceofullnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // textBoxID
            // 
            this.textBoxID.DataSource = this.suppliersBindingSource1;
            this.textBoxID.DisplayMember = "supplier_name";
            this.textBoxID.FormattingEnabled = true;
            this.textBoxID.Location = new System.Drawing.Point(328, 46);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 28);
            this.textBoxID.TabIndex = 23;
            this.textBoxID.ValueMember = "supplier_id";
            this.textBoxID.SelectedIndexChanged += new System.EventHandler(this.textBoxID_SelectedIndexChanged);
            // 
            // suppliersBindingSource1
            // 
            this.suppliersBindingSource1.DataMember = "Suppliers";
            this.suppliersBindingSource1.DataSource = this.danik_store_dbDataSet;
            // 
            // SuppliersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SuppliersView";
            this.Text = "SuppliersView";
            this.Load += new System.EventHandler(this.SuppliersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danik_store_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private danik_store_dbDataSet danik_store_dbDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private danik_store_dbDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceofullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox textBoxID;
        private System.Windows.Forms.BindingSource suppliersBindingSource1;
    }
}