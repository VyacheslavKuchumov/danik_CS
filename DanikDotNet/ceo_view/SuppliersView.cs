using Microsoft.Office.Interop.Word;
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
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using Word = Microsoft.Office.Interop.Word;

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

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверка корректности ввода supplier_id
            if (!int.TryParse(textBoxID.SelectedValue.ToString(), out int supplierId))
            {
                MessageBox.Show("Некорректный ID поставщика.");
                
                return;
            }

            // Объявление переменных для хранения данных
            string customerName = "";
            string customerDirector = "";
            string supplierName = "";
            string supplierDirector = "";

            // Получение данных из базы
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E1GMR9K;Initial Catalog=danik_store_db;Integrated Security=True"))
            {
                conn.Open();

                // Запрос данных о компании (Заказчике)
                using (SqlCommand cmd = new SqlCommand("SELECT ceo_full_name, company_name FROM Company", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerDirector = reader["ceo_full_name"].ToString();
                        customerName = reader["company_name"].ToString();
                    }
                }

                // Запрос данных о поставщике по supplier_id
                using (SqlCommand cmd = new SqlCommand("SELECT supplier_name, ceo_full_name FROM Suppliers WHERE supplier_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplierName = reader["supplier_name"].ToString();
                            supplierDirector = reader["ceo_full_name"].ToString();
                        }
                    }
                }
            }

            // Создание документа Word и добавление параграфов с использованием полученных данных
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();
            wordApp.Visible = true;

            // Локальная функция для добавления параграфа
            void AddParagraph(string text, bool bold = false, Word.WdParagraphAlignment alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft)
            {
                Word.Paragraph paragraph = doc.Content.Paragraphs.Add();
                paragraph.Range.Text = text;
                paragraph.Range.Bold = bold ? 1 : 0;
                paragraph.Alignment = alignment;
                paragraph.Range.InsertParagraphAfter();
            }

            AddParagraph("Договор поставки", true, Word.WdParagraphAlignment.wdAlignParagraphCenter);
            AddParagraph("г. [Город]                                                                                \"__\" __________ 2024 г.", false, Word.WdParagraphAlignment.wdAlignParagraphLeft);

            AddParagraph("1. Стороны договора", true);
            AddParagraph($"1.1. Поставщик: {supplierName}");
            AddParagraph($"1.2. Директор Поставщика: {supplierDirector}");
            AddParagraph($"1.3. Заказчик: {customerName}");
            AddParagraph($"1.4. Директор Заказчика: {customerDirector}");

            AddParagraph("2. Предмет договора", true);
            AddParagraph("2.1. Поставщик обязуется поставить Заказчику товары согласно спецификации, указанной в Приложении №1 к настоящему договору, а Заказчик обязуется принять и оплатить указанные товары на условиях настоящего договора.");

            AddParagraph("3. Сроки и условия поставки", true);
            AddParagraph("3.1. Срок поставки товаров: ________.");
            AddParagraph("3.2. Условия поставки: ________.");

            AddParagraph("4. Стоимость и порядок расчетов", true);
            AddParagraph("4.1. Общая стоимость товаров составляет ________.");
            AddParagraph("4.2. Порядок расчетов: ________.");

            AddParagraph("5. Права и обязанности сторон", true);
            AddParagraph("5.1. Поставщик обязуется:");
            AddParagraph("- Поставить товары надлежащего качества и в срок.");
            AddParagraph("- Предоставить все необходимые документы на товары.");
            AddParagraph("5.2. Заказчик обязуется:");
            AddParagraph("- Принять и оплатить поставленные товары в соответствии с условиями настоящего договора.");

            AddParagraph("6. Ответственность сторон", true);
            AddParagraph("6.1. В случае нарушения условий договора стороны несут ответственность в соответствии с действующим законодательством Российской Федерации.");

            AddParagraph("7. Прочие условия", true);
            AddParagraph("7.1. Все изменения и дополнения к настоящему договору действительны только при наличии письменного согласия обеих сторон.");
            AddParagraph("7.2. Настоящий договор составлен в двух экземплярах, имеющих равную юридическую силу, по одному для каждой из сторон.");

            AddParagraph("8. Реквизиты и подписи сторон", true);
            AddParagraph($"Поставщик:\nНазвание: {supplierName}\nДиректор: {supplierDirector}\nПодпись: ___________________");
            AddParagraph($"Заказчик:\nНазвание: {customerName}\nДиректор: {customerDirector}\nПодпись: ___________________");

            MessageBox.Show("Отчет создан!");
        }

        private void textBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
