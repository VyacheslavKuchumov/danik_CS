﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanikDotNet.ceo_view
{
    public partial class SuppliersView : Form
    {
        public SuppliersView()
        {
            InitializeComponent();
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.danik_store_dbDataSet.Suppliers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            Form1 form = new Form1();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Завершает редактирование в привязке данных
            this.Validate();
            this.suppliersBindingSource.EndEdit();

            // Обновляет изменения в базе данных
            try
            {
                this.suppliersTableAdapter.Update(this.danik_store_dbDataSet.Suppliers);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
    }
}
