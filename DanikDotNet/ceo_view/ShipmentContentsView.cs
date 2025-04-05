using System;
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
    public partial class ShipmentContentsView : Form
    {
        public ShipmentContentsView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            ShipmentsView form = new ShipmentsView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void ShipmentContentsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.danik_store_dbDataSet.Shipment);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.danik_store_dbDataSet.Products);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.ShipmentContents' table. You can move, or remove it, as needed.
            this.shipmentContentsTableAdapter.Fill(this.danik_store_dbDataSet.ShipmentContents);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Завершает редактирование в привязке данных
            this.Validate();
            this.shipmentContentsBindingSource.EndEdit();

            // Обновляет изменения в базе данных
            try
            {
                this.shipmentContentsTableAdapter.Update(this.danik_store_dbDataSet.ShipmentContents);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
    }
}
