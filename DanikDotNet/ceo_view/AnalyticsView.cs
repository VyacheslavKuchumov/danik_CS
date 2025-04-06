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
    public partial class AnalyticsView : Form
    {
        public AnalyticsView()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E1GMR9K;Initial Catalog=danik_store_db;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT " +
                "Employees.full_name AS [ФИО Сотрудника], " +
                "COUNT(DISTINCT Sales.sale_id) AS [Количество заказов] " +
                "FROM Employees " +
                "JOIN Sales ON Employees.employee_id = Sales.employee_id " +
                "WHERE Sales.sale_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Employees.full_name " +
                "ORDER BY [Количество заказов] DESC;",
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
                "Products.product_name AS [Название товара], " +
                "SUM(SaleContents.product_quantity) AS [Продано штук] " +
                "FROM Products " +
                "JOIN SaleContents ON Products.product_id = SaleContents.product_id " +
                "JOIN Sales ON SaleContents.sale_id = Sales.sale_id " +
                "WHERE Sales.sale_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Products.product_name " +
                "ORDER BY SUM(SaleContents.product_quantity) DESC;",
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
                "Suppliers.supplier_name AS [Название поставщика], " +
                "COUNT(Shipment.supply_id) AS [Кол-во поставок] " +
                "FROM Suppliers " +
                "JOIN Shipment ON Suppliers.supplier_id = Shipment.supplier_id " +
                "WHERE Shipment.arrival_date BETWEEN @date1 AND @date2 " +
                "GROUP BY Suppliers.supplier_name " +
                "ORDER BY COUNT(Shipment.supply_id) DESC;",
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
