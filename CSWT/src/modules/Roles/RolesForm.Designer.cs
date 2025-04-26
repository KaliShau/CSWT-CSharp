namespace CSWT.src.modules.Roles
{
    partial class RolesForm
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
            this.Roles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RolesList = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.descriptionLine = new System.Windows.Forms.Panel();
            this.nameLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createRoleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Roles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roles
            // 
            this.Roles.Controls.Add(this.tabPage1);
            this.Roles.Controls.Add(this.tabPage2);
            this.Roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roles.Location = new System.Drawing.Point(0, 0);
            this.Roles.Name = "Roles";
            this.Roles.SelectedIndex = 0;
            this.Roles.Size = new System.Drawing.Size(1155, 616);
            this.Roles.TabIndex = 0;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RolesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все роли";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Форма ролей";
            // 
            // RolesList
            // 
            this.RolesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RolesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolesList.HideSelection = false;
            this.RolesList.Location = new System.Drawing.Point(3, 52);
            this.RolesList.Name = "RolesList";
            this.RolesList.Size = new System.Drawing.Size(1141, 533);
            this.RolesList.TabIndex = 33;
            this.RolesList.UseCompatibleStateImageBehavior = false;
            this.RolesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RolesList_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.descriptionLine);
            this.tabPage2.Controls.Add(this.nameLine);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.descriptionBox);
            this.tabPage2.Controls.Add(this.nameBox);
            this.tabPage2.Controls.Add(this.createRoleButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // descriptionLine
            // 
            this.descriptionLine.BackColor = System.Drawing.Color.PowderBlue;
            this.descriptionLine.Location = new System.Drawing.Point(301, 296);
            this.descriptionLine.Name = "descriptionLine";
            this.descriptionLine.Size = new System.Drawing.Size(541, 5);
            this.descriptionLine.TabIndex = 40;
            // 
            // nameLine
            // 
            this.nameLine.BackColor = System.Drawing.Color.PowderBlue;
            this.nameLine.Location = new System.Drawing.Point(301, 132);
            this.nameLine.Name = "nameLine";
            this.nameLine.Size = new System.Drawing.Size(541, 5);
            this.nameLine.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Заголовок";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(301, 164);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(541, 132);
            this.descriptionBox.TabIndex = 34;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(301, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(541, 31);
            this.nameBox.TabIndex = 35;
            // 
            // createRoleButton
            // 
            this.createRoleButton.BackColor = System.Drawing.Color.PowderBlue;
            this.createRoleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRoleButton.FlatAppearance.BorderSize = 0;
            this.createRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRoleButton.Location = new System.Drawing.Point(412, 502);
            this.createRoleButton.Name = "createRoleButton";
            this.createRoleButton.Size = new System.Drawing.Size(297, 42);
            this.createRoleButton.TabIndex = 33;
            this.createRoleButton.Text = "Создать";
            this.createRoleButton.UseVisualStyleBackColor = false;
            this.createRoleButton.Click += new System.EventHandler(this.createRoleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Форма создания роли";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 616);
            this.Controls.Add(this.Roles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolesForm";
            this.Text = "RolesForm";
            this.Roles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Roles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView RolesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel descriptionLine;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button createRoleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}