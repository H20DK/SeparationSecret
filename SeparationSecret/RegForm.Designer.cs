﻿
namespace SeparationSecret
{
    partial class RegForm
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
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtPatronymic = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            label5 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem, языкToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(828, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(196, 22);
            выходToolStripMenuItem.Text = "Выход из приложения";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, руководствоПользователяToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(221, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(221, 22);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            руководствоПользователяToolStripMenuItem.Click += руководствоПользователяToolStripMenuItem_Click;
            // 
            // языкToolStripMenuItem
            // 
            языкToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { русскийToolStripMenuItem, englishToolStripMenuItem });
            языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            языкToolStripMenuItem.Size = new Size(46, 20);
            языкToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            русскийToolStripMenuItem.Size = new Size(119, 22);
            русскийToolStripMenuItem.Text = "Русский";
            русскийToolStripMenuItem.Click += русскийToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(119, 22);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // helpProvider
            // 
            helpProvider.HelpNamespace = "SeparationSecretHelp.chm";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.Location = new Point(323, 51);
            label.Name = "label";
            label.Size = new Size(162, 32);
            label.TabIndex = 6;
            label.Text = "Регистрация";
            label.Click += label_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 121);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Фамилия*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 181);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Имя*";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = SystemColors.Menu;
            txtSurname.Location = new Point(240, 139);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Menu;
            txtName.Location = new Point(240, 199);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 20;
            // 
            // txtPatronymic
            // 
            txtPatronymic.BackColor = SystemColors.Menu;
            txtPatronymic.Location = new Point(240, 252);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(100, 23);
            txtPatronymic.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 234);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 22;
            label3.Text = "Отчество (при наличии)";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(324, 307);
            button2.Name = "button2";
            button2.Size = new Size(182, 35);
            button2.TabIndex = 23;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 181);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 24;
            label4.Text = "Придумайте пароль*";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Menu;
            txtPassword.Location = new Point(454, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 25;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.Menu;
            txtLogin.Location = new Point(454, 139);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 27;
            txtLogin.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 121);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 26;
            label5.Text = "Придумайте логин*";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(324, 358);
            button1.Name = "button1";
            button1.Size = new Size(182, 35);
            button1.TabIndex = 28;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(828, 458);
            Controls.Add(button1);
            Controls.Add(txtLogin);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtPatronymic);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Separation Secret";
            Load += RegForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private HelpProvider helpProvider;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem языкToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private ToolStripMenuItem русскийToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private Label label;
        private Label label1;
        private Label label2;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtPatronymic;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Label label5;
        private Button button1;
    }
}