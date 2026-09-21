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
            dgvItems = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            lblArticle = new Label();
            txtArticle = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblColor = new Label();
            txtColor = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeight = 29;
            dgvItems.Location = new Point(12, 45);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(560, 420);
            dgvItems.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(12, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Пошук:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(344, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Знайти";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(435, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 25);
            btnReset.TabIndex = 3;
            btnReset.Text = "Скинути";
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Видалити обраний";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblArticle
            // 
            lblArticle.Location = new Point(590, 50);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(70, 20);
            lblArticle.TabIndex = 6;
            lblArticle.Text = "Артикул:";
            // 
            // txtArticle
            // 
            txtArticle.Location = new Point(670, 47);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(170, 27);
            txtArticle.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(590, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Назва:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(670, 82);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(170, 27);
            txtTitle.TabIndex = 9;
            // 
            // lblColor
            // 
            lblColor.Location = new Point(590, 120);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(70, 20);
            lblColor.TabIndex = 10;
            lblColor.Text = "Колір:";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(670, 117);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(170, 27);
            txtColor.TabIndex = 11;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(590, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 20);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Ціна:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(670, 152);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(170, 27);
            numPrice.TabIndex = 13;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(590, 190);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 20);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Кількість:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(670, 187);
            numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(170, 27);
            numQuantity.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(590, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 35);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Додати товар";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(590, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 32);
            btnSave.TabIndex = 17;
            btnSave.Text = "Зберегти у файл";
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(590, 470);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(250, 32);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Завантажити з файлу";
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(860, 520);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(dgvItems);
            Controls.Add(btnDelete);
            Controls.Add(lblArticle);
            Controls.Add(txtArticle);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Облік товарів магазину (JYSK)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
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