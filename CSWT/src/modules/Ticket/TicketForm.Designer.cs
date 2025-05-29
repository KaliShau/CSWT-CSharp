namespace CSWT.src.modules.Ticket
{
    partial class TicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLine = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.solutionLine = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commentLine = new System.Windows.Forms.Panel();
            this.createCommentButton = new System.Windows.Forms.Button();
            this.CommentsList = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priorityBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Заявка";
            // 
            // titleLine
            // 
            this.titleLine.BackColor = System.Drawing.Color.Wheat;
            this.titleLine.Location = new System.Drawing.Point(18, 95);
            this.titleLine.Name = "titleLine";
            this.titleLine.Size = new System.Drawing.Size(1108, 5);
            this.titleLine.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Заголовок";
            // 
            // titleBox
            // 
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(18, 64);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(1108, 31);
            this.titleBox.TabIndex = 27;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Wheat;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(18, 320);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(470, 36);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(18, 125);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(1108, 85);
            this.descriptionBox.TabIndex = 27;
            // 
            // descriptionLine
            // 
            this.descriptionLine.BackColor = System.Drawing.Color.Wheat;
            this.descriptionLine.Location = new System.Drawing.Point(18, 213);
            this.descriptionLine.Name = "descriptionLine";
            this.descriptionLine.Size = new System.Drawing.Size(1108, 5);
            this.descriptionLine.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Описание";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAtLabel.Location = new System.Drawing.Point(905, 26);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(117, 16);
            this.createdAtLabel.TabIndex = 28;
            this.createdAtLabel.Text = "Дата создания";
            // 
            // solutionBox
            // 
            this.solutionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionBox.Location = new System.Drawing.Point(656, 251);
            this.solutionBox.Multiline = true;
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.Size = new System.Drawing.Size(470, 102);
            this.solutionBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Решение";
            // 
            // solutionLine
            // 
            this.solutionLine.BackColor = System.Drawing.Color.Wheat;
            this.solutionLine.Location = new System.Drawing.Point(656, 351);
            this.solutionLine.Name = "solutionLine";
            this.solutionLine.Size = new System.Drawing.Size(470, 5);
            this.solutionLine.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.commentLine);
            this.panel1.Controls.Add(this.createCommentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 100);
            this.panel1.TabIndex = 30;
            // 
            // commentBox
            // 
            this.commentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentBox.Location = new System.Drawing.Point(12, 26);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(641, 31);
            this.commentBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Содержание";
            // 
            // commentLine
            // 
            this.commentLine.BackColor = System.Drawing.Color.Wheat;
            this.commentLine.Location = new System.Drawing.Point(12, 57);
            this.commentLine.Name = "commentLine";
            this.commentLine.Size = new System.Drawing.Size(641, 5);
            this.commentLine.TabIndex = 29;
            // 
            // createCommentButton
            // 
            this.createCommentButton.BackColor = System.Drawing.Color.Wheat;
            this.createCommentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCommentButton.FlatAppearance.BorderSize = 0;
            this.createCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCommentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCommentButton.Location = new System.Drawing.Point(859, 29);
            this.createCommentButton.Name = "createCommentButton";
            this.createCommentButton.Size = new System.Drawing.Size(270, 36);
            this.createCommentButton.TabIndex = 26;
            this.createCommentButton.Text = "Добавить";
            this.createCommentButton.UseVisualStyleBackColor = false;
            this.createCommentButton.Click += new System.EventHandler(this.createCommentButton_Click);
            // 
            // CommentsList
            // 
            this.CommentsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommentsList.HideSelection = false;
            this.CommentsList.Location = new System.Drawing.Point(0, 402);
            this.CommentsList.Name = "CommentsList";
            this.CommentsList.Size = new System.Drawing.Size(1155, 170);
            this.CommentsList.TabIndex = 31;
            this.CommentsList.UseCompatibleStateImageBehavior = false;
            this.CommentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommentsList_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Комментарии";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Приоритет";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Location = new System.Drawing.Point(109, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 5);
            this.panel2.TabIndex = 29;
            // 
            // priorityBox
            // 
            this.priorityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityBox.Location = new System.Drawing.Point(109, 232);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(379, 31);
            this.priorityBox.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Location = new System.Drawing.Point(109, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 5);
            this.panel3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Статус";
            // 
            // statusBox
            // 
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(109, 274);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(379, 31);
            this.statusBox.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(1088, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(176, 35);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 31);
            this.toolStripMenuItem1.Text = "|||";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Печать";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CommentsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionLine);
            this.Controls.Add(this.solutionLine);
            this.Controls.Add(this.titleLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createdAtLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Panel descriptionLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label createdAtLabel;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel solutionLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView CommentsList;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel commentLine;
        private System.Windows.Forms.Button createCommentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox priorityBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}