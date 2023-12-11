namespace ExampleSQLApp
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnCloseProgram = new System.Windows.Forms.PictureBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.userInfo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.postUserPicture = new System.Windows.Forms.PictureBox();
            this.userPostLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userSurnameLabel = new System.Windows.Forms.Label();
            this.userPatronymicLabel = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.financeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinanceViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFinanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFinanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDbPanel = new System.Windows.Forms.Panel();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.userInfo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postUserPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.menu.SuspendLayout();
            this.viewDbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(177)))), ((int)(((byte)(217)))));
            this.menuPanel.Controls.Add(this.btnCloseProgram);
            this.menuPanel.Controls.Add(this.logoPicture);
            this.menuPanel.Controls.Add(this.userInfo);
            this.menuPanel.Controls.Add(this.menu);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1456, 72);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseProgram.Image = global::ExampleSQLApp.Properties.Resources.exit;
            this.btnCloseProgram.Location = new System.Drawing.Point(1386, 10);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(58, 53);
            this.btnCloseProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseProgram.TabIndex = 8;
            this.btnCloseProgram.TabStop = false;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::ExampleSQLApp.Properties.Resources.logo2;
            this.logoPicture.Location = new System.Drawing.Point(12, 6);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(63, 62);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 4;
            this.logoPicture.TabStop = false;
            // 
            // userInfo
            // 
            this.userInfo.Controls.Add(this.flowLayoutPanel2);
            this.userInfo.Controls.Add(this.flowLayoutPanel1);
            this.userInfo.Location = new System.Drawing.Point(865, 1);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(443, 68);
            this.userInfo.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.postUserPicture);
            this.flowLayoutPanel2.Controls.Add(this.userPostLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(19, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 35);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // postUserPicture
            // 
            this.postUserPicture.Image = global::ExampleSQLApp.Properties.Resources.post;
            this.postUserPicture.Location = new System.Drawing.Point(3, 3);
            this.postUserPicture.Name = "postUserPicture";
            this.postUserPicture.Size = new System.Drawing.Size(30, 22);
            this.postUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postUserPicture.TabIndex = 8;
            this.postUserPicture.TabStop = false;
            // 
            // userPostLabel
            // 
            this.userPostLabel.AutoSize = true;
            this.userPostLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPostLabel.Location = new System.Drawing.Point(39, 0);
            this.userPostLabel.Name = "userPostLabel";
            this.userPostLabel.Size = new System.Drawing.Size(80, 22);
            this.userPostLabel.TabIndex = 5;
            this.userPostLabel.Text = "postUser";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UserPicture);
            this.flowLayoutPanel1.Controls.Add(this.userNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.userSurnameLabel);
            this.flowLayoutPanel1.Controls.Add(this.userPatronymicLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 32);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::ExampleSQLApp.Properties.Resources.user1;
            this.UserPicture.Location = new System.Drawing.Point(3, 3);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(30, 25);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 7;
            this.UserPicture.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(39, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(56, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Name";
            // 
            // userSurnameLabel
            // 
            this.userSurnameLabel.AutoSize = true;
            this.userSurnameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameLabel.Location = new System.Drawing.Point(101, 0);
            this.userSurnameLabel.Name = "userSurnameLabel";
            this.userSurnameLabel.Size = new System.Drawing.Size(78, 22);
            this.userSurnameLabel.TabIndex = 3;
            this.userSurnameLabel.Text = "Surname";
            // 
            // userPatronymicLabel
            // 
            this.userPatronymicLabel.AutoSize = true;
            this.userPatronymicLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPatronymicLabel.Location = new System.Drawing.Point(185, 0);
            this.userPatronymicLabel.Name = "userPatronymicLabel";
            this.userPatronymicLabel.Size = new System.Drawing.Size(99, 22);
            this.userPatronymicLabel.TabIndex = 6;
            this.userPatronymicLabel.Text = "Patronymic";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(177)))), ((int)(((byte)(217)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeMenuItem,
            this.warehouseToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(106, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(674, 41);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // financeMenuItem
            // 
            this.financeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FinanceViewToolStripMenuItem,
            this.addFinanceToolStripMenuItem,
            this.changeFinanceToolStripMenuItem});
            this.financeMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.financeMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.financeMenuItem.Name = "financeMenuItem";
            this.financeMenuItem.Size = new System.Drawing.Size(141, 37);
            this.financeMenuItem.Text = "Финансы";
            // 
            // FinanceViewToolStripMenuItem
            // 
            this.FinanceViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.FinanceViewToolStripMenuItem.Name = "FinanceViewToolStripMenuItem";
            this.FinanceViewToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.FinanceViewToolStripMenuItem.Text = "Просмотр";
            this.FinanceViewToolStripMenuItem.Click += new System.EventHandler(this.FinanceViewToolStripMenuItem_Click);
            // 
            // addFinanceToolStripMenuItem
            // 
            this.addFinanceToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.addFinanceToolStripMenuItem.Name = "addFinanceToolStripMenuItem";
            this.addFinanceToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.addFinanceToolStripMenuItem.Text = "Добавить";
            this.addFinanceToolStripMenuItem.Click += new System.EventHandler(this.addFinanceToolStripMenuItem_Click);
            // 
            // changeFinanceToolStripMenuItem
            // 
            this.changeFinanceToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.changeFinanceToolStripMenuItem.Name = "changeFinanceToolStripMenuItem";
            this.changeFinanceToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.changeFinanceToolStripMenuItem.Text = "Изменить";
            this.changeFinanceToolStripMenuItem.Click += new System.EventHandler(this.changeFinanceToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WarehouseViewToolStripMenuItem,
            this.addWarehouseToolStripMenuItem,
            this.changeWarehouseToolStripMenuItem});
            this.warehouseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(104, 37);
            this.warehouseToolStripMenuItem.Text = "Склад";
            // 
            // WarehouseViewToolStripMenuItem
            // 
            this.WarehouseViewToolStripMenuItem.Name = "WarehouseViewToolStripMenuItem";
            this.WarehouseViewToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.WarehouseViewToolStripMenuItem.Text = "Просмотр";
            this.WarehouseViewToolStripMenuItem.Click += new System.EventHandler(this.viewWarehouseToolStripMenuItem_Click);
            // 
            // addWarehouseToolStripMenuItem
            // 
            this.addWarehouseToolStripMenuItem.Name = "addWarehouseToolStripMenuItem";
            this.addWarehouseToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.addWarehouseToolStripMenuItem.Text = "Добавить";
            this.addWarehouseToolStripMenuItem.Click += new System.EventHandler(this.addWarehouseToolStripMenuItem_Click);
            // 
            // changeWarehouseToolStripMenuItem
            // 
            this.changeWarehouseToolStripMenuItem.Name = "changeWarehouseToolStripMenuItem";
            this.changeWarehouseToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.changeWarehouseToolStripMenuItem.Text = "Изменить";
            this.changeWarehouseToolStripMenuItem.Click += new System.EventHandler(this.changeWarehouseToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectViewToolStripMenuItem,
            this.projectAddToolStripMenuItem,
            this.projectChangeToolStripMenuItem});
            this.projectToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(135, 37);
            this.projectToolStripMenuItem.Text = "Проекты";
            // 
            // projectViewToolStripMenuItem
            // 
            this.projectViewToolStripMenuItem.Name = "projectViewToolStripMenuItem";
            this.projectViewToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.projectViewToolStripMenuItem.Text = "Просмотр";
            this.projectViewToolStripMenuItem.Click += new System.EventHandler(this.projectViewToolStripMenuItem_Click);
            // 
            // projectAddToolStripMenuItem
            // 
            this.projectAddToolStripMenuItem.Name = "projectAddToolStripMenuItem";
            this.projectAddToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.projectAddToolStripMenuItem.Text = "Добавить";
            this.projectAddToolStripMenuItem.Click += new System.EventHandler(this.projectAddToolStripMenuItem_Click);
            // 
            // projectChangeToolStripMenuItem
            // 
            this.projectChangeToolStripMenuItem.Name = "projectChangeToolStripMenuItem";
            this.projectChangeToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.projectChangeToolStripMenuItem.Text = "Изменить";
            this.projectChangeToolStripMenuItem.Click += new System.EventHandler(this.projectChangeToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveViewToolStripMenuItem,
            this.archiveAddToolStripMenuItem,
            this.archiveChangeToolStripMenuItem});
            this.archiveToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(106, 37);
            this.archiveToolStripMenuItem.Text = "Архив";
            // 
            // archiveViewToolStripMenuItem
            // 
            this.archiveViewToolStripMenuItem.Name = "archiveViewToolStripMenuItem";
            this.archiveViewToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.archiveViewToolStripMenuItem.Text = "Просмотр";
            this.archiveViewToolStripMenuItem.Click += new System.EventHandler(this.archiveViewToolStripMenuItem_Click);
            // 
            // archiveAddToolStripMenuItem
            // 
            this.archiveAddToolStripMenuItem.Name = "archiveAddToolStripMenuItem";
            this.archiveAddToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.archiveAddToolStripMenuItem.Text = "Добавить";
            this.archiveAddToolStripMenuItem.Click += new System.EventHandler(this.archiveAddToolStripMenuItem_Click);
            // 
            // archiveChangeToolStripMenuItem
            // 
            this.archiveChangeToolStripMenuItem.Name = "archiveChangeToolStripMenuItem";
            this.archiveChangeToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.archiveChangeToolStripMenuItem.Text = "Изменить";
            this.archiveChangeToolStripMenuItem.Click += new System.EventHandler(this.archiveChangeToolStripMenuItem_Click);
            // 
            // viewDbPanel
            // 
            this.viewDbPanel.Controls.Add(this.dataGridViewDB);
            this.viewDbPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewDbPanel.Location = new System.Drawing.Point(0, 254);
            this.viewDbPanel.Name = "viewDbPanel";
            this.viewDbPanel.Size = new System.Drawing.Size(1456, 376);
            this.viewDbPanel.TabIndex = 1;
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDB.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDB.Location = new System.Drawing.Point(12, 0);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.RowHeadersWidth = 62;
            this.dataGridViewDB.RowTemplate.Height = 28;
            this.dataGridViewDB.Size = new System.Drawing.Size(1432, 376);
            this.dataGridViewDB.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(358, 133);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(426, 44);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(219)))), ((int)(((byte)(92)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(219)))), ((int)(((byte)(92)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(816, 133);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 630);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.viewDbPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.userInfo.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postUserPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.viewDbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel viewDbPanel;
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.Label userSurnameLabel;
        private System.Windows.Forms.Label userPostLabel;
        private System.Windows.Forms.Panel userInfo;
        private System.Windows.Forms.Label userPatronymicLabel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.PictureBox postUserPicture;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.PictureBox btnCloseProgram;
        private System.Windows.Forms.ToolStripMenuItem FinanceViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFinanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFinanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem WarehouseViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveChangeToolStripMenuItem;
    }
}