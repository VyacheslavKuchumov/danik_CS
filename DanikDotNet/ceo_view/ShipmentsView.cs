using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using Word = Microsoft.Office.Interop.Word;


namespace DanikDotNet.ceo_view
{
    public partial class ShipmentsView : Form
    {
        public ShipmentsView()
        {
            InitializeComponent();
        }

        private void ShipmentsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.danik_store_dbDataSet.Employees);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.danik_store_dbDataSet.Stores);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.danik_store_dbDataSet.Suppliers);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.danik_store_dbDataSet.Shipment);

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

        private void button3_Click(object sender, EventArgs e)
        {
            // Завершает редактирование в привязке данных
            this.Validate();
            this.shipmentBindingSource.EndEdit();

            // Обновляет изменения в базе данных
            try
            {
                this.shipmentTableAdapter.Update(this.danik_store_dbDataSet.Shipment);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            ShipmentContentsView form = new ShipmentContentsView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }
        

    }
}
