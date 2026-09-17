using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubHubApp
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

        private Color accentColor = Color.FromArgb(154, 123, 216);
        private Color darkBackground = Color.FromArgb(13, 13, 18);

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelLogo = new Label();
            this.labelInfo = new Label();
            this.textBoxCode = new TextBox();
            this.buttonRun = new Button();
            this.buttonSave = new Button();
            this.textBoxName = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxMessage = new TextBox();
            this.buttonRegister = new Button();
            this.buttonGitHub = new Button();
            this.buttonVK = new Button();
            this.buttonMicrosoft = new Button();
            this.buttonGoogle = new Button();

            this.SuspendLayout();

            // labelLogo
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.labelLogo.ForeColor = accentColor;
            this.labelLogo.Location = new Point(30, 25);
            this.labelLogo.Size = new Size(200, 37);
            this.labelLogo.Text = "LocalHub";

            // labelInfo
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new Font("Segoe UI", 9F);
            this.labelInfo.ForeColor = Color.FromArgb(180, 180, 190);
            this.labelInfo.Location = new Point(30, 65);
            this.labelInfo.Size = new Size(420, 15);
            this.labelInfo.Text = "LocalHub — Multi-Language Hub — Support: hub@localhub.dev";

            // textBoxCode
            this.textBoxCode.Font = new Font("Consolas", 10F);
            this.textBoxCode.BackColor = Color.FromArgb(20, 20, 30);
            this.textBoxCode.ForeColor = Color.FromArgb(210, 210, 220);
            this.textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxCode.Location = new Point(30, 100);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Size = new Size(500, 160);
            this.textBoxCode.ScrollBars = ScrollBars.Vertical;
            this.textBoxCode.Text = "// LocalHub example: C# Hub Code\r\nusing LocalHub;\r\n\r\nvar hub = new Hub();\r\nhub.Connect(\"ws://localhost:9090\");\r\nvar result = hub.Execute(new Request { Payload = \"Hello from Hub!\" });\r\nConsole.WriteLine(result);";

            // buttonRun
            this.buttonRun.Font = new Font("Segoe UI", 10F);
            this.buttonRun.BackColor = accentColor;
            this.buttonRun.FlatStyle = FlatStyle.Flat;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.ForeColor = Color.White;
            this.buttonRun.Location = new Point(30, 275);
            this.buttonRun.Size = new Size(160, 32);
            this.buttonRun.Text = "\u25B6 Запустить (Hub)";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new EventHandler(this.ButtonRun_Click);

            // buttonSave
            this.buttonSave.Font = new Font("Segoe UI", 10F);
            this.buttonSave.BackColor = Color.FromArgb(50, 50, 65);
            this.buttonSave.FlatStyle = FlatStyle.Flat;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.Location = new Point(205, 275);
            this.buttonSave.Size = new Size(120, 32);
            this.buttonSave.Text = "\uD83D\uDCBE Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            // textBoxName
            this.textBoxName.Font = new Font("Segoe UI", 10F);
            this.textBoxName.BackColor = Color.FromArgb(20, 20, 30);
            this.textBoxName.ForeColor = Color.FromArgb(200, 200, 210);
            this.textBoxName.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxName.Location = new Point(30, 330);
            this.textBoxName.Size = new Size(240, 25);
            this.textBoxName.Text = "Ваше имя";

            // textBoxEmail
            this.textBoxEmail.Font = new Font("Segoe UI", 10F);
            this.textBoxEmail.BackColor = Color.FromArgb(20, 20, 30);
            this.textBoxEmail.ForeColor = Color.FromArgb(200, 200, 210);
            this.textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new Point(290, 330);
            this.textBoxEmail.Size = new Size(240, 25);
            this.textBoxEmail.Text = "Ваш Email";

            // textBoxMessage
            this.textBoxMessage.Font = new Font("Segoe UI", 10F);
            this.textBoxMessage.BackColor = Color.FromArgb(20, 20, 30);
            this.textBoxMessage.ForeColor = Color.FromArgb(200, 200, 210);
            this.textBoxMessage.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxMessage.Location = new Point(30, 365);
            this.textBoxMessage.Size = new Size(500, 25);
            this.textBoxMessage.Text = "Сообщение";

            // buttonRegister
            this.buttonRegister.Font = new Font("Segoe UI", 10F);
            this.buttonRegister.BackColor = accentColor;
            this.buttonRegister.FlatStyle = FlatStyle.Flat;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.ForeColor = Color.White;
            this.buttonRegister.Location = new Point(30, 405);
            this.buttonRegister.Size = new Size(200, 32);
            this.buttonRegister.Text = "\u2709 Отправить разработчику";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new EventHandler(this.ButtonRegister_Click);

            // buttonGitHub
            this.buttonGitHub.Font = new Font("Segoe UI", 10F);
            this.buttonGitHub.BackColor = Color.FromArgb(36, 41, 46);
            this.buttonGitHub.FlatStyle = FlatStyle.Flat;
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.ForeColor = Color.White;
            this.buttonGitHub.Location = new Point(30, 460);
            this.buttonGitHub.Size = new Size(110, 32);
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new EventHandler(this.SocialLogin_Click);

            // buttonVK
            this.buttonVK.Font = new Font("Segoe UI", 10F);
            this.buttonVK.BackColor = Color.FromArgb(69, 128, 189);
            this.buttonVK.FlatStyle = FlatStyle.Flat;
            this.buttonVK.FlatAppearance.BorderSize = 0;
            this.buttonVK.ForeColor = Color.White;
            this.buttonVK.Location = new Point(155, 460);
            this.buttonVK.Size = new Size(80, 32);
            this.buttonVK.Text = "VK";
            this.buttonVK.UseVisualStyleBackColor = false;
            this.buttonVK.Click += new EventHandler(this.SocialLogin_Click);

            // buttonMicrosoft
            this.buttonMicrosoft.Font = new Font("Segoe UI", 10F);
            this.buttonMicrosoft.BackColor = Color.FromArgb(80, 80, 90);
            this.buttonMicrosoft.FlatStyle = FlatStyle.Flat;
            this.buttonMicrosoft.FlatAppearance.BorderSize = 0;
            this.buttonMicrosoft.ForeColor = Color.White;
            this.buttonMicrosoft.Location = new Point(250, 460);
            this.buttonMicrosoft.Size = new Size(110, 32);
            this.buttonMicrosoft.Text = "Microsoft";
            this.buttonMicrosoft.UseVisualStyleBackColor = false;
            this.buttonMicrosoft.Click += new EventHandler(this.SocialLogin_Click);

            // buttonGoogle
            this.buttonGoogle.Font = new Font("Segoe UI", 10F);
            this.buttonGoogle.BackColor = Color.FromArgb(66, 133, 244);
            this.buttonGoogle.FlatStyle = FlatStyle.Flat;
            this.buttonGoogle.FlatAppearance.BorderSize = 0;
            this.buttonGoogle.ForeColor = Color.White;
            this.buttonGoogle.Location = new Point(375, 460);
            this.buttonGoogle.Size = new Size(100, 32);
            this.buttonGoogle.Text = "Google";
            this.buttonGoogle.UseVisualStyleBackColor = false;
            this.buttonGoogle.Click += new EventHandler(this.SocialLogin_Click);

            // Form1
            this.BackColor = darkBackground;
            this.ClientSize = new Size(570, 520);
            this.Controls.AddRange(new Control[] {
                labelLogo, labelInfo, textBoxCode,
                buttonRun, buttonSave,
                textBoxName, textBoxEmail, textBoxMessage, buttonRegister,
                buttonGitHub, buttonVK, buttonMicrosoft, buttonGoogle
            });
            this.Font = new Font("Segoe UI", 9F);
            this.ForeColor = Color.FromArgb(200, 200, 210);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "LocalHub \u2014 Multi-Language Hub";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Запуск Hub-кода...\n\n" + textBoxCode.Text,
                "LocalHub — Run",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Код сохранён.",
                "LocalHub — Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string message = textBoxMessage.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show(
                    "Пожалуйста, укажите имя и email.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Спасибо, {name}!\n\nВаше сообщение отправлено разработчику.\nEmail: {email}\nСообщение: {message}",
                "LocalHub — Отправлено",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string network = btn?.Text ?? "Неизвестная сеть";
            MessageBox.Show(
                $"Вход через {network}...",
                "LocalHub — Social Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}