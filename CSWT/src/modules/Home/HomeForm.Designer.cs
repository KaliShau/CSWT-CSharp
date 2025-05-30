﻿namespace CSWT
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.drugPanel = new System.Windows.Forms.Panel();
            this.openSignUpButton = new System.Windows.Forms.Button();
            this.openSignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.childrenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drugPanel
            // 
            this.drugPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drugPanel.Controls.Add(this.pictureBox1);
            this.drugPanel.Controls.Add(this.openSignUpButton);
            this.drugPanel.Controls.Add(this.openSignInButton);
            this.drugPanel.Controls.Add(this.label1);
            this.drugPanel.Controls.Add(this.exitButton);
            this.drugPanel.Controls.Add(this.menuStrip1);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(1424, 53);
            this.drugPanel.TabIndex = 0;
            // 
            // openSignUpButton
            // 
            this.openSignUpButton.BackColor = System.Drawing.Color.Wheat;
            this.openSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSignUpButton.FlatAppearance.BorderSize = 0;
            this.openSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSignUpButton.Location = new System.Drawing.Point(389, 13);
            this.openSignUpButton.Name = "openSignUpButton";
            this.openSignUpButton.Size = new System.Drawing.Size(143, 30);
            this.openSignUpButton.TabIndex = 3;
            this.openSignUpButton.Text = "Регистрация";
            this.openSignUpButton.UseVisualStyleBackColor = false;
            this.openSignUpButton.Click += new System.EventHandler(this.openSignUpButton_Click);
            // 
            // openSignInButton
            // 
            this.openSignInButton.BackColor = System.Drawing.Color.Wheat;
            this.openSignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSignInButton.FlatAppearance.BorderSize = 0;
            this.openSignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSignInButton.Location = new System.Drawing.Point(228, 13);
            this.openSignInButton.Name = "openSignInButton";
            this.openSignInButton.Size = new System.Drawing.Size(143, 30);
            this.openSignInButton.TabIndex = 3;
            this.openSignInButton.Text = "Вход";
            this.openSignInButton.UseVisualStyleBackColor = false;
            this.openSignInButton.Click += new System.EventHandler(this.openSignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отдел АСУ";
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1368, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10);
            this.exitButton.Size = new System.Drawing.Size(56, 53);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(548, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(98, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingDBToolStripMenuItem});
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.бДToolStripMenuItem.Text = "Настройки";
            // 
            // settingDBToolStripMenuItem
            // 
            this.settingDBToolStripMenuItem.Name = "settingDBToolStripMenuItem";
            this.settingDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingDBToolStripMenuItem.Text = "Настройки БД";
            this.settingDBToolStripMenuItem.Click += new System.EventHandler(this.settingDBToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 23);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 748);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1424, 23);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 672);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1401, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 672);
            this.panel5.TabIndex = 4;
            // 
            // childrenPanel
            // 
            this.childrenPanel.BackColor = System.Drawing.SystemColors.Window;
            this.childrenPanel.Controls.Add(this.label3);
            this.childrenPanel.Controls.Add(this.label2);
            this.childrenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenPanel.Location = new System.Drawing.Point(23, 76);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(1378, 672);
            this.childrenPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "Чтобы продолжить, войдите в свой аккаунт или зарегистрируйтесь.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добро пожаловать!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1424, 771);
            this.Controls.Add(this.childrenPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drugPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.drugPanel.ResumeLayout(false);
            this.drugPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.childrenPanel.ResumeLayout(false);
            this.childrenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drugPanel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openSignInButton;
        private System.Windows.Forms.Button openSignUpButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel childrenPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingDBToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

