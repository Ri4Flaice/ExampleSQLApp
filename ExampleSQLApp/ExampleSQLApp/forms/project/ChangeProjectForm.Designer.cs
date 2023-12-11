namespace ExampleSQLApp
{
    partial class ChangeProjectForm
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
            this.ChangeSendToDbButton = new System.Windows.Forms.Button();
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
            this.findIdButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.valueIdTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.textMenuLabel = new System.Windows.Forms.Label();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.exitMenuPicture = new System.Windows.Forms.PictureBox();
            this.inputDataPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeSendToDbButton
            // 
            this.ChangeSendToDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.ChangeSendToDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSendToDbButton.FlatAppearance.BorderSize = 0;
            this.ChangeSendToDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSendToDbButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSendToDbButton.Location = new System.Drawing.Point(811, 742);
            this.ChangeSendToDbButton.Name = "ChangeSendToDbButton";
            this.ChangeSendToDbButton.Size = new System.Drawing.Size(157, 40);
            this.ChangeSendToDbButton.TabIndex = 7;
            this.ChangeSendToDbButton.Text = "Изменить";
            this.ChangeSendToDbButton.UseVisualStyleBackColor = false;
            this.ChangeSendToDbButton.Click += new System.EventHandler(this.ChangeSendToDbButton_Click);
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
            this.inputDataPanel.Controls.Add(this.findIdButton);
            this.inputDataPanel.Controls.Add(this.idLabel);
            this.inputDataPanel.Controls.Add(this.valueIdTextBox);
            this.inputDataPanel.Location = new System.Drawing.Point(143, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(654, 666);
            this.inputDataPanel.TabIndex = 6;
            // 
            // dateEndProjectLabel
            // 
            this.dateEndProjectLabel.AutoSize = true;
            this.dateEndProjectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndProjectLabel.Location = new System.Drawing.Point(179, 362);
            this.dateEndProjectLabel.Name = "dateEndProjectLabel";
            this.dateEndProjectLabel.Size = new System.Drawing.Size(278, 27);
            this.dateEndProjectLabel.TabIndex = 36;
            this.dateEndProjectLabel.Text = "Дата завершения проекта:";
            // 
            // dateStartProjectLabel
            // 
            this.dateStartProjectLabel.AutoSize = true;
            this.dateStartProjectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartProjectLabel.Location = new System.Drawing.Point(218, 260);
            this.dateStartProjectLabel.Name = "dateStartProjectLabel";
            this.dateStartProjectLabel.Size = new System.Drawing.Size(227, 27);
            this.dateStartProjectLabel.TabIndex = 29;
            this.dateStartProjectLabel.Text = "Дата начала проекта:";
            // 
            // dateEndProjectTimePicker
            // 
            this.dateEndProjectTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndProjectTimePicker.Location = new System.Drawing.Point(122, 392);
            this.dateEndProjectTimePicker.Name = "dateEndProjectTimePicker";
            this.dateEndProjectTimePicker.Size = new System.Drawing.Size(413, 35);
            this.dateEndProjectTimePicker.TabIndex = 35;
            // 
            // inputDescriptionRichTextBox
            // 
            this.inputDescriptionRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDescriptionRichTextBox.Location = new System.Drawing.Point(16, 148);
            this.inputDescriptionRichTextBox.Name = "inputDescriptionRichTextBox";
            this.inputDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.inputDescriptionRichTextBox.TabIndex = 30;
            this.inputDescriptionRichTextBox.Text = "";
            // 
            // inputResultTextBox
            // 
            this.inputResultTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputResultTextBox.Location = new System.Drawing.Point(16, 569);
            this.inputResultTextBox.Multiline = true;
            this.inputResultTextBox.Name = "inputResultTextBox";
            this.inputResultTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputResultTextBox.TabIndex = 33;
            // 
            // inputFullNameTextBox
            // 
            this.inputFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFullNameTextBox.Location = new System.Drawing.Point(16, 450);
            this.inputFullNameTextBox.Multiline = true;
            this.inputFullNameTextBox.Name = "inputFullNameTextBox";
            this.inputFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputFullNameTextBox.TabIndex = 31;
            // 
            // inputStatusTextBox
            // 
            this.inputStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStatusTextBox.Location = new System.Drawing.Point(16, 624);
            this.inputStatusTextBox.Multiline = true;
            this.inputStatusTextBox.Name = "inputStatusTextBox";
            this.inputStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputStatusTextBox.TabIndex = 32;
            // 
            // inputNameFinanceTextBox
            // 
            this.inputNameFinanceTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameFinanceTextBox.Location = new System.Drawing.Point(16, 509);
            this.inputNameFinanceTextBox.Multiline = true;
            this.inputNameFinanceTextBox.Name = "inputNameFinanceTextBox";
            this.inputNameFinanceTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameFinanceTextBox.TabIndex = 34;
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameTextBox.Location = new System.Drawing.Point(16, 81);
            this.inputNameTextBox.Multiline = true;
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameTextBox.TabIndex = 27;
            // 
            // DateStartProjectTimePicker
            // 
            this.DateStartProjectTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateStartProjectTimePicker.Location = new System.Drawing.Point(122, 290);
            this.DateStartProjectTimePicker.Name = "DateStartProjectTimePicker";
            this.DateStartProjectTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateStartProjectTimePicker.TabIndex = 28;
            // 
            // findIdButton
            // 
            this.findIdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.findIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findIdButton.FlatAppearance.BorderSize = 0;
            this.findIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findIdButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findIdButton.Location = new System.Drawing.Point(373, 11);
            this.findIdButton.Name = "findIdButton";
            this.findIdButton.Size = new System.Drawing.Size(108, 36);
            this.findIdButton.TabIndex = 16;
            this.findIdButton.Text = "Найти";
            this.findIdButton.UseVisualStyleBackColor = false;
            this.findIdButton.Click += new System.EventHandler(this.findIdButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(18, 11);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(199, 33);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "Номер проекта:";
            // 
            // valueIdTextBox
            // 
            this.valueIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueIdTextBox.Location = new System.Drawing.Point(223, 11);
            this.valueIdTextBox.Multiline = true;
            this.valueIdTextBox.Name = "valueIdTextBox";
            this.valueIdTextBox.Size = new System.Drawing.Size(119, 36);
            this.valueIdTextBox.TabIndex = 14;
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
            this.menuPanel.Size = new System.Drawing.Size(986, 60);
            this.menuPanel.TabIndex = 8;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            // 
            // textMenuLabel
            // 
            this.textMenuLabel.AutoSize = true;
            this.textMenuLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMenuLabel.Location = new System.Drawing.Point(365, 9);
            this.textMenuLabel.Name = "textMenuLabel";
            this.textMenuLabel.Size = new System.Drawing.Size(224, 33);
            this.textMenuLabel.TabIndex = 2;
            this.textMenuLabel.Text = "Изменить данные";
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPictureBox.Image = global::ExampleSQLApp.Properties.Resources.exit;
            this.ExitPictureBox.Location = new System.Drawing.Point(915, 3);
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
            // ChangeProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 794);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.ChangeSendToDbButton);
            this.Controls.Add(this.inputDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeProjectForm";
            this.Text = "ChangeProjectForm";
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeSendToDbButton;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.Button findIdButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox valueIdTextBox;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Label dateEndProjectLabel;
        private System.Windows.Forms.Label dateStartProjectLabel;
        private System.Windows.Forms.DateTimePicker dateEndProjectTimePicker;
        private System.Windows.Forms.RichTextBox inputDescriptionRichTextBox;
        private System.Windows.Forms.TextBox inputResultTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.TextBox inputNameFinanceTextBox;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.DateTimePicker DateStartProjectTimePicker;
    }
}