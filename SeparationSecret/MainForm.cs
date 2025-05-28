using Microsoft.VisualBasic.ApplicationServices;
using SecretSharing;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeparationSecret
{
    public partial class MainForm : Form
    {
        public static int NumberLanguage = 0;
        private DataTable sharesTable; // Таблица для хранения частей секрета
        private DataTable restoreTable;
        int Nlanguage
        {
            get
            {
                return NumberLanguage;
            }

            set
            {
                NumberLanguage = value;

                файлToolStripMenuItem.Text = file[Nlanguage];
                файлToolStripMenuItem1.Text = output[Nlanguage];
                выходИзАккаунтаToolStripMenuItem.Text = output2[Nlanguage];
                настройкиToolStripMenuItem.Text = settings[Nlanguage];
                справкаToolStripMenuItem.Text = help[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];
                btnSplit.Text = shareSecret[Nlanguage];
                label2.Text = enterSecret[Nlanguage];
                label3.Text = enterNumberPartsSecret[Nlanguage];
                label4.Text = enterMinimumRequiredNumberPartsSecretRecover[Nlanguage];
                label5.Text = result[Nlanguage];
                btnRestore_Click.Text = recoverSecret[Nlanguage];
                label10.Text = enterNumberPartsSecret[Nlanguage];
                label7.Text = enterNthSecret[Nlanguage];
                label11.Text = result[Nlanguage];
            }
        }
        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView(); // Инициализация таблицы
            InitializeRestoreDataGridView();

            EnsureHelpFileExists(); // Извлекаем файл справки
            Program.RegisterForm(this); // Регистрируем форму

            // Настройка HelpProvider
            helpProvider = new HelpProvider();
            // Используем относительный путь к CHM-файлу
            string helpFilePath = Path.Combine(Application.StartupPath, "Properties", "SeparationSecretHelp.chm");
            helpProvider.HelpNamespace = helpFilePath;
            helpProvider.SetHelpNavigator(this, HelpNavigator.TableOfContents);

            // Включение обработки клавиш на уровне формы
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void EnsureHelpFileExists()
        {
            string helpFilePath = Path.Combine(Application.StartupPath, "Properties", "SeparationSecretHelp.chm");
            if (!File.Exists(helpFilePath))
            {
                File.WriteAllBytes(helpFilePath, Properties.Resources.HelpFile); // Извлекаем из ресурсов
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверка нажатия клавиши F1
            if (e.KeyCode == Keys.F1)
            {
                string helpFilePath = Path.Combine(Application.StartupPath, "Properties", "SeparationSecretHelp.chm");
                if (File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, helpFilePath, "osnovnoj_interfejs.htm");
                }
                else
                {
                    MessageBox.Show($"Файл справки не найден по пути: {helpFilePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // Отмечаем событие как обработанное
            }
        }

        static List<string> file = new List<string>() { "Аккаунт", "Account" };
        static List<string> output = new List<string>() { "Выход из приложения", "Exiting the app" };
        static List<string> output2 = new List<string>() { "Выход из аккаунта", "Exit from account" };
        static List<string> settings = new List<string>() { "Настройки", "Settings" };
        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };
        static List<string> shareSecret = new List<string>() { "Разделить секрет", "Share a secret:" };
        static List<string> enterSecret = new List<string>() { "Введите секрет :", "Enter the secret :" };
        static List<string> enterNumberPartsSecret = new List<string>() { "Введите количество частей секрета :", "Enter the number of parts of the secret :" };
        static List<string> enterMinimumRequiredNumberPartsSecretRecover = new List<string>() { "Введите минимально необходимое кол-во частей секрета для восстановления :", "Enter the minimum required number of parts of secret to recover :" };
        static List<string> result = new List<string>() { "Результат :", "Result :" };
        static List<string> recoverSecret = new List<string>() { "Восстановить секрет", "Recover secret" };
        static List<string> enterNthSecret = new List<string>() { "Введите n-ый секрет:", "Enter the nth secret :" };

        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

        public static List<string> version = new List<string>() { "Версия:", "Version:" };
        public static List<string> developers = new List<string>() { "Разработчики:", "Developers:" };

        public static List<string> supportService = new List<string>() { "Служба поддержки", "Support service" };

        private void файлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void языкToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void английскийToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_the_program about_the_program = new about_the_program(version[Nlanguage], developers[Nlanguage]);
            about_the_program.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void английскийToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutForm AutForm = new AutForm();
            AutForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (restoreTable == null)
                {
                    InitializeRestoreDataGridView();
                }

                if (string.IsNullOrWhiteSpace(txtRestorePartsCount.Text) || !int.TryParse(txtRestorePartsCount.Text, out int partsCount) || partsCount <= 0)
                {
                    MessageBox.Show("Введите корректное количество частей (целое число > 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                restoreTable.Clear();
                string currentDate = DateTime.Now.ToString("dd.MM.yyyy"); // 28.05.2025
                for (int i = 0; i < partsCount; i++)
                {
                    restoreTable.Rows.Add(currentDate, $"Часть секрета {i + 1}", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подготовке восстановления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History History = new History(version[Nlanguage], developers[Nlanguage]);
            History.Show();
            this.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings(version[Nlanguage], developers[Nlanguage]);
            Settings.Show();
            this.Close();
        }

        private void InitializeDataGridView()
        {
            // Проверяем, инициализирован ли dgvShares
            if (dgvShares == null)
            {
                MessageBox.Show("DataGridView (dgvShares) не найден на форме. Проверьте дизайн формы.", "Ошибка инициализации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаём DataTable для хранения частей секрета
            sharesTable = new DataTable();
            sharesTable.Columns.Add("Дата", typeof(string));
            sharesTable.Columns.Add("Описание", typeof(string));
            sharesTable.Columns.Add("Число", typeof(string));
            sharesTable.Columns.Add("Владелец", typeof(string));

            // Настраиваем DataGridView
            dgvShares.DataSource = sharesTable;
            dgvShares.Columns["Дата"].ReadOnly = true;
            dgvShares.Columns["Описание"].ReadOnly = true;
            dgvShares.Columns["Число"].ReadOnly = true;
            dgvShares.Columns["Владелец"].ReadOnly = false;
        }// Только Владелец редактируемый

        private void InitializeRestoreDataGridView()
        {
            if (dgvRestore == null)
            {
                MessageBox.Show("DataGridView (dgvRestore) не найден на форме. Проверьте дизайн формы.", "Ошибка инициализации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            restoreTable = new DataTable();
            restoreTable.Columns.Add("Дата", typeof(string));
            restoreTable.Columns.Add("Описание", typeof(string));
            restoreTable.Columns.Add("Число", typeof(string));
            restoreTable.Columns.Add("Владелец", typeof(string));

            dgvRestore.DataSource = restoreTable;
            dgvRestore.Columns["Дата"].ReadOnly = true;
            dgvRestore.Columns["Описание"].ReadOnly = true;
            dgvRestore.Columns["Число"].ReadOnly = false;
            dgvRestore.Columns["Владелец"].ReadOnly = false;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация ввода
                if (string.IsNullOrWhiteSpace(txtSecret.Text) || !BigInteger.TryParse(txtSecret.Text, out BigInteger secret) || secret <= 0)
                {
                    MessageBox.Show("Введите корректный числовой секрет (целое число > 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPartsCount.Text) || !int.TryParse(txtPartsCount.Text, out int partsCount) || partsCount <= 0)
                {
                    MessageBox.Show("Введите корректное количество частей (целое число > 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMinParts.Text) || !int.TryParse(txtMinParts.Text, out int minParts) || minParts <= 0 || minParts > partsCount)
                {
                    MessageBox.Show("Введите корректное минимальное количество частей (целое число > 0 и ≤ количества частей).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Очищаем таблицу
                sharesTable.Clear();

                // Разделение секрета
                (BigInteger[] remainders, BigInteger[] moduli) = SplitSecret(secret, partsCount, minParts);

                // Заполняем таблицу
                string currentDate = DateTime.Now.ToString("dd.MM.yyyy"); // 27.05.2025
                for (int i = 0; i < partsCount; i++)
                {
                    string description = $"Часть секрета {i + 1}";
                    string number = $"{remainders[i]} (mod {moduli[i]})";
                    sharesTable.Rows.Add(currentDate, description, number, "");
                }

                MessageBox.Show("Секрет успешно разделён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при разделении секрета: {ex.Message}\n{ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (BigInteger[], BigInteger[]) SplitSecret(BigInteger secret, int partsCount, int minParts)
        {
            try
            {
                // Генерируем попарно взаимно простые модули
                BigInteger[] moduli = GenerateCoprimeNumbers(partsCount, secret);

                // Вычисляем остатки
                BigInteger[] remainders = new BigInteger[partsCount];
                for (int i = 0; i < partsCount; i++)
                {
                    remainders[i] = secret % moduli[i];
                }

                return (remainders, moduli);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка в SplitSecret: {ex.Message}", ex);
            }
        }

        private BigInteger[] GenerateCoprimeNumbers(int count, BigInteger secret)
        {
            try
            {
                BigInteger[] moduli = new BigInteger[count];
                int[] primes = { 17, 19, 23, 29, 31, 37, 41, 43, 47, 53 }; // Список простых чисел
                if (count > primes.Length)
                {
                    throw new Exception("Слишком много частей. Увеличьте список простых чисел.");
                }

                // Выбираем модули меньше секрета
                for (int i = 0; i < count; i++)
                {
                    moduli[i] = primes[i];
                }

                // Проверяем, что произведение модулей больше секрета
                BigInteger product = 1;
                foreach (var m in moduli)
                {
                    product *= m;
                }
                if (product <= secret)
                {
                    throw new Exception("Произведение модулей должно быть больше секрета. Увеличьте количество частей или используйте меньший секрет.");
                }

                return moduli;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка в GenerateCoprimeNumbers: {ex.Message}", ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in sharesTable.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row["Владелец"].ToString()))
                    {
                        MessageBox.Show("Укажите владельца для каждой части секрета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string filePath = Path.Combine(Application.StartupPath, "shares.txt");
                bool fileExists = File.Exists(filePath);

                using (StreamWriter writer = new StreamWriter(filePath, true)) // append = true для дописывания
                {
                    // Если файл создаётся впервые, записываем начальные данные
                    if (!fileExists)
                    {
                        writer.WriteLine("Дата | Описание | Число | Владелец");
                    }

                    // Дописываем новые данные из таблицы
                    foreach (DataRow row in sharesTable.Rows)
                    {
                        writer.WriteLine($"{row["Дата"]} | {row["Описание"]} | {row["Число"]} | {row["Владелец"]}");
                    }
                }

                MessageBox.Show("Таблица успешно сохранена в shares.txt!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении таблицы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click_Click(object sender, EventArgs e)
        {
            try
            {
                int partsCount = restoreTable.Rows.Count;
                if (partsCount == 0)
                {
                    MessageBox.Show("Таблица для восстановления пуста. Добавьте части секрета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BigInteger[] remainders = new BigInteger[partsCount];
                BigInteger[] moduli = new BigInteger[partsCount];

                for (int i = 0; i < partsCount; i++)
                {
                    string number = restoreTable.Rows[i]["Число"].ToString();
                    if (string.IsNullOrWhiteSpace(number))
                    {
                        MessageBox.Show($"Поле 'Число' в строке {i + 1} пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string[] numbers = number.Split(' ');
                    if (numbers.Length != 2 || !BigInteger.TryParse(numbers[0], out remainders[i]) || !BigInteger.TryParse(numbers[1], out moduli[i]) || moduli[i] <= 0)
                    {
                        MessageBox.Show($"Некорректный формат в строке {i + 1}: введите два числа через пробел (остаток модуль).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (remainders[i] < 0 || remainders[i] >= moduli[i])
                    {
                        MessageBox.Show($"Остаток в строке {i + 1} должен быть в диапазоне [0, {moduli[i] - 1}].", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Проверка попарной взаимной простоты модулей
                for (int i = 0; i < partsCount; i++)
                {
                    for (int j = i + 1; j < partsCount; j++)
                    {
                        if (BigInteger.GreatestCommonDivisor(moduli[i], moduli[j]) != 1)
                        {
                            MessageBox.Show($"Модули {moduli[i]} и {moduli[j]} не взаимно просты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                BigInteger result = RestoreSecret(remainders, moduli);
                MessageBox.Show($"Восстановленный секрет: {result}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении секрета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BigInteger RestoreSecret(BigInteger[] remainders, BigInteger[] moduli)
        {
            try
            {
                int n = remainders.Length;
                BigInteger product = 1;
                for (int i = 0; i < n; i++)
                {
                    product *= moduli[i];
                }

                BigInteger result = 0;
                for (int i = 0; i < n; i++)
                {
                    BigInteger p = product / moduli[i];
                    BigInteger inverse = ModInverse(p, moduli[i]);
                    result += remainders[i] * p * inverse;
                }

                return result % product;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка в RestoreSecret: {ex.Message}", ex);
            }
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }
    }
}
