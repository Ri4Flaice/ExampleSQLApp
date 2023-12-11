namespace ExampleSQLApp
{
    partial class AddWarehouseForm
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
            this.inputSupplierTextBox = new System.Windows.Forms.TextBox();
            this.inputNameFinanceTextBox = new System.Windows.Forms.TextBox();
            this.inputLocationTextBox = new System.Windows.Forms.TextBox();
            this.inputStatusTextBox = new System.Windows.Forms.TextBox();
            this.inputFullNameTextBox = new System.Windows.Forms.TextBox();
            this.inputDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputCategoryTextBox = new System.Windows.Forms.TextBox();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOperationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.viewDataPanel = new System.Windows.Forms.Panel();
            this.valueLocationLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.valueNameFinanceOperationLabel = new System.Windows.Forms.Label();
            this.nameFianceOperationLabel = new System.Windows.Forms.Label();
            this.statusOperationLabel = new System.Windows.Forms.Label();
            this.valueStatusOperationLabel = new System.Windows.Forms.Label();
            this.sendToDbButton = new System.Windows.Forms.Button();
            this.valueDescriptionOperationLabel = new System.Windows.Forms.Label();
            this.descriptionOperationLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.valueFullNameLabel = new System.Windows.Forms.Label();
            this.categoryOperationLabel = new System.Windows.Forms.Label();
            this.valueCategoryOperationLabel = new System.Windows.Forms.Label();
            this.valueSupplierLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.dateOperationLabel = new System.Windows.Forms.Label();
            this.valueDateOperationLabel = new System.Windows.Forms.Label();
            this.NameOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameEquipmentLabel = new System.Windows.Forms.Label();
            this.valueNameEquipmentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
            this.inputDataPanel.SuspendLayout();
            this.viewDataPanel.SuspendLayout();
            this.NameOperationFlowLayoutPanel.SuspendLayout();
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
            this.menuPanel.Size = new System.Drawing.Size(1633, 60);
            this.menuPanel.TabIndex = 1;
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
            this.inputDataPanel.Controls.Add(this.inputSupplierTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameFinanceTextBox);
            this.inputDataPanel.Controls.Add(this.inputLocationTextBox);
            this.inputDataPanel.Controls.Add(this.inputStatusTextBox);
            this.inputDataPanel.Controls.Add(this.inputFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.inputDescriptionRichTextBox);
            this.inputDataPanel.Controls.Add(this.inputCategoryTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameTextBox);
            this.inputDataPanel.Controls.Add(this.DateOperationTimePicker);
            this.inputDataPanel.Location = new System.Drawing.Point(3, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(716, 624);
            this.inputDataPanel.TabIndex = 2;
            // 
            // inputSupplierTextBox
            // 
            this.inputSupplierTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSupplierTextBox.Location = new System.Drawing.Point(9, 291);
            this.inputSupplierTextBox.Multiline = true;
            this.inputSupplierTextBox.Name = "inputSupplierTextBox";
            this.inputSupplierTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputSupplierTextBox.TabIndex = 24;
            this.inputSupplierTextBox.TextChanged += new System.EventHandler(this.inputSupplierTextBox_TextChanged);
            this.inputSupplierTextBox.Enter += new System.EventHandler(this.inputSupplierTextBox_Enter);
            this.inputSupplierTextBox.Leave += new System.EventHandler(this.inputSupplierTextBox_Leave);
            // 
            // inputNameFinanceTextBox
            // 
            this.inputNameFinanceTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameFinanceTextBox.Location = new System.Drawing.Point(9, 58);
            this.inputNameFinanceTextBox.Multiline = true;
            this.inputNameFinanceTextBox.Name = "inputNameFinanceTextBox";
            this.inputNameFinanceTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameFinanceTextBox.TabIndex = 23;
            this.inputNameFinanceTextBox.TextChanged += new System.EventHandler(this.inputNameFinanceTextBox_TextChanged);
            this.inputNameFinanceTextBox.Enter += new System.EventHandler(this.inputNameFinanceTextBox_Enter);
            this.inputNameFinanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNameFinanceTextBox_KeyPress);
            this.inputNameFinanceTextBox.Leave += new System.EventHandler(this.inputNameFinanceTextBox_Leave);
            // 
            // inputLocationTextBox
            // 
            this.inputLocationTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLocationTextBox.Location = new System.Drawing.Point(9, 408);
            this.inputLocationTextBox.Multiline = true;
            this.inputLocationTextBox.Name = "inputLocationTextBox";
            this.inputLocationTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputLocationTextBox.TabIndex = 15;
            this.inputLocationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            this.inputLocationTextBox.Enter += new System.EventHandler(this.locationTextBox_Enter);
            this.inputLocationTextBox.Leave += new System.EventHandler(this.locationTextBox_Leave);
            // 
            // inputStatusTextBox
            // 
            this.inputStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStatusTextBox.Location = new System.Drawing.Point(9, 174);
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
            this.inputFullNameTextBox.Location = new System.Drawing.Point(9, 349);
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
            this.inputDescriptionRichTextBox.Location = new System.Drawing.Point(9, 469);
            this.inputDescriptionRichTextBox.Name = "inputDescriptionRichTextBox";
            this.inputDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.inputDescriptionRichTextBox.TabIndex = 11;
            this.inputDescriptionRichTextBox.Text = "";
            this.inputDescriptionRichTextBox.TextChanged += new System.EventHandler(this.inputDescriptionRichTextBox_TextChanged);
            this.inputDescriptionRichTextBox.Enter += new System.EventHandler(this.inputDescriptionRichTextBox_Enter);
            this.inputDescriptionRichTextBox.Leave += new System.EventHandler(this.inputDescriptionRichTextBox_Leave);
            // 
            // inputCategoryTextBox
            // 
            this.inputCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCategoryTextBox.Location = new System.Drawing.Point(9, 112);
            this.inputCategoryTextBox.Multiline = true;
            this.inputCategoryTextBox.Name = "inputCategoryTextBox";
            this.inputCategoryTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputCategoryTextBox.TabIndex = 9;
            this.inputCategoryTextBox.TextChanged += new System.EventHandler(this.inputCategoryTextBox_TextChanged);
            this.inputCategoryTextBox.Enter += new System.EventHandler(this.inputCategoryTextBox_Enter);
            this.inputCategoryTextBox.Leave += new System.EventHandler(this.inputCategoryTextBox_Leave);
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
            // DateOperationTimePicker
            // 
            this.DateOperationTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOperationTimePicker.Location = new System.Drawing.Point(9, 240);
            this.DateOperationTimePicker.Name = "DateOperationTimePicker";
            this.DateOperationTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateOperationTimePicker.TabIndex = 3;
            this.DateOperationTimePicker.ValueChanged += new System.EventHandler(this.DateOperationTimePicker_ValueChanged);
            // 
            // viewDataPanel
            // 
            this.viewDataPanel.Controls.Add(this.valueLocationLabel);
            this.viewDataPanel.Controls.Add(this.locationLabel);
            this.viewDataPanel.Controls.Add(this.valueNameFinanceOperationLabel);
            this.viewDataPanel.Controls.Add(this.nameFianceOperationLabel);
            this.viewDataPanel.Controls.Add(this.statusOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueStatusOperationLabel);
            this.viewDataPanel.Controls.Add(this.sendToDbButton);
            this.viewDataPanel.Controls.Add(this.valueDescriptionOperationLabel);
            this.viewDataPanel.Controls.Add(this.descriptionOperationLabel);
            this.viewDataPanel.Controls.Add(this.fullNameLabel);
            this.viewDataPanel.Controls.Add(this.valueFullNameLabel);
            this.viewDataPanel.Controls.Add(this.categoryOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueCategoryOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueSupplierLabel);
            this.viewDataPanel.Controls.Add(this.supplierLabel);
            this.viewDataPanel.Controls.Add(this.dateOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueDateOperationLabel);
            this.viewDataPanel.Controls.Add(this.NameOperationFlowLayoutPanel);
            this.viewDataPanel.Location = new System.Drawing.Point(830, 66);
            this.viewDataPanel.Name = "viewDataPanel";
            this.viewDataPanel.Size = new System.Drawing.Size(803, 624);
            this.viewDataPanel.TabIndex = 3;
            // 
            // valueLocationLabel
            // 
            this.valueLocationLabel.AutoSize = true;
            this.valueLocationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLocationLabel.Location = new System.Drawing.Point(247, 434);
            this.valueLocationLabel.Name = "valueLocationLabel";
            this.valueLocationLabel.Size = new System.Drawing.Size(105, 33);
            this.valueLocationLabel.TabIndex = 22;
            this.valueLocationLabel.Text = "location";
            this.valueLocationLabel.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.Location = new System.Drawing.Point(6, 434);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(235, 33);
            this.locationLabel.TabIndex = 21;
            this.locationLabel.Text = "Местоположение: ";
            // 
            // valueNameFinanceOperationLabel
            // 
            this.valueNameFinanceOperationLabel.AutoSize = true;
            this.valueNameFinanceOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameFinanceOperationLabel.Location = new System.Drawing.Point(387, 120);
            this.valueNameFinanceOperationLabel.Name = "valueNameFinanceOperationLabel";
            this.valueNameFinanceOperationLabel.Size = new System.Drawing.Size(73, 33);
            this.valueNameFinanceOperationLabel.TabIndex = 20;
            this.valueNameFinanceOperationLabel.Text = "name";
            this.valueNameFinanceOperationLabel.Visible = false;
            // 
            // nameFianceOperationLabel
            // 
            this.nameFianceOperationLabel.AutoSize = true;
            this.nameFianceOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFianceOperationLabel.Location = new System.Drawing.Point(6, 120);
            this.nameFianceOperationLabel.Name = "nameFianceOperationLabel";
            this.nameFianceOperationLabel.Size = new System.Drawing.Size(375, 33);
            this.nameFianceOperationLabel.TabIndex = 19;
            this.nameFianceOperationLabel.Text = "Номер финансовой операции: ";
            // 
            // statusOperationLabel
            // 
            this.statusOperationLabel.AutoSize = true;
            this.statusOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusOperationLabel.Location = new System.Drawing.Point(6, 220);
            this.statusOperationLabel.Name = "statusOperationLabel";
            this.statusOperationLabel.Size = new System.Drawing.Size(109, 33);
            this.statusOperationLabel.TabIndex = 18;
            this.statusOperationLabel.Text = "Статус: ";
            // 
            // valueStatusOperationLabel
            // 
            this.valueStatusOperationLabel.AutoSize = true;
            this.valueStatusOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusOperationLabel.Location = new System.Drawing.Point(121, 220);
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
            this.sendToDbButton.Location = new System.Drawing.Point(656, 559);
            this.sendToDbButton.Name = "sendToDbButton";
            this.sendToDbButton.Size = new System.Drawing.Size(135, 45);
            this.sendToDbButton.TabIndex = 16;
            this.sendToDbButton.Text = "Отправить";
            this.sendToDbButton.UseVisualStyleBackColor = false;
            this.sendToDbButton.Click += new System.EventHandler(this.sendToDbButton_Click);
            // 
            // valueDescriptionOperationLabel
            // 
            this.valueDescriptionOperationLabel.AutoSize = true;
            this.valueDescriptionOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDescriptionOperationLabel.Location = new System.Drawing.Point(158, 485);
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
            this.descriptionOperationLabel.Location = new System.Drawing.Point(6, 485);
            this.descriptionOperationLabel.Name = "descriptionOperationLabel";
            this.descriptionOperationLabel.Size = new System.Drawing.Size(146, 33);
            this.descriptionOperationLabel.TabIndex = 14;
            this.descriptionOperationLabel.Text = "Описание: ";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(6, 384);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(91, 33);
            this.fullNameLabel.TabIndex = 13;
            this.fullNameLabel.Text = "ФИО: ";
            // 
            // valueFullNameLabel
            // 
            this.valueFullNameLabel.AutoSize = true;
            this.valueFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameLabel.Location = new System.Drawing.Point(103, 384);
            this.valueFullNameLabel.Name = "valueFullNameLabel";
            this.valueFullNameLabel.Size = new System.Drawing.Size(118, 33);
            this.valueFullNameLabel.TabIndex = 12;
            this.valueFullNameLabel.Text = "fullName";
            this.valueFullNameLabel.Visible = false;
            // 
            // categoryOperationLabel
            // 
            this.categoryOperationLabel.AutoSize = true;
            this.categoryOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryOperationLabel.Location = new System.Drawing.Point(6, 171);
            this.categoryOperationLabel.Name = "categoryOperationLabel";
            this.categoryOperationLabel.Size = new System.Drawing.Size(269, 33);
            this.categoryOperationLabel.TabIndex = 10;
            this.categoryOperationLabel.Text = "Категория операции: ";
            // 
            // valueCategoryOperationLabel
            // 
            this.valueCategoryOperationLabel.AutoSize = true;
            this.valueCategoryOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCategoryOperationLabel.Location = new System.Drawing.Point(281, 171);
            this.valueCategoryOperationLabel.Name = "valueCategoryOperationLabel";
            this.valueCategoryOperationLabel.Size = new System.Drawing.Size(108, 33);
            this.valueCategoryOperationLabel.TabIndex = 9;
            this.valueCategoryOperationLabel.Text = "category";
            this.valueCategoryOperationLabel.Visible = false;
            // 
            // valueSupplierLabel
            // 
            this.valueSupplierLabel.AutoSize = true;
            this.valueSupplierLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueSupplierLabel.Location = new System.Drawing.Point(176, 327);
            this.valueSupplierLabel.Name = "valueSupplierLabel";
            this.valueSupplierLabel.Size = new System.Drawing.Size(105, 33);
            this.valueSupplierLabel.TabIndex = 6;
            this.valueSupplierLabel.Text = "supplier";
            this.valueSupplierLabel.Visible = false;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierLabel.Location = new System.Drawing.Point(6, 327);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(164, 33);
            this.supplierLabel.TabIndex = 5;
            this.supplierLabel.Text = "Поставщик: ";
            // 
            // dateOperationLabel
            // 
            this.dateOperationLabel.AutoSize = true;
            this.dateOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOperationLabel.Location = new System.Drawing.Point(6, 269);
            this.dateOperationLabel.Name = "dateOperationLabel";
            this.dateOperationLabel.Size = new System.Drawing.Size(203, 33);
            this.dateOperationLabel.TabIndex = 4;
            this.dateOperationLabel.Text = "Дата операции: ";
            // 
            // valueDateOperationLabel
            // 
            this.valueDateOperationLabel.AutoSize = true;
            this.valueDateOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDateOperationLabel.Location = new System.Drawing.Point(215, 269);
            this.valueDateOperationLabel.Name = "valueDateOperationLabel";
            this.valueDateOperationLabel.Size = new System.Drawing.Size(61, 33);
            this.valueDateOperationLabel.TabIndex = 3;
            this.valueDateOperationLabel.Text = "date";
            this.valueDateOperationLabel.Visible = false;
            // 
            // NameOperationFlowLayoutPanel
            // 
            this.NameOperationFlowLayoutPanel.Controls.Add(this.nameEquipmentLabel);
            this.NameOperationFlowLayoutPanel.Controls.Add(this.valueNameEquipmentLabel);
            this.NameOperationFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.NameOperationFlowLayoutPanel.Name = "NameOperationFlowLayoutPanel";
            this.NameOperationFlowLayoutPanel.Size = new System.Drawing.Size(797, 95);
            this.NameOperationFlowLayoutPanel.TabIndex = 2;
            // 
            // nameEquipmentLabel
            // 
            this.nameEquipmentLabel.AutoSize = true;
            this.nameEquipmentLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEquipmentLabel.Location = new System.Drawing.Point(3, 0);
            this.nameEquipmentLabel.Name = "nameEquipmentLabel";
            this.nameEquipmentLabel.Size = new System.Drawing.Size(372, 33);
            this.nameEquipmentLabel.TabIndex = 0;
            this.nameEquipmentLabel.Text = "Наименование оборудования: ";
            // 
            // valueNameEquipmentLabel
            // 
            this.valueNameEquipmentLabel.AutoSize = true;
            this.valueNameEquipmentLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameEquipmentLabel.Location = new System.Drawing.Point(381, 0);
            this.valueNameEquipmentLabel.Name = "valueNameEquipmentLabel";
            this.valueNameEquipmentLabel.Size = new System.Drawing.Size(73, 33);
            this.valueNameEquipmentLabel.TabIndex = 1;
            this.valueNameEquipmentLabel.Text = "name";
            this.valueNameEquipmentLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.doubleLine;
            this.pictureBox1.Location = new System.Drawing.Point(723, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewDataPanel);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWarehouseForm";
            this.Text = "AddWarehouseForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.viewDataPanel.ResumeLayout(false);
            this.viewDataPanel.PerformLayout();
            this.NameOperationFlowLayoutPanel.ResumeLayout(false);
            this.NameOperationFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.RichTextBox inputDescriptionRichTextBox;
        private System.Windows.Forms.TextBox inputCategoryTextBox;
        private System.Windows.Forms.DateTimePicker DateOperationTimePicker;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.Panel viewDataPanel;
        private System.Windows.Forms.Label statusOperationLabel;
        private System.Windows.Forms.Label valueStatusOperationLabel;
        private System.Windows.Forms.Button sendToDbButton;
        private System.Windows.Forms.Label valueDescriptionOperationLabel;
        private System.Windows.Forms.Label descriptionOperationLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label valueFullNameLabel;
        private System.Windows.Forms.Label categoryOperationLabel;
        private System.Windows.Forms.Label valueCategoryOperationLabel;
        private System.Windows.Forms.Label valueSupplierLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label dateOperationLabel;
        private System.Windows.Forms.Label valueDateOperationLabel;
        private System.Windows.Forms.FlowLayoutPanel NameOperationFlowLayoutPanel;
        private System.Windows.Forms.Label nameEquipmentLabel;
        private System.Windows.Forms.Label valueNameEquipmentLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputLocationTextBox;
        private System.Windows.Forms.Label valueNameFinanceOperationLabel;
        private System.Windows.Forms.Label nameFianceOperationLabel;
        private System.Windows.Forms.Label valueLocationLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox inputNameFinanceTextBox;
        private System.Windows.Forms.TextBox inputSupplierTextBox;
    }
}