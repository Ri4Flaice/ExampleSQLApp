namespace ExampleSQLApp
{
    partial class AddFinanceDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.textMenuLabel = new System.Windows.Forms.Label();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.exitMenuPicture = new System.Windows.Forms.PictureBox();
            this.inputDataPanel = new System.Windows.Forms.Panel();
            this.inputStatusTextBox = new System.Windows.Forms.TextBox();
            this.inputFullNameTextBox = new System.Windows.Forms.TextBox();
            this.inputDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputProductsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputCategoryTextBox = new System.Windows.Forms.TextBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.inputCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.inputTotalTextBox = new System.Windows.Forms.TextBox();
            this.DateOperationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inputTypeTextBox = new System.Windows.Forms.TextBox();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.viewDataPanel = new System.Windows.Forms.Panel();
            this.statusOperationLabel = new System.Windows.Forms.Label();
            this.valueStatusOperationLabel = new System.Windows.Forms.Label();
            this.sendToDbButton = new System.Windows.Forms.Button();
            this.valueDescriptionOperationLabel = new System.Windows.Forms.Label();
            this.descriptionOperationLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.valueFullNameLabel = new System.Windows.Forms.Label();
            this.productsOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productsOperationLabel = new System.Windows.Forms.Label();
            this.valueProductsOperationLabel = new System.Windows.Forms.Label();
            this.categoryOperationLabel = new System.Windows.Forms.Label();
            this.valueCategoryOperationLabel = new System.Windows.Forms.Label();
            this.valueTypeOperationLabel = new System.Windows.Forms.Label();
            this.typeOperationLabel = new System.Windows.Forms.Label();
            this.dateOperationLabel = new System.Windows.Forms.Label();
            this.valueDateOperationLabel = new System.Windows.Forms.Label();
            this.NameOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameOperationLabel = new System.Windows.Forms.Label();
            this.valueNameOperationLabel = new System.Windows.Forms.Label();
            this.CurrencyOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.totalOperationLabel = new System.Windows.Forms.Label();
            this.valueTotalOperationLabel = new System.Windows.Forms.Label();
            this.valueCurrencyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
            this.inputDataPanel.SuspendLayout();
            this.viewDataPanel.SuspendLayout();
            this.productsOperationFlowLayoutPanel.SuspendLayout();
            this.NameOperationFlowLayoutPanel.SuspendLayout();
            this.CurrencyOperationFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(177)))), ((int)(((byte)(217)))));
            this.menuPanel.Controls.Add(this.textMenuLabel);
            this.menuPanel.Controls.Add(this.ExitPictureBox);
            this.menuPanel.Controls.Add(this.exitMenuPicture);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1632, 60);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            // 
            // textMenuLabel
            // 
            this.textMenuLabel.AutoSize = true;
            this.textMenuLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMenuLabel.Location = new System.Drawing.Point(659, 13);
            this.textMenuLabel.Name = "textMenuLabel";
            this.textMenuLabel.Size = new System.Drawing.Size(221, 33);
            this.textMenuLabel.TabIndex = 2;
            this.textMenuLabel.Text = "Добавить данные";
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPictureBox.Image = global::ExampleSQLApp.Properties.Resources.exit;
            this.ExitPictureBox.Location = new System.Drawing.Point(1567, 3);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(53, 54);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPictureBox.TabIndex = 1;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // exitMenuPicture
            // 
            this.exitMenuPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMenuPicture.Image = global::ExampleSQLApp.Properties.Resources.logo2;
            this.exitMenuPicture.Location = new System.Drawing.Point(3, 3);
            this.exitMenuPicture.Name = "exitMenuPicture";
            this.exitMenuPicture.Size = new System.Drawing.Size(57, 54);
            this.exitMenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitMenuPicture.TabIndex = 0;
            this.exitMenuPicture.TabStop = false;
            this.exitMenuPicture.Click += new System.EventHandler(this.exitMenuPicture_Click);
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.Controls.Add(this.inputStatusTextBox);
            this.inputDataPanel.Controls.Add(this.inputFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.inputDescriptionRichTextBox);
            this.inputDataPanel.Controls.Add(this.inputProductsRichTextBox);
            this.inputDataPanel.Controls.Add(this.inputCategoryTextBox);
            this.inputDataPanel.Controls.Add(this.currencyLabel);
            this.inputDataPanel.Controls.Add(this.inputCurrencyTextBox);
            this.inputDataPanel.Controls.Add(this.inputTotalTextBox);
            this.inputDataPanel.Controls.Add(this.DateOperationTimePicker);
            this.inputDataPanel.Controls.Add(this.inputTypeTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameTextBox);
            this.inputDataPanel.Location = new System.Drawing.Point(3, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(716, 624);
            this.inputDataPanel.TabIndex = 1;
            // 
            // inputStatusTextBox
            // 
            this.inputStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStatusTextBox.Location = new System.Drawing.Point(9, 412);
            this.inputStatusTextBox.Multiline = true;
            this.inputStatusTextBox.Name = "inputStatusTextBox";
            this.inputStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputStatusTextBox.TabIndex = 13;
            this.inputStatusTextBox.TextChanged += new System.EventHandler(this.inputStatusTextBox_TextChanged);
            this.inputStatusTextBox.Enter += new System.EventHandler(this.inputStatusTextBox_Enter);
            this.inputStatusTextBox.Leave += new System.EventHandler(this.inputStatusTextBox_Leave);
            // 
            // inputFullNameTextBox
            // 
            this.inputFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFullNameTextBox.Location = new System.Drawing.Point(9, 462);
            this.inputFullNameTextBox.Multiline = true;
            this.inputFullNameTextBox.Name = "inputFullNameTextBox";
            this.inputFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputFullNameTextBox.TabIndex = 12;
            this.inputFullNameTextBox.TextChanged += new System.EventHandler(this.inputFullNameTextBox_TextChanged);
            this.inputFullNameTextBox.Enter += new System.EventHandler(this.inputFullNameTextBox_Enter);
            this.inputFullNameTextBox.Leave += new System.EventHandler(this.inputFullNameTextBox_Leave);
            // 
            // inputDescriptionRichTextBox
            // 
            this.inputDescriptionRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDescriptionRichTextBox.Location = new System.Drawing.Point(9, 520);
            this.inputDescriptionRichTextBox.Name = "inputDescriptionRichTextBox";
            this.inputDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.inputDescriptionRichTextBox.TabIndex = 11;
            this.inputDescriptionRichTextBox.Text = "";
            this.inputDescriptionRichTextBox.TextChanged += new System.EventHandler(this.inputDescriptionRichTextBox_TextChanged);
            this.inputDescriptionRichTextBox.Enter += new System.EventHandler(this.inputDescriptionRichTextBox_Enter);
            this.inputDescriptionRichTextBox.Leave += new System.EventHandler(this.inputDescriptionRichTextBox_Leave);
            // 
            // inputProductsRichTextBox
            // 
            this.inputProductsRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputProductsRichTextBox.Location = new System.Drawing.Point(9, 297);
            this.inputProductsRichTextBox.Name = "inputProductsRichTextBox";
            this.inputProductsRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.inputProductsRichTextBox.TabIndex = 10;
            this.inputProductsRichTextBox.Text = "";
            this.inputProductsRichTextBox.TextChanged += new System.EventHandler(this.inputProductsRichTextBox_TextChanged);
            this.inputProductsRichTextBox.Enter += new System.EventHandler(this.inputProductsRichTextBox_Enter);
            this.inputProductsRichTextBox.Leave += new System.EventHandler(this.inputProductsRichTextBox_Leave);
            // 
            // inputCategoryTextBox
            // 
            this.inputCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCategoryTextBox.Location = new System.Drawing.Point(9, 234);
            this.inputCategoryTextBox.Multiline = true;
            this.inputCategoryTextBox.Name = "inputCategoryTextBox";
            this.inputCategoryTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputCategoryTextBox.TabIndex = 9;
            this.inputCategoryTextBox.TextChanged += new System.EventHandler(this.inputCategoryTextBox_TextChanged);
            this.inputCategoryTextBox.Enter += new System.EventHandler(this.inputCategoryTextBox_Enter);
            this.inputCategoryTextBox.Leave += new System.EventHandler(this.inputCategoryTextBox_Leave);
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyLabel.Location = new System.Drawing.Point(374, 177);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(127, 36);
            this.currencyLabel.TabIndex = 8;
            this.currencyLabel.Text = "Валюта:";
            // 
            // inputCurrencyTextBox
            // 
            this.inputCurrencyTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCurrencyTextBox.Location = new System.Drawing.Point(507, 174);
            this.inputCurrencyTextBox.MaxLength = 3;
            this.inputCurrencyTextBox.Multiline = true;
            this.inputCurrencyTextBox.Name = "inputCurrencyTextBox";
            this.inputCurrencyTextBox.Size = new System.Drawing.Size(124, 39);
            this.inputCurrencyTextBox.TabIndex = 7;
            this.inputCurrencyTextBox.TextChanged += new System.EventHandler(this.inputCurrencyTextBox_TextChanged);
            // 
            // inputTotalTextBox
            // 
            this.inputTotalTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTotalTextBox.Location = new System.Drawing.Point(9, 174);
            this.inputTotalTextBox.Multiline = true;
            this.inputTotalTextBox.Name = "inputTotalTextBox";
            this.inputTotalTextBox.Size = new System.Drawing.Size(352, 39);
            this.inputTotalTextBox.TabIndex = 6;
            this.inputTotalTextBox.TextChanged += new System.EventHandler(this.inputTotalTextBox_TextChanged);
            this.inputTotalTextBox.Enter += new System.EventHandler(this.inputTotalTextBox_Enter);
            this.inputTotalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTotalTextBox_KeyPress);
            this.inputTotalTextBox.Leave += new System.EventHandler(this.inputTotalTextBox_Leave);
            // 
            // DateOperationTimePicker
            // 
            this.DateOperationTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOperationTimePicker.Location = new System.Drawing.Point(9, 55);
            this.DateOperationTimePicker.Name = "DateOperationTimePicker";
            this.DateOperationTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateOperationTimePicker.TabIndex = 3;
            this.DateOperationTimePicker.ValueChanged += new System.EventHandler(this.DateOperationTimePicker_ValueChanged);
            // 
            // inputTypeTextBox
            // 
            this.inputTypeTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTypeTextBox.Location = new System.Drawing.Point(9, 112);
            this.inputTypeTextBox.Multiline = true;
            this.inputTypeTextBox.Name = "inputTypeTextBox";
            this.inputTypeTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputTypeTextBox.TabIndex = 4;
            this.inputTypeTextBox.TextChanged += new System.EventHandler(this.inputTypeTextBox_TextChanged);
            this.inputTypeTextBox.Enter += new System.EventHandler(this.inputTypeTextBox_Enter);
            this.inputTypeTextBox.Leave += new System.EventHandler(this.inputTypeTextBox_Leave);
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameTextBox.Location = new System.Drawing.Point(9, 3);
            this.inputNameTextBox.Multiline = true;
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameTextBox.TabIndex = 0;
            this.inputNameTextBox.TextChanged += new System.EventHandler(this.inputNameTextBox_TextChanged);
            this.inputNameTextBox.Enter += new System.EventHandler(this.inputNameTextBox_Enter);
            this.inputNameTextBox.Leave += new System.EventHandler(this.inputNameTextBox_Leave);
            // 
            // viewDataPanel
            // 
            this.viewDataPanel.Controls.Add(this.statusOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueStatusOperationLabel);
            this.viewDataPanel.Controls.Add(this.sendToDbButton);
            this.viewDataPanel.Controls.Add(this.valueDescriptionOperationLabel);
            this.viewDataPanel.Controls.Add(this.descriptionOperationLabel);
            this.viewDataPanel.Controls.Add(this.fullNameLabel);
            this.viewDataPanel.Controls.Add(this.valueFullNameLabel);
            this.viewDataPanel.Controls.Add(this.productsOperationFlowLayoutPanel);
            this.viewDataPanel.Controls.Add(this.categoryOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueCategoryOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueTypeOperationLabel);
            this.viewDataPanel.Controls.Add(this.typeOperationLabel);
            this.viewDataPanel.Controls.Add(this.dateOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueDateOperationLabel);
            this.viewDataPanel.Controls.Add(this.NameOperationFlowLayoutPanel);
            this.viewDataPanel.Location = new System.Drawing.Point(829, 66);
            this.viewDataPanel.Name = "viewDataPanel";
            this.viewDataPanel.Size = new System.Drawing.Size(803, 624);
            this.viewDataPanel.TabIndex = 2;
            // 
            // statusOperationLabel
            // 
            this.statusOperationLabel.AutoSize = true;
            this.statusOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusOperationLabel.Location = new System.Drawing.Point(6, 418);
            this.statusOperationLabel.Name = "statusOperationLabel";
            this.statusOperationLabel.Size = new System.Drawing.Size(109, 33);
            this.statusOperationLabel.TabIndex = 18;
            this.statusOperationLabel.Text = "Статус: ";
            // 
            // valueStatusOperationLabel
            // 
            this.valueStatusOperationLabel.AutoSize = true;
            this.valueStatusOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusOperationLabel.Location = new System.Drawing.Point(121, 418);
            this.valueStatusOperationLabel.Name = "valueStatusOperationLabel";
            this.valueStatusOperationLabel.Size = new System.Drawing.Size(79, 33);
            this.valueStatusOperationLabel.TabIndex = 17;
            this.valueStatusOperationLabel.Text = "status";
            this.valueStatusOperationLabel.Visible = false;
            // 
            // sendToDbButton
            // 
            this.sendToDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.sendToDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendToDbButton.FlatAppearance.BorderSize = 0;
            this.sendToDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendToDbButton.Location = new System.Drawing.Point(662, 559);
            this.sendToDbButton.Name = "sendToDbButton";
            this.sendToDbButton.Size = new System.Drawing.Size(129, 41);
            this.sendToDbButton.TabIndex = 16;
            this.sendToDbButton.Text = "Отправить";
            this.sendToDbButton.UseVisualStyleBackColor = false;
            this.sendToDbButton.Click += new System.EventHandler(this.sendToDbButton_Click);
            // 
            // valueDescriptionOperationLabel
            // 
            this.valueDescriptionOperationLabel.AutoSize = true;
            this.valueDescriptionOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDescriptionOperationLabel.Location = new System.Drawing.Point(155, 501);
            this.valueDescriptionOperationLabel.Name = "valueDescriptionOperationLabel";
            this.valueDescriptionOperationLabel.Size = new System.Drawing.Size(139, 33);
            this.valueDescriptionOperationLabel.TabIndex = 15;
            this.valueDescriptionOperationLabel.Text = "description";
            this.valueDescriptionOperationLabel.Visible = false;
            // 
            // descriptionOperationLabel
            // 
            this.descriptionOperationLabel.AutoSize = true;
            this.descriptionOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionOperationLabel.Location = new System.Drawing.Point(3, 501);
            this.descriptionOperationLabel.Name = "descriptionOperationLabel";
            this.descriptionOperationLabel.Size = new System.Drawing.Size(146, 33);
            this.descriptionOperationLabel.TabIndex = 14;
            this.descriptionOperationLabel.Text = "Описание: ";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(6, 462);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(91, 33);
            this.fullNameLabel.TabIndex = 13;
            this.fullNameLabel.Text = "ФИО: ";
            // 
            // valueFullNameLabel
            // 
            this.valueFullNameLabel.AutoSize = true;
            this.valueFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameLabel.Location = new System.Drawing.Point(103, 462);
            this.valueFullNameLabel.Name = "valueFullNameLabel";
            this.valueFullNameLabel.Size = new System.Drawing.Size(118, 33);
            this.valueFullNameLabel.TabIndex = 12;
            this.valueFullNameLabel.Text = "fullName";
            this.valueFullNameLabel.Visible = false;
            // 
            // productsOperationFlowLayoutPanel
            // 
            this.productsOperationFlowLayoutPanel.Controls.Add(this.productsOperationLabel);
            this.productsOperationFlowLayoutPanel.Controls.Add(this.valueProductsOperationLabel);
            this.productsOperationFlowLayoutPanel.Location = new System.Drawing.Point(3, 355);
            this.productsOperationFlowLayoutPanel.Name = "productsOperationFlowLayoutPanel";
            this.productsOperationFlowLayoutPanel.Size = new System.Drawing.Size(788, 60);
            this.productsOperationFlowLayoutPanel.TabIndex = 11;
            // 
            // productsOperationLabel
            // 
            this.productsOperationLabel.AutoSize = true;
            this.productsOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsOperationLabel.Location = new System.Drawing.Point(3, 0);
            this.productsOperationLabel.Name = "productsOperationLabel";
            this.productsOperationLabel.Size = new System.Drawing.Size(116, 33);
            this.productsOperationLabel.TabIndex = 11;
            this.productsOperationLabel.Text = "Товары: ";
            // 
            // valueProductsOperationLabel
            // 
            this.valueProductsOperationLabel.AutoSize = true;
            this.valueProductsOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueProductsOperationLabel.Location = new System.Drawing.Point(125, 0);
            this.valueProductsOperationLabel.Name = "valueProductsOperationLabel";
            this.valueProductsOperationLabel.Size = new System.Drawing.Size(118, 33);
            this.valueProductsOperationLabel.TabIndex = 12;
            this.valueProductsOperationLabel.Text = "products ";
            this.valueProductsOperationLabel.Visible = false;
            // 
            // categoryOperationLabel
            // 
            this.categoryOperationLabel.AutoSize = true;
            this.categoryOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryOperationLabel.Location = new System.Drawing.Point(6, 302);
            this.categoryOperationLabel.Name = "categoryOperationLabel";
            this.categoryOperationLabel.Size = new System.Drawing.Size(269, 33);
            this.categoryOperationLabel.TabIndex = 10;
            this.categoryOperationLabel.Text = "Категория операции: ";
            // 
            // valueCategoryOperationLabel
            // 
            this.valueCategoryOperationLabel.AutoSize = true;
            this.valueCategoryOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCategoryOperationLabel.Location = new System.Drawing.Point(281, 302);
            this.valueCategoryOperationLabel.Name = "valueCategoryOperationLabel";
            this.valueCategoryOperationLabel.Size = new System.Drawing.Size(108, 33);
            this.valueCategoryOperationLabel.TabIndex = 9;
            this.valueCategoryOperationLabel.Text = "category";
            this.valueCategoryOperationLabel.Visible = false;
            // 
            // valueTypeOperationLabel
            // 
            this.valueTypeOperationLabel.AutoSize = true;
            this.valueTypeOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTypeOperationLabel.Location = new System.Drawing.Point(203, 200);
            this.valueTypeOperationLabel.Name = "valueTypeOperationLabel";
            this.valueTypeOperationLabel.Size = new System.Drawing.Size(62, 33);
            this.valueTypeOperationLabel.TabIndex = 6;
            this.valueTypeOperationLabel.Text = "type";
            this.valueTypeOperationLabel.Visible = false;
            // 
            // typeOperationLabel
            // 
            this.typeOperationLabel.AutoSize = true;
            this.typeOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOperationLabel.Location = new System.Drawing.Point(3, 200);
            this.typeOperationLabel.Name = "typeOperationLabel";
            this.typeOperationLabel.Size = new System.Drawing.Size(194, 33);
            this.typeOperationLabel.TabIndex = 5;
            this.typeOperationLabel.Text = "Тип операции: ";
            // 
            // dateOperationLabel
            // 
            this.dateOperationLabel.AutoSize = true;
            this.dateOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOperationLabel.Location = new System.Drawing.Point(1, 154);
            this.dateOperationLabel.Name = "dateOperationLabel";
            this.dateOperationLabel.Size = new System.Drawing.Size(203, 33);
            this.dateOperationLabel.TabIndex = 4;
            this.dateOperationLabel.Text = "Дата операции: ";
            // 
            // valueDateOperationLabel
            // 
            this.valueDateOperationLabel.AutoSize = true;
            this.valueDateOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDateOperationLabel.Location = new System.Drawing.Point(210, 154);
            this.valueDateOperationLabel.Name = "valueDateOperationLabel";
            this.valueDateOperationLabel.Size = new System.Drawing.Size(61, 33);
            this.valueDateOperationLabel.TabIndex = 3;
            this.valueDateOperationLabel.Text = "date";
            this.valueDateOperationLabel.Visible = false;
            // 
            // NameOperationFlowLayoutPanel
            // 
            this.NameOperationFlowLayoutPanel.Controls.Add(this.nameOperationLabel);
            this.NameOperationFlowLayoutPanel.Controls.Add(this.valueNameOperationLabel);
            this.NameOperationFlowLayoutPanel.Location = new System.Drawing.Point(0, 56);
            this.NameOperationFlowLayoutPanel.Name = "NameOperationFlowLayoutPanel";
            this.NameOperationFlowLayoutPanel.Size = new System.Drawing.Size(797, 95);
            this.NameOperationFlowLayoutPanel.TabIndex = 2;
            // 
            // nameOperationLabel
            // 
            this.nameOperationLabel.AutoSize = true;
            this.nameOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOperationLabel.Location = new System.Drawing.Point(3, 0);
            this.nameOperationLabel.Name = "nameOperationLabel";
            this.nameOperationLabel.Size = new System.Drawing.Size(321, 33);
            this.nameOperationLabel.TabIndex = 0;
            this.nameOperationLabel.Text = "Наименование операции: ";
            // 
            // valueNameOperationLabel
            // 
            this.valueNameOperationLabel.AutoSize = true;
            this.valueNameOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameOperationLabel.Location = new System.Drawing.Point(330, 0);
            this.valueNameOperationLabel.Name = "valueNameOperationLabel";
            this.valueNameOperationLabel.Size = new System.Drawing.Size(73, 33);
            this.valueNameOperationLabel.TabIndex = 1;
            this.valueNameOperationLabel.Text = "name";
            this.valueNameOperationLabel.Visible = false;
            // 
            // CurrencyOperationFlowLayoutPanel
            // 
            this.CurrencyOperationFlowLayoutPanel.Controls.Add(this.totalOperationLabel);
            this.CurrencyOperationFlowLayoutPanel.Controls.Add(this.valueTotalOperationLabel);
            this.CurrencyOperationFlowLayoutPanel.Controls.Add(this.valueCurrencyLabel);
            this.CurrencyOperationFlowLayoutPanel.Location = new System.Drawing.Point(829, 317);
            this.CurrencyOperationFlowLayoutPanel.Name = "CurrencyOperationFlowLayoutPanel";
            this.CurrencyOperationFlowLayoutPanel.Size = new System.Drawing.Size(669, 48);
            this.CurrencyOperationFlowLayoutPanel.TabIndex = 11;
            // 
            // totalOperationLabel
            // 
            this.totalOperationLabel.AutoSize = true;
            this.totalOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalOperationLabel.Location = new System.Drawing.Point(3, 0);
            this.totalOperationLabel.Name = "totalOperationLabel";
            this.totalOperationLabel.Size = new System.Drawing.Size(228, 33);
            this.totalOperationLabel.TabIndex = 8;
            this.totalOperationLabel.Text = "Сумма операции: ";
            // 
            // valueTotalOperationLabel
            // 
            this.valueTotalOperationLabel.AutoSize = true;
            this.valueTotalOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTotalOperationLabel.Location = new System.Drawing.Point(237, 0);
            this.valueTotalOperationLabel.Name = "valueTotalOperationLabel";
            this.valueTotalOperationLabel.Size = new System.Drawing.Size(65, 33);
            this.valueTotalOperationLabel.TabIndex = 7;
            this.valueTotalOperationLabel.Text = "total";
            this.valueTotalOperationLabel.Visible = false;
            // 
            // valueCurrencyLabel
            // 
            this.valueCurrencyLabel.AutoSize = true;
            this.valueCurrencyLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCurrencyLabel.Location = new System.Drawing.Point(308, 0);
            this.valueCurrencyLabel.Name = "valueCurrencyLabel";
            this.valueCurrencyLabel.Size = new System.Drawing.Size(110, 33);
            this.valueCurrencyLabel.TabIndex = 12;
            this.valueCurrencyLabel.Text = "currency";
            this.valueCurrencyLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.doubleLine;
            this.pictureBox1.Location = new System.Drawing.Point(725, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddFinanceDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CurrencyOperationFlowLayoutPanel);
            this.Controls.Add(this.viewDataPanel);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFinanceDataForm";
            this.Text = "AddFinanceDataForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.viewDataPanel.ResumeLayout(false);
            this.viewDataPanel.PerformLayout();
            this.productsOperationFlowLayoutPanel.ResumeLayout(false);
            this.productsOperationFlowLayoutPanel.PerformLayout();
            this.NameOperationFlowLayoutPanel.ResumeLayout(false);
            this.NameOperationFlowLayoutPanel.PerformLayout();
            this.CurrencyOperationFlowLayoutPanel.ResumeLayout(false);
            this.CurrencyOperationFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.Panel viewDataPanel;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.DateTimePicker DateOperationTimePicker;
        private System.Windows.Forms.TextBox inputTypeTextBox;
        private System.Windows.Forms.TextBox inputTotalTextBox;
        private System.Windows.Forms.TextBox inputCurrencyTextBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox inputCategoryTextBox;
        private System.Windows.Forms.RichTextBox inputProductsRichTextBox;
        private System.Windows.Forms.RichTextBox inputDescriptionRichTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.Label nameOperationLabel;
        private System.Windows.Forms.Label valueNameOperationLabel;
        private System.Windows.Forms.FlowLayoutPanel NameOperationFlowLayoutPanel;
        private System.Windows.Forms.Label dateOperationLabel;
        private System.Windows.Forms.Label valueDateOperationLabel;
        private System.Windows.Forms.Label valueTypeOperationLabel;
        private System.Windows.Forms.Label typeOperationLabel;
        private System.Windows.Forms.Label totalOperationLabel;
        private System.Windows.Forms.Label valueTotalOperationLabel;
        private System.Windows.Forms.Label categoryOperationLabel;
        private System.Windows.Forms.Label valueCategoryOperationLabel;
        private System.Windows.Forms.FlowLayoutPanel CurrencyOperationFlowLayoutPanel;
        private System.Windows.Forms.Label valueCurrencyLabel;
        private System.Windows.Forms.FlowLayoutPanel productsOperationFlowLayoutPanel;
        private System.Windows.Forms.Label productsOperationLabel;
        private System.Windows.Forms.Label valueProductsOperationLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label valueFullNameLabel;
        private System.Windows.Forms.Label valueDescriptionOperationLabel;
        private System.Windows.Forms.Label descriptionOperationLabel;
        private System.Windows.Forms.Button sendToDbButton;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.Label valueStatusOperationLabel;
        private System.Windows.Forms.Label statusOperationLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textMenuLabel;
    }
}