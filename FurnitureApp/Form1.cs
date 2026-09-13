using System;
using System.Windows.Forms;

namespace FurnitureApp
{
    public partial class Form1 : Form
    {
        private FurnitureService _service = new FurnitureService();
        private const string DataFilePath = "furniture_items.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _service.LoadFromFile(DataFilePath);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = _service.Items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string article = txtArticle.Text.Trim();
                string title = txtTitle.Text.Trim();
                string color = txtColor.Text.Trim();
                decimal price = numPrice.Value;
                int quantity = (int)numQuantity.Value;

                if (string.IsNullOrWhiteSpace(article) || string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Будь ласка, заповніть артикул та назву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InteriorItem newItem = new InteriorItem(article, title, price, quantity, color);
                _service.AddItem(newItem);

                UpdateGrid();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow != null)
            {
                InteriorItem selectedItem = dgvItems.CurrentRow.DataBoundItem as InteriorItem;
                if (selectedItem != null)
                {
                    _service.RemoveItemByArticle(selectedItem.ArticleNumber);
                    UpdateGrid();
                }
            }
            else
            {
                MessageBox.Show("Оберіть товар у таблиці для видалення.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                dgvItems.DataSource = null;
                dgvItems.DataSource = _service.SearchByTitle(query);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            UpdateGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _service.SaveToFile(DataFilePath);
            MessageBox.Show("Дані успішно збережено у файл!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _service.LoadFromFile(DataFilePath);
            UpdateGrid();
            MessageBox.Show("Дані успішно завантажено з файлу!", "Завантаження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputFields()
        {
            txtArticle.Clear();
            txtTitle.Clear();
            txtColor.Clear();
            numPrice.Value = 0;
            numQuantity.Value = 0;
        }
    }
}