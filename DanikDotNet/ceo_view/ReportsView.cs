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

namespace DanikDotNet.ceo_view
{
    public partial class ReportsView : Form
    {
        public ReportsView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            Form1 form = new Form1();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E1GMR9K;Initial Catalog=danik_store_db;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT " +
                "Employees.full_name AS [ФИО Сотрудника], " +
                "SUM((Products.cost_per_unit + SaleContents.surcharge_percentage/100 * Products.cost_per_unit) * SaleContents.product_quantity) AS [Выручка]" +
                "FROM Employees " +
                "JOIN Sales ON Employees.employee_id = Sales.employee_id " +
                "JOIN SaleContents ON SaleContents.sale_id = Sales.sale_id " +
                "JOIN Products ON Products.product_id = SaleContents.product_id " +
                "WHERE Sales.sale_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Employees.full_name " +
                "ORDER BY [Выручка] DESC;",
                conn);

            cmd.Parameters.AddWithValue("@date1", dateStart.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@date2", dateEnd.Value.ToString("yyyy-MM-dd"));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E1GMR9K;Initial Catalog=danik_store_db;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT " +
                "Stores.store_name AS [Название магазина], " +
                "SUM((Products.cost_per_unit + SaleContents.surcharge_percentage/100 * Products.cost_per_unit) * SaleContents.product_quantity) AS [Выручка]" +
                "FROM Stores " +
                "JOIN Sales ON Stores.store_id = Sales.store_id " +
                "JOIN SaleContents ON SaleContents.sale_id = Sales.sale_id " +
                "JOIN Products ON Products.product_id = SaleContents.product_id " +
                "WHERE Sales.sale_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Stores.store_name " +
                "ORDER BY [Выручка] DESC;",
                conn);

            cmd.Parameters.AddWithValue("@date1", dateStart.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@date2", dateEnd.Value.ToString("yyyy-MM-dd"));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E1GMR9K;Initial Catalog=danik_store_db;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT " +
                "SUM(Products.cost_per_unit) as [Затраты на покупку товаров], " +
                "SUM(Shipment.shipping_cost) as [Затраты на доставку], " +
                "SUM(Products.cost_per_unit + Shipment.shipping_cost) as [ИТОГО] " +
                "FROM Products " +
                "JOIN ShipmentContents ON ShipmentContents.product_id = Products.product_id " +
                "JOIN Shipment ON ShipmentContents.supply_id = Shipment.supply_id " +
                "WHERE Shipment.arrival_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Products.product_id;"
                ,
                conn);

            cmd.Parameters.AddWithValue("@date1", dateStart.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@date2", dateEnd.Value.ToString("yyyy-MM-dd"));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
