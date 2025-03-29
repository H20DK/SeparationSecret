namespace SeparationSecret
{
    partial class about_the_program
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 87);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 5;
            label1.Text = "Богомаз Александр Артемович\r\nПогодин Роман Дмитриевич";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 20);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = "Separation Secret";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 87);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "Разработчики :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 54);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Версия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 54);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 9;
            label5.Text = "1.0";
            // 
            // about_the_program
            // 
            AccessibleDescription = "about_the_program";
            AccessibleName = "about_the_program";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 137);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "about_the_program";
            StartPosition = FormStartPosition.CenterScreen;
            Load += О_программе_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}