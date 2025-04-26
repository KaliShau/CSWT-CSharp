namespace CSWT.src.modules.UpdateUser
{
    partial class UpdateUserForm
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
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DepartamentsList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departamentsBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.roleLine = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailLine = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.firstNameLine = new System.Windows.Forms.Panel();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.usernameLine = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // DepartamentsList
            // 
            this.DepartamentsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DepartamentsList.HideSelection = false;
            this.DepartamentsList.Location = new System.Drawing.Point(0, 402);
            this.DepartamentsList.Name = "DepartamentsList";
            this.DepartamentsList.Size = new System.Drawing.Size(1155, 170);
            this.DepartamentsList.TabIndex = 51;
            this.DepartamentsList.UseCompatibleStateImageBehavior = false;
            this.DepartamentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DepartamentsList_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.departamentsBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.addDepartmentButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 100);
            this.panel1.TabIndex = 50;
            // 
            // departamentsBox
            // 
            this.departamentsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departamentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.departamentsBox.FormattingEnabled = true;
            this.departamentsBox.Location = new System.Drawing.Point(18, 29);
            this.departamentsBox.Name = "departamentsBox";
            this.departamentsBox.Size = new System.Drawing.Size(541, 39);
            this.departamentsBox.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Location = new System.Drawing.Point(18, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 5);
            this.panel4.TabIndex = 71;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addDepartmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addDepartmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDepartmentButton.FlatAppearance.BorderSize = 0;
            this.addDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentButton.Location = new System.Drawing.Point(859, 29);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(270, 36);
            this.addDepartmentButton.TabIndex = 26;
            this.addDepartmentButton.Text = "Добавить";
            this.addDepartmentButton.UseVisualStyleBackColor = false;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Отделы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 34;
            this.label6.Text = "Отделы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Пользователь";
            // 
            // roleBox
            // 
            this.roleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(18, 268);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(541, 39);
            this.roleBox.TabIndex = 72;
            // 
            // roleLine
            // 
            this.roleLine.BackColor = System.Drawing.Color.PowderBlue;
            this.roleLine.Location = new System.Drawing.Point(18, 308);
            this.roleLine.Name = "roleLine";
            this.roleLine.Size = new System.Drawing.Size(541, 5);
            this.roleLine.TabIndex = 71;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(15, 249);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(44, 16);
            this.roleLabel.TabIndex = 70;
            this.roleLabel.Text = "Роли";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Location = new System.Drawing.Point(575, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 5);
            this.panel2.TabIndex = 65;
            // 
            // emailLine
            // 
            this.emailLine.BackColor = System.Drawing.Color.PowderBlue;
            this.emailLine.Location = new System.Drawing.Point(575, 101);
            this.emailLine.Name = "emailLine";
            this.emailLine.Size = new System.Drawing.Size(541, 5);
            this.emailLine.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Location = new System.Drawing.Point(575, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 5);
            this.panel3.TabIndex = 67;
            // 
            // firstNameLine
            // 
            this.firstNameLine.BackColor = System.Drawing.Color.PowderBlue;
            this.firstNameLine.Location = new System.Drawing.Point(18, 227);
            this.firstNameLine.Name = "firstNameLine";
            this.firstNameLine.Size = new System.Drawing.Size(541, 5);
            this.firstNameLine.TabIndex = 66;
            // 
            // passwordLine
            // 
            this.passwordLine.BackColor = System.Drawing.Color.PowderBlue;
            this.passwordLine.Location = new System.Drawing.Point(18, 164);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(541, 5);
            this.passwordLine.TabIndex = 68;
            // 
            // usernameLine
            // 
            this.usernameLine.BackColor = System.Drawing.Color.PowderBlue;
            this.usernameLine.Location = new System.Drawing.Point(18, 101);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.Size = new System.Drawing.Size(541, 5);
            this.usernameLine.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(572, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Пароль";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Логин";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(575, 133);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(541, 31);
            this.phoneNumberBox.TabIndex = 53;
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(575, 70);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(541, 31);
            this.emailBox.TabIndex = 52;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(575, 196);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(541, 31);
            this.lastNameBox.TabIndex = 55;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(18, 196);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(541, 31);
            this.firstNameBox.TabIndex = 54;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(18, 133);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(541, 31);
            this.passwordBox.TabIndex = 56;
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(18, 70);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(541, 31);
            this.usernameBox.TabIndex = 57;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PowderBlue;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(859, 277);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(270, 36);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.roleLine);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.emailLine);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.firstNameLine);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.usernameLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.DepartamentsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView DepartamentsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Panel roleLine;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel emailLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel firstNameLine;
        private System.Windows.Forms.Panel passwordLine;
        private System.Windows.Forms.Panel usernameLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.ComboBox departamentsBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateButton;
    }
}