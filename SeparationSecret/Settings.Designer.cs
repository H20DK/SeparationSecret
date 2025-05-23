namespace SeparationSecret
{
    partial class Settings
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            языкToolStripMenuItem = new ToolStripMenuItem();
            русскийToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            helpProvider = new HelpProvider();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 127);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Форма смены пароля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 212);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 297);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите новый пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 259);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 3;
            label4.Text = "Введите текущий пароль";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem, языкToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(946, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(249, 26);
            выходToolStripMenuItem.Text = "Выход из приложения";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, руководствоПользователяToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(278, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(278, 26);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            руководствоПользователяToolStripMenuItem.Click += руководствоПользователяToolStripMenuItem_Click;
            // 
            // языкToolStripMenuItem
            // 
            языкToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { русскийToolStripMenuItem, englishToolStripMenuItem });
            языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            языкToolStripMenuItem.Size = new Size(57, 24);
            языкToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            русскийToolStripMenuItem.Size = new Size(224, 26);
            русскийToolStripMenuItem.Text = "Русский";
            русскийToolStripMenuItem.Click += русскийToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(224, 26);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // helpProvider
            // 
            helpProvider.HelpNamespace = "SeparationSecretHelp.chm";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(textBox2, "faq.htm");
            helpProvider.SetHelpNavigator(textBox2, HelpNavigator.TopicId);
            textBox2.Location = new Point(425, 209);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            helpProvider.SetShowHelp(textBox2, true);
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpProvider.SetHelpKeyword(button1, "faq.htm");
            helpProvider.SetHelpNavigator(button1, HelpNavigator.Topic);
            button1.Location = new Point(293, 368);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            helpProvider.SetShowHelp(button1, true);
            button1.Size = new Size(188, 44);
            button1.TabIndex = 17;
            button1.Text = "Сменить пароль";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(textBox1, "faq.htm");
            helpProvider.SetHelpNavigator(textBox1, HelpNavigator.TopicId);
            textBox1.Location = new Point(487, 256);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            helpProvider.SetShowHelp(textBox1, true);
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(textBox3, "faq.htm");
            helpProvider.SetHelpNavigator(textBox3, HelpNavigator.TopicId);
            textBox3.Location = new Point(487, 297);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            helpProvider.SetShowHelp(textBox3, true);
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 20;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(946, 611);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Separation Secret";
            Load += Settings_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private ToolStripMenuItem языкToolStripMenuItem;
        private ToolStripMenuItem русскийToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private HelpProvider helpProvider;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}