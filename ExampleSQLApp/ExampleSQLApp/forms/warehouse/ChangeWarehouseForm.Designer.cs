namespace ExampleSQLApp
{
    partial class ChangeWarehouseForm
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
            this.ChangeSendToDbButton = new System.Windows.Forms.Button();
            this.inputDataPanel = new System.Windows.Forms.Panel();
            this.valueLocationTextBox = new System.Windows.Forms.TextBox();
            this.findIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueIdTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueStatusTextBox = new System.Windows.Forms.TextBox();
            this.valueFullNameTextBox = new System.Windows.Forms.TextBox();
            this.valueDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.valueCategoryTextBox = new System.Windows.Forms.TextBox();
            this.valueSupplierTextBox = new System.Windows.Forms.TextBox();
            this.valueNameFinanceTextBox = new System.Windows.Forms.TextBox();
            this.valueNameTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).BeginInit();
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
            this.menuPanel.Size = new System.Drawing.Size(978, 60);
            this.menuPanel.TabIndex = 2;
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
            // ChangeSendToDbButton
            // 
            this.ChangeSendToDbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.ChangeSendToDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSendToDbButton.FlatAppearance.BorderSize = 0;
            this.ChangeSendToDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSendToDbButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSendToDbButton.Location = new System.Drawing.Point(823, 725);
            this.ChangeSendToDbButton.Name = "ChangeSendToDbButton";
            this.ChangeSendToDbButton.Size = new System.Drawing.Size(137, 43);
            this.ChangeSendToDbButton.TabIndex = 5;
            this.ChangeSendToDbButton.Text = "Изменить";
            this.ChangeSendToDbButton.UseVisualStyleBackColor = false;
            this.ChangeSendToDbButton.Click += new System.EventHandler(this.ChangeSendToDbButton_Click);
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.Controls.Add(this.valueLocationTextBox);
            this.inputDataPanel.Controls.Add(this.findIdButton);
            this.inputDataPanel.Controls.Add(this.label1);
            this.inputDataPanel.Controls.Add(this.valueIdTextBox);
            this.inputDataPanel.Controls.Add(this.DateTimePicker);
            this.inputDataPanel.Controls.Add(this.valueStatusTextBox);
            this.inputDataPanel.Controls.Add(this.valueFullNameTextBox);
            this.inputDataPanel.Controls.Add(this.valueDescriptionRichTextBox);
            this.inputDataPanel.Controls.Add(this.valueCategoryTextBox);
            this.inputDataPanel.Controls.Add(this.valueSupplierTextBox);
            this.inputDataPanel.Controls.Add(this.valueNameFinanceTextBox);
            this.inputDataPanel.Controls.Add(this.valueNameTextBox);
            this.inputDataPanel.Location = new System.Drawing.Point(143, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(654, 666);
            this.inputDataPanel.TabIndex = 4;
            // 
            // valueLocationTextBox
            // 
            this.valueLocationTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLocationTextBox.Location = new System.Drawing.Point(11, 494);
            this.valueLocationTextBox.Multiline = true;
            this.valueLocationTextBox.Name = "valueLocationTextBox";
            this.valueLocationTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueLocationTextBox.TabIndex = 17;
            // 
            // findIdButton
            // 
            this.findIdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.findIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findIdButton.FlatAppearance.BorderSize = 0;
            this.findIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findIdButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findIdButton.Location = new System.Drawing.Point(434, 11);
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
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер оборудования:";
            // 
            // valueIdTextBox
            // 
            this.valueIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueIdTextBox.Location = new System.Drawing.Point(293, 11);
            this.valueIdTextBox.Multiline = true;
            this.valueIdTextBox.Name = "valueIdTextBox";
            this.valueIdTextBox.Size = new System.Drawing.Size(119, 36);
            this.valueIdTextBox.TabIndex = 14;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePicker.Location = new System.Drawing.Point(11, 310);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateTimePicker.TabIndex = 3;
            // 
            // valueStatusTextBox
            // 
            this.valueStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueStatusTextBox.Location = new System.Drawing.Point(11, 247);
            this.valueStatusTextBox.Multiline = true;
            this.valueStatusTextBox.Name = "valueStatusTextBox";
            this.valueStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueStatusTextBox.TabIndex = 13;
            // 
            // valueFullNameTextBox
            // 
            this.valueFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueFullNameTextBox.Location = new System.Drawing.Point(11, 434);
            this.valueFullNameTextBox.Multiline = true;
            this.valueFullNameTextBox.Name = "valueFullNameTextBox";
            this.valueFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueFullNameTextBox.TabIndex = 12;
            // 
            // valueDescriptionRichTextBox
            // 
            this.valueDescriptionRichTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueDescriptionRichTextBox.Location = new System.Drawing.Point(11, 554);
            this.valueDescriptionRichTextBox.Name = "valueDescriptionRichTextBox";
            this.valueDescriptionRichTextBox.Size = new System.Drawing.Size(622, 96);
            this.valueDescriptionRichTextBox.TabIndex = 11;
            this.valueDescriptionRichTextBox.Text = "";
            // 
            // valueCategoryTextBox
            // 
            this.valueCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueCategoryTextBox.Location = new System.Drawing.Point(11, 186);
            this.valueCategoryTextBox.Multiline = true;
            this.valueCategoryTextBox.Name = "valueCategoryTextBox";
            this.valueCategoryTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueCategoryTextBox.TabIndex = 9;
            // 
            // valueSupplierTextBox
            // 
            this.valueSupplierTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueSupplierTextBox.Location = new System.Drawing.Point(11, 369);
            this.valueSupplierTextBox.Multiline = true;
            this.valueSupplierTextBox.Name = "valueSupplierTextBox";
            this.valueSupplierTextBox.Size = new System.Drawing.Size(620, 39);
            this.valueSupplierTextBox.TabIndex = 6;
            // 
            // valueNameFinanceTextBox
            // 
            this.valueNameFinanceTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameFinanceTextBox.Location = new System.Drawing.Point(11, 123);
            this.valueNameFinanceTextBox.Multiline = true;
            this.valueNameFinanceTextBox.Name = "valueNameFinanceTextBox";
            this.valueNameFinanceTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueNameFinanceTextBox.TabIndex = 4;
            // 
            // valueNameTextBox
            // 
            this.valueNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNameTextBox.Location = new System.Drawing.Point(11, 69);
            this.valueNameTextBox.Multiline = true;
            this.valueNameTextBox.Name = "valueNameTextBox";
            this.valueNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.valueNameTextBox.TabIndex = 0;
            // 
            // ChangeWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 784);
            this.Controls.Add(this.ChangeSendToDbButton);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeWarehouseForm";
            this.Text = "ChangeWarehouseForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuPicture)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label textMenuLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox exitMenuPicture;
        private System.Windows.Forms.Button ChangeSendToDbButton;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.Button findIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueIdTextBox;
        private System.Windows.Forms.TextBox valueStatusTextBox;
        private System.Windows.Forms.TextBox valueFullNameTextBox;
        private System.Windows.Forms.RichTextBox valueDescriptionRichTextBox;
        private System.Windows.Forms.TextBox valueCategoryTextBox;
        private System.Windows.Forms.TextBox valueSupplierTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox valueNameFinanceTextBox;
        private System.Windows.Forms.TextBox valueNameTextBox;
        private System.Windows.Forms.TextBox valueLocationTextBox;
    }
}