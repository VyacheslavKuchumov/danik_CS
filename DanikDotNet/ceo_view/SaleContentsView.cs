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
    public partial class SaleContentsView : Form
    {
        public SaleContentsView()
        {
            InitializeComponent();
        }

        private void SaleContentsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.danik_store_dbDataSet.Sales);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.danik_store_dbDataSet.Products);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.SaleContents' table. You can move, or remove it, as needed.
            this.saleContentsTableAdapter.Fill(this.danik_store_dbDataSet.SaleContents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            SalesView form = new SalesView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Завершает редактирование в привязке данных
            this.Validate();
            this.saleContentsBindingSource.EndEdit();

            // Обновляет изменения в базе данных
            try
            {
                this.saleContentsTableAdapter.Update(this.danik_store_dbDataSet.SaleContents);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
    }
}
