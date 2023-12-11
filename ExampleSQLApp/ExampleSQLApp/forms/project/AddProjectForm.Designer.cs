namespace ExampleSQLApp
{
    partial class AddProjectForm
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
            this.dateEndProjectLabel = new System.Windows.Forms.Label();
            this.dateStartProjectLabel = new System.Windows.Forms.Label();
            this.dateEndProjectTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inputDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputResultTextBox = new System.Windows.Forms.TextBox();
            this.inputFullNameTextBox = new System.Windows.Forms.TextBox();
            this.inputStatusTextBox = new System.Windows.Forms.TextBox();
            this.inputNameFinanceTextBox = new System.Windows.Forms.TextBox();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.DateStartProjectTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewDataPanel = new System.Windows.Forms.Panel();
            this.dateEndOperationLabel = new System.Windows.Forms.Label();
            this.valueDateEndProjectLabel = new System.Windows.Forms.Label();
            this.valueResultLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.valueNameFinanceOperationLabel = new System.Windows.Forms.Label();
            this.nameFianceOperationLabel = new System.Windows.Forms.Label();
            this.statusOperationLabel = new System.Windows.Forms.Label();
            this.valueStatusProjectLabel = new System.Windows.Forms.Label();
            this.sendToDbButton = new System.Windows.Forms.Button();
            this.valueDescriptionOperationLabel = new System.Windows.Forms.Label();
            this.descriptionProjectLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.valueFullNameLabel = new System.Windows.Forms.Label();
            this.dateStartOperationLabel = new System.Windows.Forms.Label();
            this.valueDateStartProjectLabel = new System.Windows.Forms.Label();
            this.NameOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameProjectLabel = new System.Windows.Forms.Label();
            this.valueNameProjectLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
            this.inputDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.viewDataPanel.SuspendLayout();
            this.NameOperationFlowLayoutPanel.SuspendLayout();
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
            this.menuPanel.Size = new System.Drawing.Size(1640, 60);
            this.menuPanel.TabIndex = 2;
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
            this.inputDataPanel.Controls.Add(this.dateEndProjectLabel);
            this.inputDataPanel.Controls.Add(this.dateStartProjectLabel);
            this.inputDataPanel.Controls.Add(this.dateEndProjectTimePicker);
            this.inputDataPanel.Controls.Add(this.inputDescriptionRichTextBox);
            this.inputDataPanel.Controls.Add(this.inputResultTextBox);
            this.inputDataPanel.Controls.Add(this.inputFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.inputStatusTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameFinanceTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameTextBox);
            this.inputDataPanel.Controls.Add(this.DateStartProjectTimePicker);
            this.inputDataPanel.Location = new System.Drawing.Point(3, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(716, 624);
            this.inputDataPanel.TabIndex = 3;
            // 
            // dateEndProjectLabel
            // 
            this.dateEndProjectLabel.AutoSize = true;
            this.dateEndProjectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndProjectLabel.Location = new System.Drawing.Point(163, 286);
            this.dateEndProjectLabel.Name = "dateEndProjectLabel";
            this.dateEndProjectLabel.Size = new System.Drawing.Size(278, 27);
            this.dateEndProjectLabel.TabIndex = 26;
            this.dateEndProjectLabel.Text = "Дата завершения проекта:";
            // 
            // dateStartProjectLabel
            // 
            this.dateStartProjectLabel.AutoSize = true;
            this.dateStartProjectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartProjectLabel.Location = new System.Drawing.Point(202, 184);
            this.dateStartProjectLabel.Name = "dateStartProjectLabel";
            this.dateStartProjectLabel.Size = new System.Drawing.Size(227, 27);
            this.dateStartProjectLabel.TabIndex = 4;
            this.dateStartProjectLabel.Text = "Дата начала проекта:";
            // 
            // dateEndProjectTimePicker
            // 
            this.dateEndProjectTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndProjectTimePicker.Location = new System.Drawing.Point(106, 316);
            this.dateEndProjectTimePicker.Name = "dateEndProjectTimePicker";
            this.dateEndProjectTimePicker.Size = new System.Drawing.Size(413, 35);
            this.dateEndProjectTimePicker.TabIndex = 25;
            this.dateEndProjectTimePicker.ValueChanged += new System.EventHandler(this.dateEndProjectTimePicker_ValueChanged);
            // 
            // inputDescriptionRichTextBox
            // 
            this.inputDescriptionRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDescriptionRichTextBox.Location = new System.Drawing.Point(9, 66);
            this.inputDescriptionRichTextBox.Name = "inputDescriptionRichTextBox";
            this.inputDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.inputDescriptionRichTextBox.TabIndex = 11;
            this.inputDescriptionRichTextBox.Text = "";
            this.inputDescriptionRichTextBox.TextChanged += new System.EventHandler(this.inputDescriptionRichTextBox_TextChanged);
            this.inputDescriptionRichTextBox.Enter += new System.EventHandler(this.inputDescriptionRichTextBox_Enter);
            this.inputDescriptionRichTextBox.Leave += new System.EventHandler(this.inputDescriptionRichTextBox_Leave);
            // 
            // inputResultTextBox
            // 
            this.inputResultTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputResultTextBox.Location = new System.Drawing.Point(9, 506);
            this.inputResultTextBox.Multiline = true;
            this.inputResultTextBox.Name = "inputResultTextBox";
            this.inputResultTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputResultTextBox.TabIndex = 15;
            this.inputResultTextBox.TextChanged += new System.EventHandler(this.inputResultTextBox_TextChanged);
            this.inputResultTextBox.Enter += new System.EventHandler(this.inputResultTextBox_Enter);
            this.inputResultTextBox.Leave += new System.EventHandler(this.inputResultTextBox_Leave);
            // 
            // inputFullNameTextBox
            // 
            this.inputFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFullNameTextBox.Location = new System.Drawing.Point(9, 375);
            this.inputFullNameTextBox.Multiline = true;
            this.inputFullNameTextBox.Name = "inputFullNameTextBox";
            this.inputFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputFullNameTextBox.TabIndex = 12;
            this.inputFullNameTextBox.TextChanged += new System.EventHandler(this.inputFullNameTextBox_TextChanged);
            this.inputFullNameTextBox.Enter += new System.EventHandler(this.inputFullNameTextBox_Enter);
            this.inputFullNameTextBox.Leave += new System.EventHandler(this.inputFullNameTextBox_Leave);
            // 
            // inputStatusTextBox
            // 
            this.inputStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStatusTextBox.Location = new System.Drawing.Point(9, 568);
            this.inputStatusTextBox.Multiline = true;
            this.inputStatusTextBox.Name = "inputStatusTextBox";
            this.inputStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputStatusTextBox.TabIndex = 13;
            this.inputStatusTextBox.TextChanged += new System.EventHandler(this.inputStatusTextBox_TextChanged);
            this.inputStatusTextBox.Enter += new System.EventHandler(this.inputStatusTextBox_Enter);
            this.inputStatusTextBox.Leave += new System.EventHandler(this.inputStatusTextBox_Leave);
            // 
            // inputNameFinanceTextBox
            // 
            this.inputNameFinanceTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameFinanceTextBox.Location = new System.Drawing.Point(9, 438);
            this.inputNameFinanceTextBox.Multiline = true;
            this.inputNameFinanceTextBox.Name = "inputNameFinanceTextBox";
            this.inputNameFinanceTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameFinanceTextBox.TabIndex = 23;
            this.inputNameFinanceTextBox.TextChanged += new System.EventHandler(this.inputNameFinanceTextBox_TextChanged);
            this.inputNameFinanceTextBox.Enter += new System.EventHandler(this.inputNameFinanceTextBox_Enter);
            this.inputNameFinanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNameFinanceTextBox_KeyPress);
            this.inputNameFinanceTextBox.Leave += new System.EventHandler(this.inputNameFinanceTextBox_Leave);
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
            // DateStartProjectTimePicker
            // 
            this.DateStartProjectTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateStartProjectTimePicker.Location = new System.Drawing.Point(106, 214);
            this.DateStartProjectTimePicker.Name = "DateStartProjectTimePicker";
            this.DateStartProjectTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateStartProjectTimePicker.TabIndex = 3;
            this.DateStartProjectTimePicker.ValueChanged += new System.EventHandler(this.DateOperationTimePicker_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.doubleLine;
            this.pictureBox1.Location = new System.Drawing.Point(725, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // viewDataPanel
            // 
            this.viewDataPanel.Controls.Add(this.dateEndOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueDateEndProjectLabel);
            this.viewDataPanel.Controls.Add(this.valueResultLabel);
            this.viewDataPanel.Controls.Add(this.resultLabel);
            this.viewDataPanel.Controls.Add(this.valueNameFinanceOperationLabel);
            this.viewDataPanel.Controls.Add(this.nameFianceOperationLabel);
            this.viewDataPanel.Controls.Add(this.statusOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueStatusProjectLabel);
            this.viewDataPanel.Controls.Add(this.sendToDbButton);
            this.viewDataPanel.Controls.Add(this.valueDescriptionOperationLabel);
            this.viewDataPanel.Controls.Add(this.descriptionProjectLabel);
            this.viewDataPanel.Controls.Add(this.fullNameLabel);
            this.viewDataPanel.Controls.Add(this.valueFullNameLabel);
            this.viewDataPanel.Controls.Add(this.dateStartOperationLabel);
            this.viewDataPanel.Controls.Add(this.valueDateStartProjectLabel);
            this.viewDataPanel.Controls.Add(this.NameOperationFlowLayoutPanel);
            this.viewDataPanel.Location = new System.Drawing.Point(832, 66);
            this.viewDataPanel.Name = "viewDataPanel";
            this.viewDataPanel.Size = new System.Drawing.Size(803, 624);
            this.viewDataPanel.TabIndex = 21;
            // 
            // dateEndOperationLabel
            // 
            this.dateEndOperationLabel.AutoSize = true;
            this.dateEndOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndOperationLabel.Location = new System.Drawing.Point(7, 247);
            this.dateEndOperationLabel.Name = "dateEndOperationLabel";
            this.dateEndOperationLabel.Size = new System.Drawing.Size(330, 33);
            this.dateEndOperationLabel.TabIndex = 24;
            this.dateEndOperationLabel.Text = "Дата завершения проекта: ";
            // 
            // valueDateEndProjectLabel
            // 
            this.valueDateEndProjectLabel.AutoSize = true;
            this.valueDateEndProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDateEndProjectLabel.Location = new System.Drawing.Point(343, 247);
            this.valueDateEndProjectLabel.Name = "valueDateEndProjectLabel";
            this.valueDateEndProjectLabel.Size = new System.Drawing.Size(61, 33);
            this.valueDateEndProjectLabel.TabIndex = 23;
            this.valueDateEndProjectLabel.Text = "date";
            this.valueDateEndProjectLabel.Visible = false;
            // 
            // valueResultLabel
            // 
            this.valueResultLabel.AutoSize = true;
            this.valueResultLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueResultLabel.Location = new System.Drawing.Point(246, 422);
            this.valueResultLabel.Name = "valueResultLabel";
            this.valueResultLabel.Size = new System.Drawing.Size(77, 33);
            this.valueResultLabel.TabIndex = 22;
            this.valueResultLabel.Text = "result";
            this.valueResultLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(6, 422);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(234, 33);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.Text = "Результат проекта:";
            // 
            // valueNameFinanceOperationLabel
            // 
            this.valueNameFinanceOperationLabel.AutoSize = true;
            this.valueNameFinanceOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameFinanceOperationLabel.Location = new System.Drawing.Point(388, 365);
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
            this.nameFianceOperationLabel.Location = new System.Drawing.Point(7, 365);
            this.nameFianceOperationLabel.Name = "nameFianceOperationLabel";
            this.nameFianceOperationLabel.Size = new System.Drawing.Size(375, 33);
            this.nameFianceOperationLabel.TabIndex = 19;
            this.nameFianceOperationLabel.Text = "Номер финансовой операции: ";
            // 
            // statusOperationLabel
            // 
            this.statusOperationLabel.AutoSize = true;
            this.statusOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusOperationLabel.Location = new System.Drawing.Point(7, 478);
            this.statusOperationLabel.Name = "statusOperationLabel";
            this.statusOperationLabel.Size = new System.Drawing.Size(109, 33);
            this.statusOperationLabel.TabIndex = 18;
            this.statusOperationLabel.Text = "Статус: ";
            // 
            // valueStatusProjectLabel
            // 
            this.valueStatusProjectLabel.AutoSize = true;
            this.valueStatusProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusProjectLabel.Location = new System.Drawing.Point(122, 478);
            this.valueStatusProjectLabel.Name = "valueStatusProjectLabel";
            this.valueStatusProjectLabel.Size = new System.Drawing.Size(79, 33);
            this.valueStatusProjectLabel.TabIndex = 17;
            this.valueStatusProjectLabel.Text = "status";
            this.valueStatusProjectLabel.Visible = false;
            // 
            // sendToDbButton
            // 
            this.sendToDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.sendToDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendToDbButton.FlatAppearance.BorderSize = 0;
            this.sendToDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendToDbButton.Location = new System.Drawing.Point(663, 570);
            this.sendToDbButton.Name = "sendToDbButton";
            this.sendToDbButton.Size = new System.Drawing.Size(125, 37);
            this.sendToDbButton.TabIndex = 16;
            this.sendToDbButton.Text = "Отправить";
            this.sendToDbButton.UseVisualStyleBackColor = false;
            this.sendToDbButton.Click += new System.EventHandler(this.sendToDbButton_Click);
            // 
            // valueDescriptionOperationLabel
            // 
            this.valueDescriptionOperationLabel.AutoSize = true;
            this.valueDescriptionOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDescriptionOperationLabel.Location = new System.Drawing.Point(159, 143);
            this.valueDescriptionOperationLabel.Name = "valueDescriptionOperationLabel";
            this.valueDescriptionOperationLabel.Size = new System.Drawing.Size(139, 33);
            this.valueDescriptionOperationLabel.TabIndex = 15;
            this.valueDescriptionOperationLabel.Text = "description";
            this.valueDescriptionOperationLabel.Visible = false;
            // 
            // descriptionProjectLabel
            // 
            this.descriptionProjectLabel.AutoSize = true;
            this.descriptionProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionProjectLabel.Location = new System.Drawing.Point(7, 143);
            this.descriptionProjectLabel.Name = "descriptionProjectLabel";
            this.descriptionProjectLabel.Size = new System.Drawing.Size(146, 33);
            this.descriptionProjectLabel.TabIndex = 14;
            this.descriptionProjectLabel.Text = "Описание: ";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(7, 306);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(91, 33);
            this.fullNameLabel.TabIndex = 13;
            this.fullNameLabel.Text = "ФИО: ";
            // 
            // valueFullNameLabel
            // 
            this.valueFullNameLabel.AutoSize = true;
            this.valueFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameLabel.Location = new System.Drawing.Point(104, 306);
            this.valueFullNameLabel.Name = "valueFullNameLabel";
            this.valueFullNameLabel.Size = new System.Drawing.Size(118, 33);
            this.valueFullNameLabel.TabIndex = 12;
            this.valueFullNameLabel.Text = "fullName";
            this.valueFullNameLabel.Visible = false;
            // 
            // dateStartOperationLabel
            // 
            this.dateStartOperationLabel.AutoSize = true;
            this.dateStartOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartOperationLabel.Location = new System.Drawing.Point(7, 195);
            this.dateStartOperationLabel.Name = "dateStartOperationLabel";
            this.dateStartOperationLabel.Size = new System.Drawing.Size(269, 33);
            this.dateStartOperationLabel.TabIndex = 4;
            this.dateStartOperationLabel.Text = "Дата начала проекта: ";
            // 
            // valueDateStartProjectLabel
            // 
            this.valueDateStartProjectLabel.AutoSize = true;
            this.valueDateStartProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDateStartProjectLabel.Location = new System.Drawing.Point(282, 195);
            this.valueDateStartProjectLabel.Name = "valueDateStartProjectLabel";
            this.valueDateStartProjectLabel.Size = new System.Drawing.Size(61, 33);
            this.valueDateStartProjectLabel.TabIndex = 3;
            this.valueDateStartProjectLabel.Text = "date";
            this.valueDateStartProjectLabel.Visible = false;
            // 
            // NameOperationFlowLayoutPanel
            // 
            this.NameOperationFlowLayoutPanel.Controls.Add(this.nameProjectLabel);
            this.NameOperationFlowLayoutPanel.Controls.Add(this.valueNameProjectLabel);
            this.NameOperationFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.NameOperationFlowLayoutPanel.Name = "NameOperationFlowLayoutPanel";
            this.NameOperationFlowLayoutPanel.Size = new System.Drawing.Size(797, 95);
            this.NameOperationFlowLayoutPanel.TabIndex = 2;
            // 
            // nameProjectLabel
            // 
            this.nameProjectLabel.AutoSize = true;
            this.nameProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProjectLabel.Location = new System.Drawing.Point(3, 0);
            this.nameProjectLabel.Name = "nameProjectLabel";
            this.nameProjectLabel.Size = new System.Drawing.Size(302, 33);
            this.nameProjectLabel.TabIndex = 0;
            this.nameProjectLabel.Text = "Наименование проекта: ";
            // 
            // valueNameProjectLabel
            // 
            this.valueNameProjectLabel.AutoSize = true;
            this.valueNameProjectLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameProjectLabel.Location = new System.Drawing.Point(311, 0);
            this.valueNameProjectLabel.Name = "valueNameProjectLabel";
            this.valueNameProjectLabel.Size = new System.Drawing.Size(73, 33);
            this.valueNameProjectLabel.TabIndex = 1;
            this.valueNameProjectLabel.Text = "name";
            this.valueNameProjectLabel.Visible = false;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 698);
            this.Controls.Add(this.viewDataPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.viewDataPanel.ResumeLayout(false);
            this.viewDataPanel.PerformLayout();
            this.NameOperationFlowLayoutPanel.ResumeLayout(false);
            this.NameOperationFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.TextBox inputNameFinanceTextBox;
        private System.Windows.Forms.TextBox inputResultTextBox;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.RichTextBox inputDescriptionRichTextBox;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.DateTimePicker DateStartProjectTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndProjectTimePicker;
        private System.Windows.Forms.Label dateEndProjectLabel;
        private System.Windows.Forms.Label dateStartProjectLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel viewDataPanel;
        private System.Windows.Forms.Label valueResultLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label valueNameFinanceOperationLabel;
        private System.Windows.Forms.Label nameFianceOperationLabel;
        private System.Windows.Forms.Label statusOperationLabel;
        private System.Windows.Forms.Label valueStatusProjectLabel;
        private System.Windows.Forms.Button sendToDbButton;
        private System.Windows.Forms.Label valueDescriptionOperationLabel;
        private System.Windows.Forms.Label descriptionProjectLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label valueFullNameLabel;
        private System.Windows.Forms.Label dateStartOperationLabel;
        private System.Windows.Forms.Label valueDateStartProjectLabel;
        private System.Windows.Forms.FlowLayoutPanel NameOperationFlowLayoutPanel;
        private System.Windows.Forms.Label nameProjectLabel;
        private System.Windows.Forms.Label valueNameProjectLabel;
        private System.Windows.Forms.Label dateEndOperationLabel;
        private System.Windows.Forms.Label valueDateEndProjectLabel;
    }
}