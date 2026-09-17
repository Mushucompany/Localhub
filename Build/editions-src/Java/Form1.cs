using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubJavaApp
{
    public partial class Form1 : Form
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

        private Color accentColor = Color.FromArgb(232, 111, 0);
        private Color darkBg = Color.FromArgb(18, 10, 0);
        private Color darkSurface = Color.FromArgb(30, 18, 5);
        private Color textLight = Color.FromArgb(240, 230, 220);
        private Color textDim = Color.FromArgb(180, 160, 140);

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "LocalHub — Java Edition";
            this.Size = new Size(820, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = darkBg;
            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            this.ForeColor = textLight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // labelLogo
            labelLogo = new Label();
            labelLogo.Text = "LocalHub";
            labelLogo.Font = new Font("Segoe UI", 20f, FontStyle.Bold);
            labelLogo.ForeColor = accentColor;
            labelLogo.BackColor = Color.Transparent;
            labelLogo.AutoSize = true;
            labelLogo.Location = new Point(30, 20);

            // labelInfo
            labelInfo = new Label();
            labelInfo.Text = "LocalHub — Java Edition — Support: java-edition@localhub.dev";
            labelInfo.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            labelInfo.ForeColor = textDim;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(30, 58);

            // textBoxCode
            textBoxCode = new TextBox();
            textBoxCode.Multiline = true;
            textBoxCode.Font = new Font("Consolas", 10f, FontStyle.Regular);
            textBoxCode.BackColor = darkSurface;
            textBoxCode.ForeColor = textLight;
            textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxCode.Size = new Size(520, 260);
            textBoxCode.Location = new Point(30, 90);
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            textBoxCode.Text = @"public class HelloWorld {
    public static void main(String[] args) {
        System.out.println(""Hello, LocalHub!"");
    }
}";

            // buttonRun
            buttonRun = new Button();
            buttonRun.Text = "▶ Компилировать (Java)";
            buttonRun.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            buttonRun.ForeColor = Color.White;
            buttonRun.BackColor = accentColor;
            buttonRun.FlatStyle = FlatStyle.Flat;
            buttonRun.FlatAppearance.BorderSize = 0;
            buttonRun.Size = new Size(200, 36);
            buttonRun.Location = new Point(30, 365);
            buttonRun.Cursor = Cursors.Hand;
            buttonRun.Click += ButtonRun_Click;

            // buttonSave
            buttonSave = new Button();
            buttonSave.Text = "💾 Сохранить";
            buttonSave.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            buttonSave.ForeColor = textLight;
            buttonSave.BackColor = darkSurface;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 1;
            buttonSave.FlatAppearance.BorderColor = accentColor;
            buttonSave.Size = new Size(130, 36);
            buttonSave.Location = new Point(245, 365);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Click += ButtonSave_Click;

            // textBoxName
            textBoxName = new TextBox();
            textBoxName.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            textBoxName.BackColor = darkSurface;
            textBoxName.ForeColor = textLight;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Size = new Size(220, 28);
            textBoxName.Location = new Point(580, 90);
            textBoxName.Text = "Ваше имя";
            textBoxName.GotFocus += (s, e) => { if (textBoxName.Text == "Ваше имя") textBoxName.Text = ""; };
            textBoxName.LostFocus += (s, e) => { if (textBoxName.Text.Trim() == "") textBoxName.Text = "Ваше имя"; };

            // textBoxEmail
            textBoxEmail = new TextBox();
            textBoxEmail.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            textBoxEmail.BackColor = darkSurface;
            textBoxEmail.ForeColor = textLight;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Size = new Size(220, 28);
            textBoxEmail.Location = new Point(580, 130);
            textBoxEmail.Text = "Ваш Email";
            textBoxEmail.GotFocus += (s, e) => { if (textBoxEmail.Text == "Ваш Email") textBoxEmail.Text = ""; };
            textBoxEmail.LostFocus += (s, e) => { if (textBoxEmail.Text.Trim() == "") textBoxEmail.Text = "Ваш Email"; };

            // textBoxMessage
            textBoxMessage = new TextBox();
            textBoxMessage.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            textBoxMessage.BackColor = darkSurface;
            textBoxMessage.ForeColor = textLight;
            textBoxMessage.BorderStyle = BorderStyle.FixedSingle;
            textBoxMessage.Size = new Size(220, 120);
            textBoxMessage.Location = new Point(580, 170);
            textBoxMessage.Multiline = true;
            textBoxMessage.Text = "Сообщение";
            textBoxMessage.GotFocus += (s, e) => { if (textBoxMessage.Text == "Сообщение") textBoxMessage.Text = ""; };
            textBoxMessage.LostFocus += (s, e) => { if (textBoxMessage.Text.Trim() == "") textBoxMessage.Text = "Сообщение"; };

            // buttonRegister
            buttonRegister = new Button();
            buttonRegister.Text = "✉ Отправить разработчику";
            buttonRegister.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.BackColor = accentColor;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.Size = new Size(220, 36);
            buttonRegister.Location = new Point(580, 305);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Click += ButtonRegister_Click;

            // buttonGitHub
            buttonGitHub = new Button();
            buttonGitHub.Text = "GitHub";
            buttonGitHub.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            buttonGitHub.ForeColor = textLight;
            buttonGitHub.BackColor = darkSurface;
            buttonGitHub.FlatStyle = FlatStyle.Flat;
            buttonGitHub.FlatAppearance.BorderSize = 1;
            buttonGitHub.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            buttonGitHub.Size = new Size(100, 32);
            buttonGitHub.Location = new Point(580, 355);
            buttonGitHub.Cursor = Cursors.Hand;
            buttonGitHub.Click += SocialLogin_Click;

            // buttonVK
            buttonVK = new Button();
            buttonVK.Text = "VK";
            buttonVK.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            buttonVK.ForeColor = textLight;
            buttonVK.BackColor = darkSurface;
            buttonVK.FlatStyle = FlatStyle.Flat;
            buttonVK.FlatAppearance.BorderSize = 1;
            buttonVK.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            buttonVK.Size = new Size(100, 32);
            buttonVK.Location = new Point(690, 355);
            buttonVK.Cursor = Cursors.Hand;
            buttonVK.Click += SocialLogin_Click;

            // buttonMicrosoft
            buttonMicrosoft = new Button();
            buttonMicrosoft.Text = "Microsoft";
            buttonMicrosoft.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            buttonMicrosoft.ForeColor = textLight;
            buttonMicrosoft.BackColor = darkSurface;
            buttonMicrosoft.FlatStyle = FlatStyle.Flat;
            buttonMicrosoft.FlatAppearance.BorderSize = 1;
            buttonMicrosoft.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            buttonMicrosoft.Size = new Size(100, 32);
            buttonMicrosoft.Location = new Point(580, 395);
            buttonMicrosoft.Cursor = Cursors.Hand;
            buttonMicrosoft.Click += SocialLogin_Click;

            // buttonGoogle
            buttonGoogle = new Button();
            buttonGoogle.Text = "Google";
            buttonGoogle.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            buttonGoogle.ForeColor = textLight;
            buttonGoogle.BackColor = darkSurface;
            buttonGoogle.FlatStyle = FlatStyle.Flat;
            buttonGoogle.FlatAppearance.BorderSize = 1;
            buttonGoogle.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            buttonGoogle.Size = new Size(100, 32);
            buttonGoogle.Location = new Point(690, 395);
            buttonGoogle.Cursor = Cursors.Hand;
            buttonGoogle.Click += SocialLogin_Click;

            // Add controls
            this.Controls.Add(labelLogo);
            this.Controls.Add(labelInfo);
            this.Controls.Add(textBoxCode);
            this.Controls.Add(buttonRun);
            this.Controls.Add(buttonSave);
            this.Controls.Add(textBoxName);
            this.Controls.Add(textBoxEmail);
            this.Controls.Add(textBoxMessage);
            this.Controls.Add(buttonRegister);
            this.Controls.Add(buttonGitHub);
            this.Controls.Add(buttonVK);
            this.Controls.Add(buttonMicrosoft);
            this.Controls.Add(buttonGoogle);
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компиляция Java-кода...", "LocalHub — Java Edition", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Код сохранён.", "LocalHub — Java Edition", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text == "Ваше имя" ? "" : textBoxName.Text;
            string email = textBoxEmail.Text == "Ваш Email" ? "" : textBoxEmail.Text;
            string message = textBoxMessage.Text == "Сообщение" ? "" : textBoxMessage.Text;

            MessageBox.Show(
                $"Имя: {name}\nEmail: {email}\nСообщение: {message}",
                "Отправка разработчику",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                MessageBox.Show($"Вход через {btn.Text}...", "LocalHub — Java Edition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}