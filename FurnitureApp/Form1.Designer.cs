namespace FurnitureApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.lblArticle = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();

            // Пошук
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Size = new System.Drawing.Size(50, 20);
            this.lblSearch.Text = "Пошук:";

            this.txtSearch.Location = new System.Drawing.Point(65, 12);
            this.txtSearch.Size = new System.Drawing.Size(250, 22);

            this.btnSearch.Location = new System.Drawing.Point(325, 11);
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.Text = "Знайти";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnReset.Location = new System.Drawing.Point(415, 11);
            this.btnReset.Size = new System.Drawing.Size(85, 25);
            this.btnReset.Text = "Скинути";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Таблиця DataGridView
            this.dgvItems.Location = new System.Drawing.Point(12, 45);
            this.dgvItems.Size = new System.Drawing.Size(560, 420);
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.MultiSelect = false;
            this.dgvItems.ReadOnly = true;

            // Кнопка видалення
            this.btnDelete.Location = new System.Drawing.Point(12, 475);
            this.btnDelete.Size = new System.Drawing.Size(180, 30);
            this.btnDelete.Text = "Видалити обраний";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Поля форми праворуч
            int rightX = 590;
            int inputX = 670;

            this.lblArticle.Location = new System.Drawing.Point(rightX, 50);
            this.lblArticle.Size = new System.Drawing.Size(70, 20);
            this.lblArticle.Text = "Артикул:";
            this.txtArticle.Location = new System.Drawing.Point(inputX, 47);
            this.txtArticle.Size = new System.Drawing.Size(170, 22);

            this.lblTitle.Location = new System.Drawing.Point(rightX, 85);
            this.lblTitle.Size = new System.Drawing.Size(70, 20);
            this.lblTitle.Text = "Назва:";
            this.txtTitle.Location = new System.Drawing.Point(inputX, 82);
            this.txtTitle.Size = new System.Drawing.Size(170, 22);

            this.lblColor.Location = new System.Drawing.Point(rightX, 120);
            this.lblColor.Size = new System.Drawing.Size(70, 20);
            this.lblColor.Text = "Колір:";
            this.txtColor.Location = new System.Drawing.Point(inputX, 117);
            this.txtColor.Size = new System.Drawing.Size(170, 22);

            this.lblPrice.Location = new System.Drawing.Point(rightX, 155);
            this.lblPrice.Size = new System.Drawing.Size(70, 20);
            this.lblPrice.Text = "Ціна:";
            this.numPrice.Location = new System.Drawing.Point(inputX, 152);
            this.numPrice.Size = new System.Drawing.Size(170, 22);
            this.numPrice.Maximum = 1000000;
            this.numPrice.DecimalPlaces = 2;

            this.lblQuantity.Location = new System.Drawing.Point(rightX, 190);
            this.lblQuantity.Size = new System.Drawing.Size(70, 20);
            this.lblQuantity.Text = "Кількість:";
            this.numQuantity.Location = new System.Drawing.Point(inputX, 187);
            this.numQuantity.Size = new System.Drawing.Size(170, 22);
            this.numQuantity.Maximum = 10000;

            // Кнопка додавання
            this.btnAdd.Location = new System.Drawing.Point(rightX, 230);
            this.btnAdd.Size = new System.Drawing.Size(250, 35);
            this.btnAdd.Text = "Додати товар";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Кнопки збереження та завантаження
            this.btnSave.Location = new System.Drawing.Point(rightX, 430);
            this.btnSave.Size = new System.Drawing.Size(250, 32);
            this.btnSave.Text = "Зберегти у файл";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnLoad.Location = new System.Drawing.Point(rightX, 470);
            this.btnLoad.Size = new System.Drawing.Size(250, 32);
            this.btnLoad.Text = "Завантажити з файлу";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // Налаштування головної форми
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Text = "Облік товарів магазину (JYSK)";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}