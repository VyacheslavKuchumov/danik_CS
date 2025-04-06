using DanikDotNet.ceo_view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanikDotNet.warehouse_worker
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            MainMenu form = new MainMenu();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            SalesView form = new SalesView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            ProductsView form = new ProductsView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            ShipmentsView form = new ShipmentsView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            StoresView form = new StoresView();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }
    }
}
