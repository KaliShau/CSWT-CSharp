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
            this.openRolesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.openRolesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 40);
            this.panel2.TabIndex = 0;
            // 
            // openRolesButton
            // 
            this.openRolesButton.BackColor = System.Drawing.Color.PowderBlue;
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
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
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
    }
}