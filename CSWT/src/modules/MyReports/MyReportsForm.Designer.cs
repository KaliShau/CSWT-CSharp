namespace CSWT.src.modules.MyReports
{
    partial class MyReportsForm
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
            this.searchLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchLine
            // 
            this.searchLine.BackColor = System.Drawing.Color.Wheat;
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
            this.searchButton.BackColor = System.Drawing.Color.Wheat;
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
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Форма моих отчетов";
            // 
            // ReportsList
            // 
            this.ReportsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReportsList.HideSelection = false;
            this.ReportsList.Location = new System.Drawing.Point(0, 122);
            this.ReportsList.Name = "ReportsList";
            this.ReportsList.Size = new System.Drawing.Size(1155, 550);
            this.ReportsList.TabIndex = 26;
            this.ReportsList.UseCompatibleStateImageBehavior = false;
            this.ReportsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportsList_MouseClick);
            this.ReportsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ReportsList_MouseDoubleClick);
            // 
            // MyReportsForm
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
            this.Controls.Add(this.ReportsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyReportsForm";
            this.Text = "MyReportsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ReportsList;
    }
}