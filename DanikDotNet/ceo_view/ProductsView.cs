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
    public partial class ProductsView : Form
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.danik_store_dbDataSet.Products);

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
    }
}
