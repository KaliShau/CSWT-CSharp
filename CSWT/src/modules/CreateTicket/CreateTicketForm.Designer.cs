namespace CSWT.src.modules.CreateTicket
{
    partial class CreateTicketForm
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
            this.descriptionLine = new System.Windows.Forms.Panel();
            this.titleLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.createTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.priorityLine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionLine
            // 
            this.descriptionLine.BackColor = System.Drawing.Color.PowderBlue;
            this.descriptionLine.Location = new System.Drawing.Point(305, 290);
            this.descriptionLine.Name = "descriptionLine";
            this.descriptionLine.Size = new System.Drawing.Size(541, 5);
            this.descriptionLine.TabIndex = 29;
            // 
            // titleLine
            // 
            this.titleLine.BackColor = System.Drawing.Color.PowderBlue;
            this.titleLine.Location = new System.Drawing.Point(305, 126);
            this.titleLine.Name = "titleLine";
            this.titleLine.Size = new System.Drawing.Size(541, 5);
            this.titleLine.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Заголовок";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(305, 158);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(541, 132);
            this.descriptionBox.TabIndex = 25;
            // 
            // titleBox
            // 
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(305, 95);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(541, 31);
            this.titleBox.TabIndex = 26;
            // 
            // createTicketButton
            // 
            this.createTicketButton.BackColor = System.Drawing.Color.PowderBlue;
            this.createTicketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createTicketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTicketButton.FlatAppearance.BorderSize = 0;
            this.createTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTicketButton.Location = new System.Drawing.Point(416, 496);
            this.createTicketButton.Name = "createTicketButton";
            this.createTicketButton.Size = new System.Drawing.Size(297, 42);
            this.createTicketButton.TabIndex = 24;
            this.createTicketButton.Text = "Создать";
            this.createTicketButton.UseVisualStyleBackColor = false;
            this.createTicketButton.Click += new System.EventHandler(this.createTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Форма создания заявки";
            // 
            // priorityBox
            // 
            this.priorityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(305, 321);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(541, 39);
            this.priorityBox.TabIndex = 31;
            // 
            // priorityLine
            // 
            this.priorityLine.BackColor = System.Drawing.Color.PowderBlue;
            this.priorityLine.Location = new System.Drawing.Point(305, 361);
            this.priorityLine.Name = "priorityLine";
            this.priorityLine.Size = new System.Drawing.Size(541, 5);
            this.priorityLine.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Приоритет";
            // 
            // CreateTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLine);
            this.Controls.Add(this.descriptionLine);
            this.Controls.Add(this.titleLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.createTicketButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTicketForm";
            this.Text = "CreateTicktForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel descriptionLine;
        private System.Windows.Forms.Panel titleLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button createTicketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Panel priorityLine;
        private System.Windows.Forms.Label label4;
    }
}