namespace CSWT.src.modules.CreateReport
{
    partial class CreateReportForm
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
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.priorityLine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.createReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportBox
            // 
            this.reportBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.reportBox.FormattingEnabled = true;
            this.reportBox.Location = new System.Drawing.Point(18, 82);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(1113, 39);
            this.reportBox.TabIndex = 42;
            // 
            // priorityLine
            // 
            this.priorityLine.BackColor = System.Drawing.Color.PowderBlue;
            this.priorityLine.Location = new System.Drawing.Point(18, 122);
            this.priorityLine.Name = "priorityLine";
            this.priorityLine.Size = new System.Drawing.Size(1113, 5);
            this.priorityLine.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Тип отчета";
            // 
            // createReportButton
            // 
            this.createReportButton.BackColor = System.Drawing.Color.PowderBlue;
            this.createReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createReportButton.FlatAppearance.BorderSize = 0;
            this.createReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReportButton.Location = new System.Drawing.Point(245, 186);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(595, 42);
            this.createReportButton.TabIndex = 33;
            this.createReportButton.Text = "Создать";
            this.createReportButton.UseVisualStyleBackColor = false;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Форма создания отчета";
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.priorityLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReportForm";
            this.Text = "CreateReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.Panel priorityLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Label label1;
    }
}