namespace CSWT.src.modules.AssignedTickets
{
    partial class AssignedTicketsForm
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
            this.searchLine = new System.Windows.Forms.Panel();
            this.TicketsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchLine
            // 
            this.searchLine.BackColor = System.Drawing.Color.Wheat;
            this.searchLine.Location = new System.Drawing.Point(18, 89);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(772, 5);
            this.searchLine.TabIndex = 37;
            // 
            // TicketsList
            // 
            this.TicketsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TicketsList.HideSelection = false;
            this.TicketsList.Location = new System.Drawing.Point(0, 122);
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.Size = new System.Drawing.Size(1155, 550);
            this.TicketsList.TabIndex = 32;
            this.TicketsList.UseCompatibleStateImageBehavior = false;
            this.TicketsList.DoubleClick += new System.EventHandler(this.TicketsList_DoubleClick);
            this.TicketsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicketsList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Форма моих принятых заявок";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Wheat;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(815, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(297, 36);
            this.searchButton.TabIndex = 34;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(18, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(772, 31);
            this.searchBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Поиск";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 26);
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.commentsToolStripMenuItem.Text = "Комментарии";
            this.commentsToolStripMenuItem.Click += new System.EventHandler(this.commentsToolStripMenuItem_Click);
            // 
            // AssignedTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.searchLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignedTicketsForm";
            this.Text = "AssignedTicketsForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchLine;
        private System.Windows.Forms.ListView TicketsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
    }
}