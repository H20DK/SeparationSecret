
namespace SeparationSecret
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходИзАккаунтаToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            историяToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            языкToolStripMenuItem = new ToolStripMenuItem();
            русскийToolStripMenuItem = new ToolStripMenuItem();
            английскийToolStripMenuItem = new ToolStripMenuItem();
            аккаунтToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label10 = new Label();
            btnSplit = new Button();
            btnRestore_Click = new Button();
            txtSecret = new TextBox();
            txtPartsCount = new TextBox();
            txtRestorePartsCount = new TextBox();
            helpProvider = new HelpProvider();
            btnSave = new Button();
            btnCalculate_Click = new Button();
            dgvShares = new DataGridView();
            dgvRestore = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRestore).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem, языкToolStripMenuItem, аккаунтToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1131, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходИзАккаунтаToolStripMenuItem, файлToolStripMenuItem1, историяToolStripMenuItem, настройкиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(63, 20);
            файлToolStripMenuItem.Text = "Аккаунт";
            // 
            // выходИзАккаунтаToolStripMenuItem
            // 
            выходИзАккаунтаToolStripMenuItem.Name = "выходИзАккаунтаToolStripMenuItem";
            выходИзАккаунтаToolStripMenuItem.Size = new Size(196, 22);
            выходИзАккаунтаToolStripMenuItem.Text = "Выход из аккаунта";
            выходИзАккаунтаToolStripMenuItem.Click += выходИзАккаунтаToolStripMenuItem_Click;
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(196, 22);
            файлToolStripMenuItem1.Text = "Выход из приложения";
            файлToolStripMenuItem1.Click += файлToolStripMenuItem1_Click;
            // 
            // историяToolStripMenuItem
            // 
            историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            историяToolStripMenuItem.Size = new Size(196, 22);
            историяToolStripMenuItem.Text = "История";
            историяToolStripMenuItem.Click += историяToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(196, 22);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
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
            языкToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { русскийToolStripMenuItem, английскийToolStripMenuItem });
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
            // английскийToolStripMenuItem
            // 
            английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            английскийToolStripMenuItem.Size = new Size(119, 22);
            английскийToolStripMenuItem.Text = "English";
            английскийToolStripMenuItem.Click += английскийToolStripMenuItem_Click_1;
            // 
            // аккаунтToolStripMenuItem
            // 
            аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            аккаунтToolStripMenuItem.Size = new Size(12, 20);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 92);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите секрет :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 121);
            label3.Name = "label3";
            label3.Size = new Size(208, 15);
            label3.TabIndex = 3;
            label3.Text = "Введите количество частей секрета :";
            label3.Click += label3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 293);
            label10.Name = "label10";
            label10.Size = new Size(208, 15);
            label10.TabIndex = 10;
            label10.Text = "Введите количество частей секрета :";
            // 
            // btnSplit
            // 
            btnSplit.BackColor = SystemColors.Menu;
            btnSplit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpProvider.SetHelpKeyword(btnSplit, "faq.htm");
            helpProvider.SetHelpNavigator(btnSplit, HelpNavigator.Topic);
            btnSplit.Location = new Point(48, 47);
            btnSplit.Name = "btnSplit";
            helpProvider.SetShowHelp(btnSplit, true);
            btnSplit.Size = new Size(157, 36);
            btnSplit.TabIndex = 12;
            btnSplit.Text = "Разделить секрет";
            btnSplit.UseVisualStyleBackColor = false;
            btnSplit.Click += btnSplit_Click;
            // 
            // btnRestore_Click
            // 
            btnRestore_Click.BackColor = SystemColors.Menu;
            btnRestore_Click.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpProvider.SetHelpKeyword(btnRestore_Click, "faq.htm");
            helpProvider.SetHelpNavigator(btnRestore_Click, HelpNavigator.TopicId);
            btnRestore_Click.Location = new Point(48, 257);
            btnRestore_Click.Name = "btnRestore_Click";
            helpProvider.SetShowHelp(btnRestore_Click, true);
            btnRestore_Click.Size = new Size(252, 33);
            btnRestore_Click.TabIndex = 13;
            btnRestore_Click.Text = "Подготовить восстановление";
            btnRestore_Click.UseVisualStyleBackColor = false;
            btnRestore_Click.Click += button2_Click;
            // 
            // txtSecret
            // 
            txtSecret.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(txtSecret, "faq.htm");
            helpProvider.SetHelpNavigator(txtSecret, HelpNavigator.TopicId);
            txtSecret.Location = new Point(184, 89);
            txtSecret.Name = "txtSecret";
            helpProvider.SetShowHelp(txtSecret, true);
            txtSecret.Size = new Size(100, 23);
            txtSecret.TabIndex = 15;
            // 
            // txtPartsCount
            // 
            txtPartsCount.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(txtPartsCount, "faq.htm");
            helpProvider.SetHelpNavigator(txtPartsCount, HelpNavigator.TopicId);
            txtPartsCount.Location = new Point(297, 118);
            txtPartsCount.Name = "txtPartsCount";
            helpProvider.SetShowHelp(txtPartsCount, true);
            txtPartsCount.Size = new Size(100, 23);
            txtPartsCount.TabIndex = 21;
            // 
            // txtRestorePartsCount
            // 
            txtRestorePartsCount.BackColor = SystemColors.Menu;
            helpProvider.SetHelpKeyword(txtRestorePartsCount, "faq.htm");
            helpProvider.SetHelpNavigator(txtRestorePartsCount, HelpNavigator.TopicId);
            txtRestorePartsCount.Location = new Point(296, 290);
            txtRestorePartsCount.Name = "txtRestorePartsCount";
            helpProvider.SetShowHelp(txtRestorePartsCount, true);
            txtRestorePartsCount.Size = new Size(100, 23);
            txtRestorePartsCount.TabIndex = 26;
            // 
            // helpProvider
            // 
            helpProvider.HelpNamespace = "SeparationSecretHelp.chm";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Menu;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpProvider.SetHelpKeyword(btnSave, "faq.htm");
            helpProvider.SetHelpNavigator(btnSave, HelpNavigator.Topic);
            btnSave.Location = new Point(737, 215);
            btnSave.Name = "btnSave";
            helpProvider.SetShowHelp(btnSave, true);
            btnSave.Size = new Size(157, 36);
            btnSave.TabIndex = 36;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCalculate_Click
            // 
            btnCalculate_Click.BackColor = SystemColors.Menu;
            btnCalculate_Click.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpProvider.SetHelpKeyword(btnCalculate_Click, "faq.htm");
            helpProvider.SetHelpNavigator(btnCalculate_Click, HelpNavigator.Topic);
            btnCalculate_Click.Location = new Point(428, 379);
            btnCalculate_Click.Name = "btnCalculate_Click";
            helpProvider.SetShowHelp(btnCalculate_Click, true);
            btnCalculate_Click.Size = new Size(183, 36);
            btnCalculate_Click.TabIndex = 38;
            btnCalculate_Click.Text = "Восстановить секрет";
            btnCalculate_Click.UseVisualStyleBackColor = false;
            btnCalculate_Click.Click += btnCalculate_Click_Click;
            // 
            // dgvShares
            // 
            dgvShares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShares.Location = new Point(618, 47);
            dgvShares.Name = "dgvShares";
            dgvShares.Size = new Size(400, 153);
            dgvShares.TabIndex = 37;
            // 
            // dgvRestore
            // 
            dgvRestore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestore.Location = new Point(48, 330);
            dgvRestore.Name = "dgvRestore";
            dgvRestore.Size = new Size(349, 146);
            dgvRestore.TabIndex = 39;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1131, 503);
            Controls.Add(dgvRestore);
            Controls.Add(btnCalculate_Click);
            Controls.Add(dgvShares);
            Controls.Add(btnSave);
            Controls.Add(txtRestorePartsCount);
            Controls.Add(txtPartsCount);
            Controls.Add(txtSecret);
            Controls.Add(btnRestore_Click);
            Controls.Add(btnSplit);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Separation Secret";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShares).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRestore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users_guide users_guide = new users_guide(userManual[Nlanguage], supportService[Nlanguage]);
            users_guide.ShowDialog();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private ToolStripMenuItem языкToolStripMenuItem;
        private ToolStripMenuItem русскийToolStripMenuItem;
        private ToolStripMenuItem английскийToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label10;
        private Button btnSplit;
        private Button btnRestore_Click;
        private TextBox txtSecret;
        private TextBox txtPartsCount;
        private TextBox txtRestorePartsCount;
        private HelpProvider helpProvider;
        private ToolStripMenuItem выходИзАккаунтаToolStripMenuItem;
        private ToolStripMenuItem аккаунтToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem историяToolStripMenuItem;
        private Button btnSave;
        private DataGridView dgvShares;
        private Button btnCalculate_Click;
        private DataGridView dgvRestore;
    }
}
