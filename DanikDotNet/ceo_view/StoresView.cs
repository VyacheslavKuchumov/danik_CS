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
    public partial class StoresView : Form
    {
        public StoresView()
        {
            InitializeComponent();
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

        private void StoresView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danik_store_dbDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.danik_store_dbDataSet.Stores);

        }
    }
}
