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
    public partial class CompanyView : Form
    {
        public CompanyView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompanyView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.danik_store_dbDataSet.Stores);
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.danik_store_dbDataSet.Company);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Применяем все текущие изменения, если они есть
            this.Validate();
            this.companyBindingSource.EndEdit();

            try
            {
                // Обновляем базу данных, передавая изменения из DataSet
                this.companyTableAdapter.Update(this.danik_store_dbDataSet.Company);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message);
            }
        }

    }
}
