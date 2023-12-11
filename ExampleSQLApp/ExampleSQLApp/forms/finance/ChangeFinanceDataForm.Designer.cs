namespace ExampleSQLApp
{
    partial class ChangeFinanceDataForm
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
            this.inputDataPanel = new System.Windows.Forms.Panel();
            this.findIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueIdTextBox = new System.Windows.Forms.TextBox();
            this.valueStatusTextBox = new System.Windows.Forms.TextBox();
            this.valueFullNameTextBox = new System.Windows.Forms.TextBox();
            this.valueDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.valueProductsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.valueCategoryTextBox = new System.Windows.Forms.TextBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.valueCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.valueTotalTextBox = new System.Windows.Forms.TextBox();
            this.DateOperationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueTypeTextBox = new System.Windows.Forms.TextBox();
            this.valueNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeSendToDbButton = new System.Windows.Forms.Button();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.exitMenuPicture = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.inputDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
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
            this.menuPanel.Size = new System.Drawing.Size(991, 60);
            this.menuPanel.TabIndex = 1;
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
            // inputDataPanel
            // 
            this.inputDataPanel.Controls.Add(this.findIdButton);
            this.inputDataPanel.Controls.Add(this.label1);
            this.inputDataPanel.Controls.Add(this.valueIdTextBox);
            this.inputDataPanel.Controls.Add(this.valueStatusTextBox);
            this.inputDataPanel.Controls.Add(this.valueFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.valueDescriptionRichTextBox);
            this.inputDataPanel.Controls.Add(this.valueProductsRichTextBox);
            this.inputDataPanel.Controls.Add(this.valueCategoryTextBox);
            this.inputDataPanel.Controls.Add(this.currencyLabel);
            this.inputDataPanel.Controls.Add(this.valueCurrencyTextBox);
            this.inputDataPanel.Controls.Add(this.valueTotalTextBox);
            this.inputDataPanel.Controls.Add(this.DateOperationTimePicker);
            this.inputDataPanel.Controls.Add(this.valueTypeTextBox);
            this.inputDataPanel.Controls.Add(this.valueNameTextBox);
            this.inputDataPanel.Location = new System.Drawing.Point(162, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(654, 666);
            this.inputDataPanel.TabIndex = 2;
            // 
            // findIdButton
            // 
            this.findIdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.findIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findIdButton.FlatAppearance.BorderSize = 0;
            this.findIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findIdButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findIdButton.Location = new System.Drawing.Point(382, 11);
            this.findIdButton.Name = "findIdButton";
            this.findIdButton.Size = new System.Drawing.Size(108, 36);
            this.findIdButton.TabIndex = 16;
            this.findIdButton.Text = "Найти";
            this.findIdButton.UseVisualStyleBackColor = false;
            this.findIdButton.Click += new System.EventHandler(this.findIdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер операции:";
            // 
            // valueIdTextBox
            // 
            this.valueIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueIdTextBox.Location = new System.Drawing.Point(242, 11);
            this.valueIdTextBox.Multiline = true;
            this.valueIdTextBox.Name = "valueIdTextBox";
            this.valueIdTextBox.Size = new System.Drawing.Size(119, 36);
            this.valueIdTextBox.TabIndex = 14;
            // 
            // valueStatusTextBox
            // 
            this.valueStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusTextBox.Location = new System.Drawing.Point(9, 440);
            this.valueStatusTextBox.Multiline = true;
            this.valueStatusTextBox.Name = "valueStatusTextBox";
            this.valueStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueStatusTextBox.TabIndex = 13;
            // 
            // valueFullNameTextBox
            // 
            this.valueFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameTextBox.Location = new System.Drawing.Point(9, 496);
            this.valueFullNameTextBox.Multiline = true;
            this.valueFullNameTextBox.Name = "valueFullNameTextBox";
            this.valueFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueFullNameTextBox.TabIndex = 12;
            // 
            // valueDescriptionRichTextBox
            // 
            this.valueDescriptionRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDescriptionRichTextBox.Location = new System.Drawing.Point(9, 555);
            this.valueDescriptionRichTextBox.Name = "valueDescriptionRichTextBox";
            this.valueDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.valueDescriptionRichTextBox.TabIndex = 11;
            this.valueDescriptionRichTextBox.Text = "";
            // 
            // valueProductsRichTextBox
            // 
            this.valueProductsRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueProductsRichTextBox.Location = new System.Drawing.Point(9, 328);
            this.valueProductsRichTextBox.Name = "valueProductsRichTextBox";
            this.valueProductsRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.valueProductsRichTextBox.TabIndex = 10;
            this.valueProductsRichTextBox.Text = "";
            // 
            // valueCategoryTextBox
            // 
            this.valueCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCategoryTextBox.Location = new System.Drawing.Point(9, 274);
            this.valueCategoryTextBox.Multiline = true;
            this.valueCategoryTextBox.Name = "valueCategoryTextBox";
            this.valueCategoryTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueCategoryTextBox.TabIndex = 9;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyLabel.Location = new System.Drawing.Point(376, 220);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(127, 36);
            this.currencyLabel.TabIndex = 8;
            this.currencyLabel.Text = "Валюта:";
            // 
            // valueCurrencyTextBox
            // 
            this.valueCurrencyTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCurrencyTextBox.Location = new System.Drawing.Point(507, 217);
            this.valueCurrencyTextBox.MaxLength = 3;
            this.valueCurrencyTextBox.Multiline = true;
            this.valueCurrencyTextBox.Name = "valueCurrencyTextBox";
            this.valueCurrencyTextBox.Size = new System.Drawing.Size(124, 39);
            this.valueCurrencyTextBox.TabIndex = 7;
            // 
            // valueTotalTextBox
            // 
            this.valueTotalTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTotalTextBox.Location = new System.Drawing.Point(9, 220);
            this.valueTotalTextBox.Multiline = true;
            this.valueTotalTextBox.Name = "valueTotalTextBox";
            this.valueTotalTextBox.Size = new System.Drawing.Size(352, 39);
            this.valueTotalTextBox.TabIndex = 6;
            // 
            // DateOperationTimePicker
            // 
            this.DateOperationTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOperationTimePicker.Location = new System.Drawing.Point(11, 111);
            this.DateOperationTimePicker.Name = "DateOperationTimePicker";
            this.DateOperationTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateOperationTimePicker.TabIndex = 3;
            // 
            // valueTypeTextBox
            // 
            this.valueTypeTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTypeTextBox.Location = new System.Drawing.Point(9, 163);
            this.valueTypeTextBox.Multiline = true;
            this.valueTypeTextBox.Name = "valueTypeTextBox";
            this.valueTypeTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueTypeTextBox.TabIndex = 4;
            // 
            // valueNameTextBox
            // 
            this.valueNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameTextBox.Location = new System.Drawing.Point(11, 57);
            this.valueNameTextBox.Multiline = true;
            this.valueNameTextBox.Name = "valueNameTextBox";
            this.valueNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueNameTextBox.TabIndex = 0;
            // 
            // ChangeSendToDbButton
            // 
            this.ChangeSendToDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.ChangeSendToDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSendToDbButton.FlatAppearance.BorderSize = 0;
            this.ChangeSendToDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSendToDbButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSendToDbButton.Location = new System.Drawing.Point(822, 732);
            this.ChangeSendToDbButton.Name = "ChangeSendToDbButton";
            this.ChangeSendToDbButton.Size = new System.Drawing.Size(157, 40);
            this.ChangeSendToDbButton.TabIndex = 3;
            this.ChangeSendToDbButton.Text = "Изменить";
            this.ChangeSendToDbButton.UseVisualStyleBackColor = false;
            this.ChangeSendToDbButton.Click += new System.EventHandler(this.ChangeSendToDbButton_Click);
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
            // ChangeFinanceDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 784);
            this.Controls.Add(this.ChangeSendToDbButton);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeFinanceDataForm";
            this.Text = "ChangeFinanceDataForm";
            this.Load += new System.EventHandler(this.ChangeFinanceDataForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.TextBox valueStatusTextBox;
        private System.Windows.Forms.TextBox valueFullNameTextBox;
        private System.Windows.Forms.RichTextBox valueDescriptionRichTextBox;
        private System.Windows.Forms.RichTextBox valueProductsRichTextBox;
        private System.Windows.Forms.TextBox valueCategoryTextBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox valueCurrencyTextBox;
        private System.Windows.Forms.TextBox valueTotalTextBox;
        private System.Windows.Forms.DateTimePicker DateOperationTimePicker;
        private System.Windows.Forms.TextBox valueTypeTextBox;
        private System.Windows.Forms.TextBox valueNameTextBox;
        private System.Windows.Forms.TextBox valueIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findIdButton;
        private System.Windows.Forms.Button ChangeSendToDbButton;
    }
}