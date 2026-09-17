using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubCApp
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
            var accent = Color.FromArgb(88, 108, 128);
            var darkBg = Color.FromArgb(8, 10, 12);
            var textColor = Color.FromArgb(220, 220, 220);

            this.Text = "LocalHub — C Edition";
            this.Size = new Size(720, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = darkBg;
            this.ForeColor = textColor;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            labelLogo = new Label
            {
                Text = "LocalHub",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(20, 15),
                Size = new Size(300, 40),
                BackColor = Color.Transparent
            };

            labelInfo = new Label
            {
                Text = "LocalHub — C Edition — Support: c-edition@localhub.dev",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(140, 150, 160),
                Location = new Point(20, 55),
                Size = new Size(680, 18),
                BackColor = Color.Transparent
            };

            textBoxCode = new TextBox
            {
                Font = new Font("Consolas", 10F),
                Multiline = true,
                Location = new Point(20, 85),
                Size = new Size(420, 260),
                BackColor = Color.FromArgb(18, 22, 26),
                ForeColor = Color.FromArgb(200, 220, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Text = "#include <stdio.h>\n\nint main() {\n    printf(\"Hello, LocalHub!\\n\");\n    return 0;\n}",
                ScrollBars = ScrollBars.Both,
                WordWrap = false
            };

            buttonRun = new Button
            {
                Text = "\u25B6 Компилировать (C)",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(450, 85),
                Size = new Size(240, 36),
                BackColor = accent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonRun.FlatAppearance.BorderSize = 0;
            buttonRun.Click += ButtonRun_Click;

            buttonSave = new Button
            {
                Text = "\uD83D\uDCBE Сохранить",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(450, 130),
                Size = new Size(240, 36),
                BackColor = Color.FromArgb(32, 36, 42),
                ForeColor = textColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Click += ButtonSave_Click;

            var socialY = 185;
            var socialSize = new Size(54, 54);
            var socialGap = 12;

            buttonGitHub = new Button
            {
                Text = "GitHub",
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(450, socialY),
                Size = socialSize,
                BackColor = Color.FromArgb(36, 40, 46),
                ForeColor = Color.FromArgb(200, 200, 200),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonGitHub.FlatAppearance.BorderSize = 0;
            buttonGitHub.Click += SocialLogin_Click;

            buttonVK = new Button
            {
                Text = "VK",
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(450 + socialSize.Width + socialGap, socialY),
                Size = socialSize,
                BackColor = Color.FromArgb(36, 40, 46),
                ForeColor = Color.FromArgb(200, 200, 200),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonVK.FlatAppearance.BorderSize = 0;
            buttonVK.Click += SocialLogin_Click;

            buttonMicrosoft = new Button
            {
                Text = "MS",
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(450 + (socialSize.Width + socialGap) * 2, socialY),
                Size = socialSize,
                BackColor = Color.FromArgb(36, 40, 46),
                ForeColor = Color.FromArgb(200, 200, 200),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonMicrosoft.FlatAppearance.BorderSize = 0;
            buttonMicrosoft.Click += SocialLogin_Click;

            buttonGoogle = new Button
            {
                Text = "Google",
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(450 + (socialSize.Width + socialGap) * 3, socialY),
                Size = socialSize,
                BackColor = Color.FromArgb(36, 40, 46),
                ForeColor = Color.FromArgb(200, 200, 200),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonGoogle.FlatAppearance.BorderSize = 0;
            buttonGoogle.Click += SocialLogin_Click;

            var contactY = 260;
            textBoxName = new TextBox
            {
                Font = new Font("Segoe UI", 9F),
                Location = new Point(450, contactY),
                Size = new Size(240, 24),
                BackColor = Color.FromArgb(18, 22, 26),
                ForeColor = textColor,
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxName.Enter += (s, e) => { if (textBoxName.Text == "Ваше имя") textBoxName.Text = ""; };
            textBoxName.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxName.Text)) textBoxName.Text = "Ваше имя"; };
            textBoxName.Text = "Ваше имя";

            textBoxEmail = new TextBox
            {
                Font = new Font("Segoe UI", 9F),
                Location = new Point(450, contactY + 30),
                Size = new Size(240, 24),
                BackColor = Color.FromArgb(18, 22, 26),
                ForeColor = textColor,
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxEmail.Enter += (s, e) => { if (textBoxEmail.Text == "Ваш Email") textBoxEmail.Text = ""; };
            textBoxEmail.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) textBoxEmail.Text = "Ваш Email"; };
            textBoxEmail.Text = "Ваш Email";

            textBoxMessage = new TextBox
            {
                Font = new Font("Segoe UI", 9F),
                Multiline = true,
                Location = new Point(450, contactY + 60),
                Size = new Size(240, 60),
                BackColor = Color.FromArgb(18, 22, 26),
                ForeColor = textColor,
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxMessage.Enter += (s, e) => { if (textBoxMessage.Text == "Сообщение") textBoxMessage.Text = ""; };
            textBoxMessage.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(textBoxMessage.Text)) textBoxMessage.Text = "Сообщение"; };
            textBoxMessage.Text = "Сообщение";

            buttonRegister = new Button
            {
                Text = "\u2709 Отправить разработчику",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(450, contactY + 130),
                Size = new Size(240, 36),
                BackColor = Color.FromArgb(32, 36, 42),
                ForeColor = textColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.Click += ButtonRegister_Click;

            this.Controls.AddRange(new Control[]
            {
                labelLogo, labelInfo, textBoxCode,
                buttonRun, buttonSave,
                buttonGitHub, buttonVK, buttonMicrosoft, buttonGoogle,
                textBoxName, textBoxEmail, textBoxMessage,
                buttonRegister
            });
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компиляция C-кода запущена.\nРезультат появится в консоли.", "LocalHub C Edition",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog
            {
                Filter = "C Source Files (*.c)|*.c|All Files (*.*)|*.*",
                DefaultExt = "c",
                FileName = "program.c"
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(dlg.FileName, textBoxCode.Text);
                    MessageBox.Show("Файл сохранён.", "LocalHub C Edition",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text == "Ваше имя" ? "" : textBoxName.Text;
            var email = textBoxEmail.Text == "Ваш Email" ? "" : textBoxEmail.Text;
            var msg = textBoxMessage.Text == "Сообщение" ? "" : textBoxMessage.Text;

            MessageBox.Show(
                $"Имя: {name}\nEmail: {email}\nСообщение: {msg}",
                "Отправка разработчику", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show($"Вход через {btn?.Text ?? "соцсеть"}.\nФункция в разработке.", "LocalHub C Edition",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}