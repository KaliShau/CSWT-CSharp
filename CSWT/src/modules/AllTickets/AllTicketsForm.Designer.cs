namespace CSWT.src.modules.AllTickets
{
    partial class AllTicketsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketsList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchLine
            // 
            this.searchLine.BackColor = System.Drawing.Color.PowderBlue;
            this.searchLine.Location = new System.Drawing.Point(18, 91);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(772, 5);
            this.searchLine.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Поиск";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(18, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(772, 31);
            this.searchBox.TabIndex = 29;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.PowderBlue;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(815, 60);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(297, 36);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Форма всех заявок";
            // 
            // TicketsList
            // 
            this.TicketsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TicketsList.HideSelection = false;
            this.TicketsList.Location = new System.Drawing.Point(0, 122);
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.Size = new System.Drawing.Size(1155, 550);
            this.TicketsList.TabIndex = 26;
            this.TicketsList.UseCompatibleStateImageBehavior = false;
            this.TicketsList.DoubleClick += new System.EventHandler(this.TicketsList_DoubleClick);
            this.TicketsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicketsList_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // assignedToolStripMenuItem
            // 
            this.assignedToolStripMenuItem.Name = "assignedToolStripMenuItem";
            this.assignedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignedToolStripMenuItem.Text = "Принять заявку";
            this.assignedToolStripMenuItem.Click += new System.EventHandler(this.assignedToolStripMenuItem_Click);
            // 
            // AllTicketsForm
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
            this.Name = "AllTicketsForm";
            this.Text = "AllTicketsForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TicketsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assignedToolStripMenuItem;
    }
}