namespace CSWT.src.modules.Users
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            this.UsersList = new System.Windows.Forms.ListView();
            this.Users = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.priorityLine = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailLine = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstNameLine = new System.Windows.Forms.Panel();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.usernameLine = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersList.HideSelection = false;
            this.UsersList.Location = new System.Drawing.Point(3, 52);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(1141, 533);
            this.UsersList.TabIndex = 33;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersList_MouseClick);
            // 
            // Users
            // 
            this.Users.Controls.Add(this.tabPage1);
            this.Users.Controls.Add(this.tabPage2);
            this.Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(0, 0);
            this.Users.Name = "Users";
            this.Users.SelectedIndex = 0;
            this.Users.Size = new System.Drawing.Size(1155, 616);
            this.Users.TabIndex = 1;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.UsersList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Форма пользователей";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roleBox);
            this.tabPage2.Controls.Add(this.priorityLine);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.emailLine);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.firstNameLine);
            this.tabPage2.Controls.Add(this.passwordLine);
            this.tabPage2.Controls.Add(this.usernameLine);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.phoneNumberBox);
            this.tabPage2.Controls.Add(this.emailBox);
            this.tabPage2.Controls.Add(this.lastNameBox);
            this.tabPage2.Controls.Add(this.firstNameBox);
            this.tabPage2.Controls.Add(this.passwordBox);
            this.tabPage2.Controls.Add(this.usernameBox);
            this.tabPage2.Controls.Add(this.createUserButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roleBox
            // 
            this.roleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(12, 276);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(541, 39);
            this.roleBox.TabIndex = 48;
            // 
            // priorityLine
            // 
            this.priorityLine.BackColor = System.Drawing.Color.Wheat;
            this.priorityLine.Location = new System.Drawing.Point(12, 316);
            this.priorityLine.Name = "priorityLine";
            this.priorityLine.Size = new System.Drawing.Size(541, 5);
            this.priorityLine.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Роли";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Location = new System.Drawing.Point(569, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 5);
            this.panel1.TabIndex = 42;
            // 
            // emailLine
            // 
            this.emailLine.BackColor = System.Drawing.Color.Wheat;
            this.emailLine.Location = new System.Drawing.Point(569, 109);
            this.emailLine.Name = "emailLine";
            this.emailLine.Size = new System.Drawing.Size(541, 5);
            this.emailLine.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Location = new System.Drawing.Point(569, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 5);
            this.panel2.TabIndex = 43;
            // 
            // firstNameLine
            // 
            this.firstNameLine.BackColor = System.Drawing.Color.Wheat;
            this.firstNameLine.Location = new System.Drawing.Point(12, 235);
            this.firstNameLine.Name = "firstNameLine";
            this.firstNameLine.Size = new System.Drawing.Size(541, 5);
            this.firstNameLine.TabIndex = 43;
            // 
            // passwordLine
            // 
            this.passwordLine.BackColor = System.Drawing.Color.Wheat;
            this.passwordLine.Location = new System.Drawing.Point(12, 172);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(541, 5);
            this.passwordLine.TabIndex = 44;
            // 
            // usernameLine
            // 
            this.usernameLine.BackColor = System.Drawing.Color.Wheat;
            this.usernameLine.Location = new System.Drawing.Point(12, 109);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.Size = new System.Drawing.Size(541, 5);
            this.usernameLine.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(566, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Логин";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(569, 141);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(541, 31);
            this.phoneNumberBox.TabIndex = 34;
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(569, 78);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(541, 31);
            this.emailBox.TabIndex = 34;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(569, 204);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(541, 31);
            this.lastNameBox.TabIndex = 35;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(12, 204);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(541, 31);
            this.firstNameBox.TabIndex = 35;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(12, 141);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(541, 31);
            this.passwordBox.TabIndex = 36;
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(12, 78);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(541, 31);
            this.usernameBox.TabIndex = 37;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.Wheat;
            this.createUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserButton.FlatAppearance.BorderSize = 0;
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.Location = new System.Drawing.Point(412, 502);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(297, 42);
            this.createUserButton.TabIndex = 33;
            this.createUserButton.Text = "Создать";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Форма создания пользователя";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Редактировать";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 616);
            this.Controls.Add(this.Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Users.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UsersList;
        private System.Windows.Forms.TabControl Users;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel emailLine;
        private System.Windows.Forms.Panel firstNameLine;
        private System.Windows.Forms.Panel passwordLine;
        private System.Windows.Forms.Panel usernameLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Panel priorityLine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}