namespace CSWT.src.modules.Entities
{
    partial class EntitiesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.openUsersButton = new System.Windows.Forms.Button();
            this.openDepartmentButton = new System.Windows.Forms.Button();
            this.openPrioritiesButton = new System.Windows.Forms.Button();
            this.openStatusesButton = new System.Windows.Forms.Button();
            this.openRolesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.openTicketsButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.openTicketsButton);
            this.panel2.Controls.Add(this.openUsersButton);
            this.panel2.Controls.Add(this.openDepartmentButton);
            this.panel2.Controls.Add(this.openPrioritiesButton);
            this.panel2.Controls.Add(this.openStatusesButton);
            this.panel2.Controls.Add(this.openRolesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 40);
            this.panel2.TabIndex = 0;
            // 
            // openUsersButton
            // 
            this.openUsersButton.BackColor = System.Drawing.Color.Wheat;
            this.openUsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openUsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openUsersButton.FlatAppearance.BorderSize = 0;
            this.openUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openUsersButton.Location = new System.Drawing.Point(538, 5);
            this.openUsersButton.Name = "openUsersButton";
            this.openUsersButton.Size = new System.Drawing.Size(127, 30);
            this.openUsersButton.TabIndex = 7;
            this.openUsersButton.Text = "Пользователи";
            this.openUsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openUsersButton.UseVisualStyleBackColor = false;
            this.openUsersButton.Click += new System.EventHandler(this.openUsersButton_Click);
            // 
            // openDepartmentButton
            // 
            this.openDepartmentButton.BackColor = System.Drawing.Color.Wheat;
            this.openDepartmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openDepartmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openDepartmentButton.FlatAppearance.BorderSize = 0;
            this.openDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDepartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDepartmentButton.Location = new System.Drawing.Point(405, 5);
            this.openDepartmentButton.Name = "openDepartmentButton";
            this.openDepartmentButton.Size = new System.Drawing.Size(127, 30);
            this.openDepartmentButton.TabIndex = 7;
            this.openDepartmentButton.Text = "Отделы";
            this.openDepartmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDepartmentButton.UseVisualStyleBackColor = false;
            this.openDepartmentButton.Click += new System.EventHandler(this.openDepartmentButton_Click);
            // 
            // openPrioritiesButton
            // 
            this.openPrioritiesButton.BackColor = System.Drawing.Color.Wheat;
            this.openPrioritiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPrioritiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPrioritiesButton.FlatAppearance.BorderSize = 0;
            this.openPrioritiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPrioritiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPrioritiesButton.Location = new System.Drawing.Point(272, 3);
            this.openPrioritiesButton.Name = "openPrioritiesButton";
            this.openPrioritiesButton.Size = new System.Drawing.Size(127, 30);
            this.openPrioritiesButton.TabIndex = 7;
            this.openPrioritiesButton.Text = "Приоритеты";
            this.openPrioritiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openPrioritiesButton.UseVisualStyleBackColor = false;
            this.openPrioritiesButton.Click += new System.EventHandler(this.openPrioritiesButton_Click);
            // 
            // openStatusesButton
            // 
            this.openStatusesButton.BackColor = System.Drawing.Color.Wheat;
            this.openStatusesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openStatusesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openStatusesButton.FlatAppearance.BorderSize = 0;
            this.openStatusesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStatusesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStatusesButton.Location = new System.Drawing.Point(139, 5);
            this.openStatusesButton.Name = "openStatusesButton";
            this.openStatusesButton.Size = new System.Drawing.Size(127, 30);
            this.openStatusesButton.TabIndex = 7;
            this.openStatusesButton.Text = "Статусы";
            this.openStatusesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openStatusesButton.UseVisualStyleBackColor = false;
            this.openStatusesButton.Click += new System.EventHandler(this.openStatusesButton_Click);
            // 
            // openRolesButton
            // 
            this.openRolesButton.BackColor = System.Drawing.Color.Wheat;
            this.openRolesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openRolesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openRolesButton.FlatAppearance.BorderSize = 0;
            this.openRolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRolesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRolesButton.Location = new System.Drawing.Point(6, 5);
            this.openRolesButton.Name = "openRolesButton";
            this.openRolesButton.Size = new System.Drawing.Size(127, 30);
            this.openRolesButton.TabIndex = 7;
            this.openRolesButton.Text = "Роли";
            this.openRolesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openRolesButton.UseVisualStyleBackColor = false;
            this.openRolesButton.Click += new System.EventHandler(this.openRolesButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 16);
            this.panel1.TabIndex = 1;
            // 
            // childrenPanel
            // 
            this.childrenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenPanel.Location = new System.Drawing.Point(0, 56);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(1155, 616);
            this.childrenPanel.TabIndex = 2;
            // 
            // openTicketsButton
            // 
            this.openTicketsButton.BackColor = System.Drawing.Color.Wheat;
            this.openTicketsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openTicketsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openTicketsButton.FlatAppearance.BorderSize = 0;
            this.openTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTicketsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTicketsButton.Location = new System.Drawing.Point(671, 7);
            this.openTicketsButton.Name = "openTicketsButton";
            this.openTicketsButton.Size = new System.Drawing.Size(127, 30);
            this.openTicketsButton.TabIndex = 7;
            this.openTicketsButton.Text = "Заявки";
            this.openTicketsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openTicketsButton.UseVisualStyleBackColor = false;
            this.openTicketsButton.Click += new System.EventHandler(this.openTicketsButton_Click);
            // 
            // EntitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.childrenPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntitiesForm";
            this.Text = "EntitiesForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openRolesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel childrenPanel;
        private System.Windows.Forms.Button openStatusesButton;
        private System.Windows.Forms.Button openPrioritiesButton;
        private System.Windows.Forms.Button openDepartmentButton;
        private System.Windows.Forms.Button openUsersButton;
        private System.Windows.Forms.Button openTicketsButton;
    }
}