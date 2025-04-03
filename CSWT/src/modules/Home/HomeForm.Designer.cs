namespace CSWT
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.drugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // drugPanel
            // 
            this.drugPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drugPanel.Controls.Add(this.openSignUpButton);
            this.drugPanel.Controls.Add(this.openSignInButton);
            this.drugPanel.Controls.Add(this.label1);
            this.drugPanel.Controls.Add(this.exitButton);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(1424, 53);
            this.drugPanel.TabIndex = 0;
            // 
            // openSignUpButton
            // 
            this.openSignUpButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSignUpButton.FlatAppearance.BorderSize = 0;
            this.openSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSignUpButton.Location = new System.Drawing.Point(289, 12);
            this.openSignUpButton.Name = "openSignUpButton";
            this.openSignUpButton.Size = new System.Drawing.Size(143, 30);
            this.openSignUpButton.TabIndex = 3;
            this.openSignUpButton.Text = "Регистрация";
            this.openSignUpButton.UseVisualStyleBackColor = false;
            this.openSignUpButton.Click += new System.EventHandler(this.openSignUpButton_Click);
            // 
            // openSignInButton
            // 
            this.openSignInButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openSignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSignInButton.FlatAppearance.BorderSize = 0;
            this.openSignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSignInButton.Location = new System.Drawing.Point(128, 12);
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
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 748);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1424, 23);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 672);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1401, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 672);
            this.panel5.TabIndex = 4;
            // 
            // childrenPanel
            // 
            this.childrenPanel.BackColor = System.Drawing.SystemColors.Window;
            this.childrenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenPanel.Location = new System.Drawing.Point(23, 76);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(1378, 672);
            this.childrenPanel.TabIndex = 5;
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
            this.Name = "HomeForm";
            this.Text = "Home";
            this.drugPanel.ResumeLayout(false);
            this.drugPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
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
    }
}

