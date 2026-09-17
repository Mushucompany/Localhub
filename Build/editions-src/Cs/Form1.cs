using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubCsApp
{
    partial class Form1 : Form
    {
        private Label labelLogo;
        private Label labelInfo;
        private TextBox textBoxCode;
        private Button buttonRun;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxMessage;
        private Button buttonRegister;
        private Button buttonGitHub;
        private Button buttonVK;
        private Button buttonMicrosoft;
        private Button buttonGoogle;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "LocalHub — C# Edition";
            this.Size = new Size(740, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(13, 9, 18);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10f);

            Color accent = Color.FromArgb(104, 33, 122);
            Color accentLight = Color.FromArgb(140, 60, 160);

            // labelLogo
            this.labelLogo = new Label();
            this.labelLogo.Text = "LocalHub";
            this.labelLogo.Font = new Font("Segoe UI", 20f, FontStyle.Bold);
            this.labelLogo.ForeColor = accent;
            this.labelLogo.BackColor = Color.Transparent;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new Point(20, 18);

            // labelInfo
            this.labelInfo = new Label();
            this.labelInfo.Text = "LocalHub — C# Edition — Support: cs-edition@localhub.dev";
            this.labelInfo.Font = new Font("Segoe UI", 9f);
            this.labelInfo.ForeColor = Color.FromArgb(160, 150, 170);
            this.labelInfo.BackColor = Color.Transparent;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new Point(20, 52);

            // textBoxCode
            this.textBoxCode = new TextBox();
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Font = new Font("Consolas", 10f);
            this.textBoxCode.BackColor = Color.FromArgb(20, 14, 28);
            this.textBoxCode.ForeColor = Color.FromArgb(230, 220, 240);
            this.textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxCode.ScrollBars = ScrollBars.Vertical;
            this.textBoxCode.Size = new Size(690, 180);
            this.textBoxCode.Location = new Point(20, 80);
            this.textBoxCode.Text = "using System;\r\n\r\nclass Program\r\n{\r\n    static void Main()\r\n    {\r\n        Console.WriteLine(\"Hello, LocalHub!\");\r\n    }\r\n}";

            // buttonRun
            this.buttonRun = new Button();
            this.buttonRun.Text = "▶ Запустить (C#)";
            this.buttonRun.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.buttonRun.BackColor = accent;
            this.buttonRun.ForeColor = Color.White;
            this.buttonRun.FlatStyle = FlatStyle.Flat;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.Size = new Size(200, 36);
            this.buttonRun.Location = new Point(20, 270);
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new EventHandler(ButtonRun_Click);

            // buttonSave
            this.buttonSave = new Button();
            this.buttonSave.Text = "💾 Сохранить";
            this.buttonSave.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.buttonSave.BackColor = Color.FromArgb(50, 40, 60);
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.FlatStyle = FlatStyle.Flat;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.Size = new Size(160, 36);
            this.buttonSave.Location = new Point(230, 270);
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(ButtonSave_Click);

            // separator line (label used as horizontal rule)
            Label sep = new Label();
            sep.Text = "──────────────────────────────────────────────────────────";
            sep.ForeColor = Color.FromArgb(60, 50, 70);
            sep.BackColor = Color.Transparent;
            sep.AutoSize = true;
            sep.Location = new Point(20, 320);

            // textBoxName
            this.textBoxName = new TextBox();
            this.textBoxName.Font = new Font("Segoe UI", 10f);
            this.textBoxName.BackColor = Color.FromArgb(20, 14, 28);
            this.textBoxName.ForeColor = Color.White;
            this.textBoxName.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxName.Size = new Size(220, 28);
            this.textBoxName.Location = new Point(20, 350);
            this.textBoxName.Text = "Ваше имя";
            this.textBoxName.GotFocus += (s, e) => { if (textBoxName.Text == "Ваше имя") textBoxName.Text = ""; };
            this.textBoxName.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxName.Text)) textBoxName.Text = "Ваше имя"; };

            // textBoxEmail
            this.textBoxEmail = new TextBox();
            this.textBoxEmail.Font = new Font("Segoe UI", 10f);
            this.textBoxEmail.BackColor = Color.FromArgb(20, 14, 28);
            this.textBoxEmail.ForeColor = Color.White;
            this.textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxEmail.Size = new Size(220, 28);
            this.textBoxEmail.Location = new Point(250, 350);
            this.textBoxEmail.Text = "Ваш Email";
            this.textBoxEmail.GotFocus += (s, e) => { if (textBoxEmail.Text == "Ваш Email") textBoxEmail.Text = ""; };
            this.textBoxEmail.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) textBoxEmail.Text = "Ваш Email"; };

            // textBoxMessage
            this.textBoxMessage = new TextBox();
            this.textBoxMessage.Font = new Font("Segoe UI", 10f);
            this.textBoxMessage.BackColor = Color.FromArgb(20, 14, 28);
            this.textBoxMessage.ForeColor = Color.White;
            this.textBoxMessage.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxMessage.Size = new Size(450, 60);
            this.textBoxMessage.Location = new Point(20, 390);
            this.textBoxMessage.Text = "Сообщение";
            this.textBoxMessage.GotFocus += (s, e) => { if (textBoxMessage.Text == "Сообщение") textBoxMessage.Text = ""; };
            this.textBoxMessage.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxMessage.Text)) textBoxMessage.Text = "Сообщение"; };

            // buttonRegister
            this.buttonRegister = new Button();
            this.buttonRegister.Text = "✉ Отправить разработчику";
            this.buttonRegister.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.buttonRegister.BackColor = accent;
            this.buttonRegister.ForeColor = Color.White;
            this.buttonRegister.FlatStyle = FlatStyle.Flat;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.Size = new Size(240, 36);
            this.buttonRegister.Location = new Point(20, 460);
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new EventHandler(ButtonRegister_Click);

            // Social login buttons
            int socialY = 460;
            int socialX = 290;

            this.buttonGitHub = CreateSocialButton("GitHub", socialX, socialY);
            this.buttonGitHub.Click += new EventHandler(SocialLogin_Click);

            this.buttonVK = CreateSocialButton("VK", socialX + 110, socialY);
            this.buttonVK.Click += new EventHandler(SocialLogin_Click);

            this.buttonMicrosoft = CreateSocialButton("Microsoft", socialX + 220, socialY);
            this.buttonMicrosoft.Click += new EventHandler(SocialLogin_Click);

            this.buttonGoogle = CreateSocialButton("Google", socialX + 330, socialY);
            this.buttonGoogle.Click += new EventHandler(SocialLogin_Click);

            // Add all controls
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(sep);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonGitHub);
            this.Controls.Add(this.buttonVK);
            this.Controls.Add(this.buttonMicrosoft);
            this.Controls.Add(this.buttonGoogle);
        }

        private Button CreateSocialButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(40, 30, 50);
            btn.ForeColor = Color.FromArgb(200, 190, 210);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(80, 60, 100);
            btn.Size = new Size(100, 32);
            btn.Location = new Point(x, y);
            btn.UseVisualStyleBackColor = false;
            btn.Tag = text;
            return btn;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Компиляция и запуск кода на C# — симуляция.\n" +
                "В продакшене здесь будет вызов Roslyn Scripting API или локального компилятора.",
                "▶ Запуск",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "C# Source Files|*.cs|All Files|*.*";
            sfd.FileName = "Program.cs";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, textBoxCode.Text);
                MessageBox.Show("Файл сохранён.", "💾 Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text == "Ваше имя" ? "" : textBoxName.Text;
            string email = textBoxEmail.Text == "Ваш Email" ? "" : textBoxEmail.Text;
            string message = textBoxMessage.Text == "Сообщение" ? "" : textBoxMessage.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Пожалуйста, укажите имя и Email.", "✉ Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Спасибо, {name}!\nEmail: {email}\n\nСообщение отправлено разработчику LocalHub.",
                "✉ Отправлено",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string provider = btn?.Tag?.ToString() ?? "Неизвестный";
            MessageBox.Show(
                $"Вход через {provider}.\nВ продакшене здесь будет OAuth2-авторизация.",
                "Вход",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}