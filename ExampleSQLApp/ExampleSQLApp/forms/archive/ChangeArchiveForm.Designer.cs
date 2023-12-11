namespace ExampleSQLApp
{
    partial class ChangeArchiveForm
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
            this.findIdButton = new System.Windows.Forms.Button();
            this.numberDocumetLabel = new System.Windows.Forms.Label();
            this.valueIdTextBox = new System.Windows.Forms.TextBox();
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
            this.menuPanel.Size = new System.Drawing.Size(984, 60);
            this.menuPanel.TabIndex = 3;
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
            this.ChangeSendToDbButton.Location = new System.Drawing.Point(837, 725);
            this.ChangeSendToDbButton.Name = "ChangeSendToDbButton";
            this.ChangeSendToDbButton.Size = new System.Drawing.Size(137, 43);
            this.ChangeSendToDbButton.TabIndex = 7;
            this.ChangeSendToDbButton.Text = "Изменить";
            this.ChangeSendToDbButton.UseVisualStyleBackColor = false;
            this.ChangeSendToDbButton.Click += new System.EventHandler(this.ChangeSendToDbButton_Click);
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
            this.inputDataPanel.Controls.Add(this.findIdButton);
            this.inputDataPanel.Controls.Add(this.numberDocumetLabel);
            this.inputDataPanel.Controls.Add(this.valueIdTextBox);
            this.inputDataPanel.Location = new System.Drawing.Point(157, 66);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(654, 666);
            this.inputDataPanel.TabIndex = 6;
            // 
            // findIdButton
            // 
            this.findIdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(196)))), ((int)(((byte)(92)))));
            this.findIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findIdButton.FlatAppearance.BorderSize = 0;
            this.findIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findIdButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findIdButton.Location = new System.Drawing.Point(398, 11);
            this.findIdButton.Name = "findIdButton";
            this.findIdButton.Size = new System.Drawing.Size(108, 36);
            this.findIdButton.TabIndex = 16;
            this.findIdButton.Text = "Найти";
            this.findIdButton.UseVisualStyleBackColor = false;
            this.findIdButton.Click += new System.EventHandler(this.findIdButton_Click);
            // 
            // numberDocumetLabel
            // 
            this.numberDocumetLabel.AutoSize = true;
            this.numberDocumetLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberDocumetLabel.Location = new System.Drawing.Point(18, 11);
            this.numberDocumetLabel.Name = "numberDocumetLabel";
            this.numberDocumetLabel.Size = new System.Drawing.Size(230, 33);
            this.numberDocumetLabel.TabIndex = 15;
            this.numberDocumetLabel.Text = "Номер документа:";
            // 
            // valueIdTextBox
            // 
            this.valueIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueIdTextBox.Location = new System.Drawing.Point(254, 11);
            this.valueIdTextBox.Multiline = true;
            this.valueIdTextBox.Name = "valueIdTextBox";
            this.valueIdTextBox.Size = new System.Drawing.Size(119, 36);
            this.valueIdTextBox.TabIndex = 14;
            // 
            // inputLocationTextBox
            // 
            this.inputLocationTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLocationTextBox.Location = new System.Drawing.Point(16, 240);
            this.inputLocationTextBox.Multiline = true;
            this.inputLocationTextBox.Name = "inputLocationTextBox";
            this.inputLocationTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputLocationTextBox.TabIndex = 34;
            // 
            // inputTypeTextBox
            // 
            this.inputTypeTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTypeTextBox.Location = new System.Drawing.Point(16, 154);
            this.inputTypeTextBox.Multiline = true;
            this.inputTypeTextBox.Name = "inputTypeTextBox";
            this.inputTypeTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputTypeTextBox.TabIndex = 32;
            // 
            // inputFullNameTextBox
            // 
            this.inputFullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFullNameTextBox.Location = new System.Drawing.Point(16, 473);
            this.inputFullNameTextBox.Multiline = true;
            this.inputFullNameTextBox.Name = "inputFullNameTextBox";
            this.inputFullNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputFullNameTextBox.TabIndex = 30;
            // 
            // inputStatusTextBox
            // 
            this.inputStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStatusTextBox.Location = new System.Drawing.Point(16, 322);
            this.inputStatusTextBox.Multiline = true;
            this.inputStatusTextBox.Name = "inputStatusTextBox";
            this.inputStatusTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputStatusTextBox.TabIndex = 31;
            // 
            // inputNameFinanceTextBox
            // 
            this.inputNameFinanceTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameFinanceTextBox.Location = new System.Drawing.Point(16, 554);
            this.inputNameFinanceTextBox.Multiline = true;
            this.inputNameFinanceTextBox.Name = "inputNameFinanceTextBox";
            this.inputNameFinanceTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameFinanceTextBox.TabIndex = 33;
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameTextBox.Location = new System.Drawing.Point(16, 73);
            this.inputNameTextBox.Multiline = true;
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(622, 39);
            this.inputNameTextBox.TabIndex = 28;
            // 
            // DateArchivingTimePicker
            // 
            this.DateArchivingTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateArchivingTimePicker.Location = new System.Drawing.Point(16, 404);
            this.DateArchivingTimePicker.Name = "DateArchivingTimePicker";
            this.DateArchivingTimePicker.Size = new System.Drawing.Size(413, 35);
            this.DateArchivingTimePicker.TabIndex = 29;
            // 
            // ChangeArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 774);
            this.Controls.Add(this.ChangeSendToDbButton);
            this.Controls.Add(this.inputDataPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeArchiveForm";
            this.Text = "ChangeArchiveForm";
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
        private System.Windows.Forms.Label numberDocumetLabel;
        private System.Windows.Forms.TextBox valueIdTextBox;
        private System.Windows.Forms.TextBox inputLocationTextBox;
        private System.Windows.Forms.TextBox inputTypeTextBox;
        private System.Windows.Forms.TextBox inputFullNameTextBox;
        private System.Windows.Forms.TextBox inputStatusTextBox;
        private System.Windows.Forms.TextBox inputNameFinanceTextBox;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.DateTimePicker DateArchivingTimePicker;
    }
}