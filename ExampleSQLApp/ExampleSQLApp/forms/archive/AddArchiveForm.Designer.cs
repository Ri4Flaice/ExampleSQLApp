namespace ExampleSQLApp
{
    partial class AddArchiveForm
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
            this.viewDataPanel = new System.Windows.Forms.Panel();
            this.dateArchivingLabel = new System.Windows.Forms.Label();
            this.valueDateArchivingLabel = new System.Windows.Forms.Label();
            this.valueNameFinanceOperationLabel = new System.Windows.Forms.Label();
            this.nameFianceOperationLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.valueStatusLabel = new System.Windows.Forms.Label();
            this.sendToDbButton = new System.Windows.Forms.Button();
            this.valueLocationLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.valueFullNameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.valueTypeLabel = new System.Windows.Forms.Label();
            this.NameOperationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameProjectLabel = new System.Windows.Forms.Label();
            this.valueNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputDataPanel = new System.Windows.Forms.Panel();
            this.inputLocationTextBox = new System.Windows.Forms.TextBox();
            this.inputTypeTextBox = new System.Windows.Forms.TextBox();
            this.inputFullNameTextBox = new System.Windows.Forms.TextBox();
            this.inputStatusTextBox = new System.Windows.Forms.TextBox();
            this.inputNameFinanceTextBox = new System.Windows.Forms.TextBox();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.DateArchivingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
            this.viewDataPanel.SuspendLayout();
            this.NameOperationFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inputDataPanel.SuspendLayout();
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
            this.menuPanel.Size = new System.Drawing.Size(1638, 60);
            this.menuPanel.TabIndex = 3;
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
            // viewDataPanel
            // 
            this.viewDataPanel.Controls.Add(this.dateArchivingLabel);
            this.viewDataPanel.Controls.Add(this.valueDateArchivingLabel);
            this.viewDataPanel.Controls.Add(this.valueNameFinanceOperationLabel);
            this.viewDataPanel.Controls.Add(this.nameFianceOperationLabel);
            this.viewDataPanel.Controls.Add(this.statusLabel);
            this.viewDataPanel.Controls.Add(this.valueStatusLabel);
            this.viewDataPanel.Controls.Add(this.sendToDbButton);
            this.viewDataPanel.Controls.Add(this.valueLocationLabel);
            this.viewDataPanel.Controls.Add(this.locationLabel);
            this.viewDataPanel.Controls.Add(this.fullNameLabel);
            this.viewDataPanel.Controls.Add(this.valueFullNameLabel);
            this.viewDataPanel.Controls.Add(this.typeLabel);
            this.viewDataPanel.Controls.Add(this.valueTypeLabel);
            this.viewDataPanel.Controls.Add(this.NameOperationFlowLayoutPanel);
            this.viewDataPanel.Location = new System.Drawing.Point(832, 66);
            this.viewDataPanel.Name = "viewDataPanel";
            this.viewDataPanel.Size = new System.Drawing.Size(803, 624);
            this.viewDataPanel.TabIndex = 24;
            // 
            // dateArchivingLabel
            // 
            this.dateArchivingLabel.AutoSize = true;
            this.dateArchivingLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateArchivingLabel.Location = new System.Drawing.Point(7, 302);
            this.dateArchivingLabel.Name = "dateArchivingLabel";
            this.dateArchivingLabel.Size = new System.Drawing.Size(347, 33);
            this.dateArchivingLabel.TabIndex = 24;
            this.dateArchivingLabel.Text = "Дата архивации документа: ";
            // 
            // valueDateArchivingLabel
            // 
            this.valueDateArchivingLabel.AutoSize = true;
            this.valueDateArchivingLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDateArchivingLabel.Location = new System.Drawing.Point(360, 302);
            this.valueDateArchivingLabel.Name = "valueDateArchivingLabel";
            this.valueDateArchivingLabel.Size = new System.Drawing.Size(61, 33);
            this.valueDateArchivingLabel.TabIndex = 23;
            this.valueDateArchivingLabel.Text = "date";
            this.valueDateArchivingLabel.Visible = false;
            // 
            // valueNameFinanceOperationLabel
            // 
            this.valueNameFinanceOperationLabel.AutoSize = true;
            this.valueNameFinanceOperationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameFinanceOperationLabel.Location = new System.Drawing.Point(393, 422);
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
            this.nameFianceOperationLabel.Location = new System.Drawing.Point(12, 422);
            this.nameFianceOperationLabel.Name = "nameFianceOperationLabel";
            this.nameFianceOperationLabel.Size = new System.Drawing.Size(375, 33);
            this.nameFianceOperationLabel.TabIndex = 19;
            this.nameFianceOperationLabel.Text = "Номер финансовой операции: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(7, 245);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(109, 33);
            this.statusLabel.TabIndex = 18;
            this.statusLabel.Text = "Статус: ";
            // 
            // valueStatusLabel
            // 
            this.valueStatusLabel.AutoSize = true;
            this.valueStatusLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusLabel.Location = new System.Drawing.Point(122, 245);
            this.valueStatusLabel.Name = "valueStatusLabel";
            this.valueStatusLabel.Size = new System.Drawing.Size(79, 33);
            this.valueStatusLabel.TabIndex = 17;
            this.valueStatusLabel.Text = "status";
            this.valueStatusLabel.Visible = false;
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
            // valueLocationLabel
            // 
            this.valueLocationLabel.AutoSize = true;
            this.valueLocationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLocationLabel.Location = new System.Drawing.Point(378, 189);
            this.valueLocationLabel.Name = "valueLocationLabel";
            this.valueLocationLabel.Size = new System.Drawing.Size(105, 33);
            this.valueLocationLabel.TabIndex = 15;
            this.valueLocationLabel.Text = "location";
            this.valueLocationLabel.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.Location = new System.Drawing.Point(6, 189);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(366, 33);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "Местоположение документа: ";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(7, 366);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(91, 33);
            this.fullNameLabel.TabIndex = 13;
            this.fullNameLabel.Text = "ФИО: ";
            // 
            // valueFullNameLabel
            // 
            this.valueFullNameLabel.AutoSize = true;
            this.valueFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameLabel.Location = new System.Drawing.Point(104, 366);
            this.valueFullNameLabel.Name = "valueFullNameLabel";
            this.valueFullNameLabel.Size = new System.Drawing.Size(118, 33);
            this.valueFullNameLabel.TabIndex = 12;
            this.valueFullNameLabel.Text = "fullName";
            this.valueFullNameLabel.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(7, 135);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(199, 33);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Тип документа:";
            // 
            // valueTypeLabel
            // 
            this.valueTypeLabel.AutoSize = true;
            this.valueTypeLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTypeLabel.Location = new System.Drawing.Point(212, 135);
            this.valueTypeLabel.Name = "valueTypeLabel";
            this.valueTypeLabel.Size = new System.Drawing.Size(62, 33);
            this.valueTypeLabel.TabIndex = 3;
            this.valueTypeLabel.Text = "type";
            this.valueTypeLabel.Visible = false;
            // 
            // NameOperationFlowLayoutPanel
            // 
            this.NameOperationFlowLayoutPanel.Controls.Add(this.nameProjectLabel);
            this.NameOperationFlowLayoutPanel.Controls.Add(this.valueNameLabel);
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
            // valueNameLabel
            // 
            this.valueNameLabel.AutoSize = true;
            this.valueNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameLabel.Location = new System.Drawing.Point(311, 0);
            this.valueNameLabel.Name = "valueNameLabel";
            this.valueNameLabel.Size = new System.Drawing.Size(73, 33);
            this.valueNameLabel.TabIndex = 1;
            this.valueNameLabel.Text = "name";
            this.valueNameLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.doubleLine;
            this.pictureBox1.Location = new System.Drawing.Point(725, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.Controls.Add(this.inputLocationTextBox);
            this.inputDataPanel.Controls.Add(this.inputTypeTextBox);
            this.inputDataPanel.Controls.Add(this.inputFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.inputStatusTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameFinanceTextBox);
            this.inputDataPanel.Controls.Add(this.inputNameTextBox);
            this.inputDataPanel.Controls.Add(this.DateArchivingTimePicker);
            this.inputDataPanel.Location = new System.Drawing.Point(3, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(716, 624);
            this.inputDataPanel.TabIndex = 22;
            // 
            // inputLocationTextBox
            // 
            this.inputLocationTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLocationTextBox.Location = new System.Drawing.Point(9, 189);
            this.inputLocationTextBox.Multiline = true;
            this.inputLocationTextBox.Name = "inputLocationTextBox";
            this.inputLocationTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputLocationTextBox.TabIndex = 27;
            this.inputLocationTextBox.TextChanged += new System.EventHandler(this.inputLocationTextBox_TextChanged);
            this.inputLocationTextBox.Enter += new System.EventHandler(this.inputLocationTextBox_Enter);
            this.inputLocationTextBox.Leave += new System.EventHandler(this.inputLocationTextBox_Leave);
            // 
            // inputTypeTextBox
            // 
            this.inputTypeTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTypeTextBox.Location = new System.Drawing.Point(9, 103);
            this.inputTypeTextBox.Multiline = true;
            this.inputTypeTextBox.Name = "inputTypeTextBox";
            this.inputTypeTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputTypeTextBox.TabIndex = 15;
            this.inputTypeTextBox.TextChanged += new System.EventHandler(this.inputTypeTextBox_TextChanged);
            this.inputTypeTextBox.Enter += new System.EventHandler(this.inputTypeTextBox_Enter);
            this.inputTypeTextBox.Leave += new System.EventHandler(this.inputTypeTextBox_Leave);
            // 
            // inputFullNameTextBox
            // 
            this.inputFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFullNameTextBox.Location = new System.Drawing.Point(9, 422);
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
            this.inputStatusTextBox.Location = new System.Drawing.Point(9, 271);
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
            this.inputNameFinanceTextBox.Location = new System.Drawing.Point(9, 503);
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
            this.inputNameTextBox.Location = new System.Drawing.Point(9, 22);
            this.inputNameTextBox.Multiline = true;
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameTextBox.TabIndex = 0;
            this.inputNameTextBox.TextChanged += new System.EventHandler(this.inputNameTextBox_TextChanged);
            this.inputNameTextBox.Enter += new System.EventHandler(this.inputNameTextBox_Enter);
            this.inputNameTextBox.Leave += new System.EventHandler(this.inputNameTextBox_Leave);
            // 
            // DateArchivingTimePicker
            // 
            this.DateArchivingTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateArchivingTimePicker.Location = new System.Drawing.Point(9, 353);
            this.DateArchivingTimePicker.Name = "DateArchivingTimePicker";
            this.DateArchivingTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateArchivingTimePicker.TabIndex = 3;
            this.DateArchivingTimePicker.ValueChanged += new System.EventHandler(this.DateArchivingTimePicker_ValueChanged);
            // 
            // AddArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 697);
            this.Controls.Add(this.viewDataPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArchiveForm";
            this.Text = "AddArchiveForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.viewDataPanel.ResumeLayout(false);
            this.viewDataPanel.PerformLayout();
            this.NameOperationFlowLayoutPanel.ResumeLayout(false);
            this.NameOperationFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Panel viewDataPanel;
        private System.Windows.Forms.Label dateArchivingLabel;
        private System.Windows.Forms.Label valueDateArchivingLabel;
        private System.Windows.Forms.Label valueNameFinanceOperationLabel;
        private System.Windows.Forms.Label nameFianceOperationLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label valueStatusLabel;
        private System.Windows.Forms.Button sendToDbButton;
        private System.Windows.Forms.Label valueLocationLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label valueFullNameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label valueTypeLabel;
        private System.Windows.Forms.FlowLayoutPanel NameOperationFlowLayoutPanel;
        private System.Windows.Forms.Label nameProjectLabel;
        private System.Windows.Forms.Label valueNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.TextBox inputTypeTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.TextBox inputNameFinanceTextBox;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.DateTimePicker DateArchivingTimePicker;
        private System.Windows.Forms.TextBox inputLocationTextBox;
    }
}