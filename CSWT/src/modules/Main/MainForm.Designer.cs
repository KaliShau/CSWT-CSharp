namespace CSWT.src.modules.Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drugPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketGroupBox = new System.Windows.Forms.GroupBox();
            this.openAssignedTickets = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.openAllTickets = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.openMyTickets = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.openCreateTicket = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.openEntitiesButton = new System.Windows.Forms.Button();
            this.drugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.ticketGroupBox.SuspendLayout();
            this.adminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // drugPanel
            // 
            this.drugPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drugPanel.Controls.Add(this.label1);
            this.drugPanel.Controls.Add(this.exitButton);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(1424, 53);
            this.drugPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "CSWT";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 23);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 748);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1424, 23);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 672);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1401, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 672);
            this.panel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminGroupBox);
            this.panel1.Controls.Add(this.ticketGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(23, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 672);
            this.panel1.TabIndex = 6;
            // 
            // ticketGroupBox
            // 
            this.ticketGroupBox.Controls.Add(this.openAssignedTickets);
            this.ticketGroupBox.Controls.Add(this.panel9);
            this.ticketGroupBox.Controls.Add(this.openAllTickets);
            this.ticketGroupBox.Controls.Add(this.panel8);
            this.ticketGroupBox.Controls.Add(this.openMyTickets);
            this.ticketGroupBox.Controls.Add(this.panel7);
            this.ticketGroupBox.Controls.Add(this.openCreateTicket);
            this.ticketGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ticketGroupBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ticketGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ticketGroupBox.Name = "ticketGroupBox";
            this.ticketGroupBox.Size = new System.Drawing.Size(200, 180);
            this.ticketGroupBox.TabIndex = 0;
            this.ticketGroupBox.TabStop = false;
            this.ticketGroupBox.Text = "Заявки";
            // 
            // openAssignedTickets
            // 
            this.openAssignedTickets.BackColor = System.Drawing.Color.PowderBlue;
            this.openAssignedTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openAssignedTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openAssignedTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.openAssignedTickets.FlatAppearance.BorderSize = 0;
            this.openAssignedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAssignedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAssignedTickets.Location = new System.Drawing.Point(3, 143);
            this.openAssignedTickets.Name = "openAssignedTickets";
            this.openAssignedTickets.Size = new System.Drawing.Size(194, 30);
            this.openAssignedTickets.TabIndex = 10;
            this.openAssignedTickets.Text = "Принятые заявки";
            this.openAssignedTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openAssignedTickets.UseVisualStyleBackColor = false;
            this.openAssignedTickets.Click += new System.EventHandler(this.openAssignedTickets_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 10);
            this.panel9.TabIndex = 9;
            // 
            // openAllTickets
            // 
            this.openAllTickets.BackColor = System.Drawing.Color.PowderBlue;
            this.openAllTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openAllTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openAllTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.openAllTickets.FlatAppearance.BorderSize = 0;
            this.openAllTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAllTickets.Location = new System.Drawing.Point(3, 103);
            this.openAllTickets.Name = "openAllTickets";
            this.openAllTickets.Size = new System.Drawing.Size(194, 30);
            this.openAllTickets.TabIndex = 8;
            this.openAllTickets.Text = "Новые заявки";
            this.openAllTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openAllTickets.UseVisualStyleBackColor = false;
            this.openAllTickets.Click += new System.EventHandler(this.openAllTickets_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 10);
            this.panel8.TabIndex = 7;
            // 
            // openMyTickets
            // 
            this.openMyTickets.BackColor = System.Drawing.Color.PowderBlue;
            this.openMyTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openMyTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMyTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMyTickets.FlatAppearance.BorderSize = 0;
            this.openMyTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMyTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMyTickets.Location = new System.Drawing.Point(3, 63);
            this.openMyTickets.Name = "openMyTickets";
            this.openMyTickets.Size = new System.Drawing.Size(194, 30);
            this.openMyTickets.TabIndex = 6;
            this.openMyTickets.Text = "Мои заявки";
            this.openMyTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openMyTickets.UseVisualStyleBackColor = false;
            this.openMyTickets.Click += new System.EventHandler(this.openMyTickets_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 10);
            this.panel7.TabIndex = 5;
            // 
            // openCreateTicket
            // 
            this.openCreateTicket.BackColor = System.Drawing.Color.PowderBlue;
            this.openCreateTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openCreateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCreateTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.openCreateTicket.FlatAppearance.BorderSize = 0;
            this.openCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCreateTicket.Location = new System.Drawing.Point(3, 23);
            this.openCreateTicket.Name = "openCreateTicket";
            this.openCreateTicket.Size = new System.Drawing.Size(194, 30);
            this.openCreateTicket.TabIndex = 4;
            this.openCreateTicket.Text = "Создать заявку";
            this.openCreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCreateTicket.UseVisualStyleBackColor = false;
            this.openCreateTicket.Click += new System.EventHandler(this.openCreateTicket_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(223, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 672);
            this.panel6.TabIndex = 7;
            // 
            // childrenPanel
            // 
            this.childrenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenPanel.Location = new System.Drawing.Point(246, 76);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(1155, 672);
            this.childrenPanel.TabIndex = 8;
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.openEntitiesButton);
            this.adminGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminGroupBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGroupBox.Location = new System.Drawing.Point(0, 180);
            this.adminGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(200, 63);
            this.adminGroupBox.TabIndex = 1;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Администратор";
            // 
            // openEntitiesButton
            // 
            this.openEntitiesButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openEntitiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openEntitiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openEntitiesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openEntitiesButton.FlatAppearance.BorderSize = 0;
            this.openEntitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openEntitiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openEntitiesButton.Location = new System.Drawing.Point(3, 23);
            this.openEntitiesButton.Name = "openEntitiesButton";
            this.openEntitiesButton.Size = new System.Drawing.Size(194, 30);
            this.openEntitiesButton.TabIndex = 5;
            this.openEntitiesButton.Text = "Сущности";
            this.openEntitiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openEntitiesButton.UseVisualStyleBackColor = false;
            this.openEntitiesButton.Click += new System.EventHandler(this.openEntitiesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1424, 771);
            this.Controls.Add(this.childrenPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drugPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.drugPanel.ResumeLayout(false);
            this.drugPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ticketGroupBox.ResumeLayout(false);
            this.adminGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drugPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox ticketGroupBox;
        private System.Windows.Forms.Button openCreateTicket;
        private System.Windows.Forms.Panel childrenPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button openMyTickets;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button openAllTickets;
        private System.Windows.Forms.Button openAssignedTickets;
        private System.Windows.Forms.GroupBox adminGroupBox;
        private System.Windows.Forms.Button openEntitiesButton;
    }
}