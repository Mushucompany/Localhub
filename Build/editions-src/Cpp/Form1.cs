using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubCppApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Program.EditionTitle;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("▶ Запуск: C++ Edition\n\n" + textBoxCode.Text.Substring(0, Math.Min(80, textBoxCode.Text.Length)) + "...",
                Program.EditionTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("💾 Код сохранён (локально)", Program.EditionTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string msg = textBoxMessage.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("Заполните все поля", Program.EditionTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"✅ {name}, ваше сообщение отправлено разработчикам C++ Edition на {Program.EditionEmail}",
                Program.EditionTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string provider)
                MessageBox.Show($"🔐 Вход через {provider} (C++ Edition)", Program.EditionTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
        private Label labelLogo;
        private Label labelInfo;

        private void InitializeComponent()
        {
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
            this.labelLogo = new Label();
            this.labelInfo = new Label();

            this.SuspendLayout();

            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(10, 15, 20);
            this.ClientSize = new Size(900, 650);
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = Color.FromArgb(232, 232, 240);
            this.MinimumSize = new Size(700, 450);
            this.Text = Program.EditionTitle;

            // logo
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.labelLogo.ForeColor = Color.FromArgb(0, 89, 156);
            this.labelLogo.Location = new Point(20, 16);
            this.labelLogo.Text = "LocalHub";

            // info
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = Color.FromArgb(136, 136, 160);
            this.labelInfo.Location = new Point(20, 54);
            this.labelInfo.Text = Program.EditionTitle + " — Support: " + Program.EditionEmail;
            this.labelInfo.Size = new Size(600, 20);

            // code editor
            this.textBoxCode.AcceptsTab = true;
            this.textBoxCode.BackColor = Color.FromArgb(8, 12, 16);
            this.textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxCode.Font = new Font("Consolas", 10F);
            this.textBoxCode.ForeColor = Color.FromArgb(184, 200, 216);
            this.textBoxCode.Location = new Point(20, 84);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.ScrollBars = ScrollBars.Vertical;
            this.textBoxCode.Size = new Size(860, 220);
            this.textBoxCode.Text = "#include <iostream>\n\nint main() {\n    std::cout << \"Hello from C++ Edition!\" << std::endl;\n    return 0;\n}";

            // run
            this.buttonRun.BackColor = Color.FromArgb(0, 89, 156);
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = FlatStyle.Flat;
            this.buttonRun.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonRun.ForeColor = Color.White;
            this.buttonRun.Location = new Point(20, 312);
            this.buttonRun.Size = new Size(140, 38);
            this.buttonRun.Text = "▶ Компилировать (C++)";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new EventHandler(this.ButtonRun_Click);

            // save
            this.buttonSave.BackColor = Color.Transparent;
            this.buttonSave.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 58);
            this.buttonSave.FlatStyle = FlatStyle.Flat;
            this.buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonSave.ForeColor = Color.FromArgb(232, 232, 240);
            this.buttonSave.Location = new Point(170, 312);
            this.buttonSave.Size = new Size(120, 38);
            this.buttonSave.Text = "💾 Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            // name
            this.textBoxName.BackColor = Color.FromArgb(14, 18, 23);
            this.textBoxName.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxName.Font = new Font("Segoe UI", 10F);
            this.textBoxName.ForeColor = Color.FromArgb(232, 232, 240);
            this.textBoxName.Location = new Point(20, 370);
            this.textBoxName.Size = new Size(400, 30);
            this.textBoxName.PlaceholderText = "Ваше имя";

            // email
            this.textBoxEmail.BackColor = Color.FromArgb(14, 18, 23);
            this.textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new Font("Segoe UI", 10F);
            this.textBoxEmail.ForeColor = Color.FromArgb(232, 232, 240);
            this.textBoxEmail.Location = new Point(20, 410);
            this.textBoxEmail.Size = new Size(400, 30);
            this.textBoxEmail.PlaceholderText = "Ваш Email";

            // message
            this.textBoxMessage.BackColor = Color.FromArgb(14, 18, 23);
            this.textBoxMessage.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxMessage.Font = new Font("Segoe UI", 10F);
            this.textBoxMessage.ForeColor = Color.FromArgb(232, 232, 240);
            this.textBoxMessage.Location = new Point(20, 450);
            this.textBoxMessage.Size = new Size(400, 30);
            this.textBoxMessage.PlaceholderText = "Сообщение";

            // register/send
            this.buttonRegister.BackColor = Color.FromArgb(0, 89, 156);
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = FlatStyle.Flat;
            this.buttonRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonRegister.ForeColor = Color.White;
            this.buttonRegister.Location = new Point(20, 492);
            this.buttonRegister.Size = new Size(220, 36);
            this.buttonRegister.Text = "✉ Отправить разработчику";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new EventHandler(this.ButtonRegister_Click);

            // social login buttons
            this.buttonGitHub.BackColor = Color.FromArgb(22, 27, 32);
            this.buttonGitHub.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 58);
            this.buttonGitHub.FlatStyle = FlatStyle.Flat;
            this.buttonGitHub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonGitHub.Location = new Point(20, 550);
            this.buttonGitHub.Size = new Size(140, 32);
            this.buttonGitHub.Text = "⬡ GitHub";
            this.buttonGitHub.Tag = "GitHub";
            this.buttonGitHub.Click += new EventHandler(this.SocialLogin_Click);

            this.buttonVK.BackColor = Color.FromArgb(22, 27, 32);
            this.buttonVK.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 58);
            this.buttonVK.FlatStyle = FlatStyle.Flat;
            this.buttonVK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonVK.Location = new Point(170, 550);
            this.buttonVK.Size = new Size(100, 32);
            this.buttonVK.Text = "Ⓥ VK";
            this.buttonVK.Tag = "VK";
            this.buttonVK.Click += new EventHandler(this.SocialLogin_Click);

            this.buttonMicrosoft.BackColor = Color.FromArgb(22, 27, 32);
            this.buttonMicrosoft.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 58);
            this.buttonMicrosoft.FlatStyle = FlatStyle.Flat;
            this.buttonMicrosoft.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonMicrosoft.Location = new Point(280, 550);
            this.buttonMicrosoft.Size = new Size(120, 32);
            this.buttonMicrosoft.Text = "⊞ Microsoft";
            this.buttonMicrosoft.Tag = "Microsoft";
            this.buttonMicrosoft.Click += new EventHandler(this.SocialLogin_Click);

            this.buttonGoogle.BackColor = Color.FromArgb(22, 27, 32);
            this.buttonGoogle.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 58);
            this.buttonGoogle.FlatStyle = FlatStyle.Flat;
            this.buttonGoogle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonGoogle.Location = new Point(410, 550);
            this.buttonGoogle.Size = new Size(100, 32);
            this.buttonGoogle.Text = "Ⓖ Google";
            this.buttonGoogle.Tag = "Google";
            this.buttonGoogle.Click += new EventHandler(this.SocialLogin_Click);

            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonGitHub);
            this.Controls.Add(this.buttonVK);
            this.Controls.Add(this.buttonMicrosoft);
            this.Controls.Add(this.buttonGoogle);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}