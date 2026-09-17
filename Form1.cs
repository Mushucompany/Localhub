using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubApp
{
    public partial class Form1 : Form
    {
        private string currentEdition = Program.EditionKey;

        public Form1()
        {
            InitializeComponent();
            this.Text = Program.EditionTitle;
            SetupPlaceholders();
            UpdateEditor(currentEdition);
        }

        private void SetupPlaceholders()
        {
            // Инициализация placeholder-текста для полей регистрации
            SetPlaceholder(textBoxRegLogin, "Логин");
            SetPlaceholder(textBoxRegEmail, "Email");
            SetPlaceholder(textBoxRegPass, "Пароль");
        }

        private void SetPlaceholder(TextBox tb, string text)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = text;
                tb.ForeColor = Color.Gray;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox tb && tb.ForeColor == Color.Gray)
            {
                tb.Text = "";
                tb.ForeColor = Color.FromArgb(232, 232, 240);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
            {
                SetPlaceholder(tb, tb.Tag?.ToString() ?? "");
            }
        }

        private void Edition_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string ed)
            {
                currentEdition = ed;
                UpdateEditor(ed);

                // Подсветка активной кнопки
                foreach (var b in new[] { btnHub, btnCpp, btnCs, btnC, btnJava })
                {
                    b.BackColor = Color.FromArgb(26, 26, 36);
                    b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
                // Акцент для активной
                btn.BackColor = Color.FromArgb(36, 36, 50);
            }
        }

        private void UpdateEditor(string ed)
        {
            // Обновляем заголовок и код в редакторе
            string title = "";
            string code = "";

            switch (ed)
            {
                case "hub":
                    title = "LocalHub — Multi-Language Hub";
                    code = "// LocalHub — Multi-Language Playground\n// Выберите Edition слева, чтобы сменить язык\n\nusing System;\n\nclass Program {\n    static void Main() {\n        Console.WriteLine(\"Привет, LocalHub!\");\n    }\n}";
                    break;
                case "cpp":
                    title = "LocalHub — C++ Edition";
                    code = "#include <iostream>\n\nint main() {\n    std::cout << \"Hello from C++ Edition!\" << std::endl;\n    return 0;\n}";
                    break;
                case "cs":
                    title = "LocalHub — C# Edition";
                    code = "using System;\n\nclass Program {\n    static void Main() {\n        Console.WriteLine(\"Hello from C# Edition!\");\n    }\n}";
                    break;
                case "c":
                    title = "LocalHub — C Edition";
                    code = "#include <stdio.h>\n\nint main(void) {\n    printf(\"Hello from C Edition!\\n\");\n    return 0;\n}";
                    break;
                case "java":
                    title = "LocalHub — Java Edition";
                    code = "public class Main {\n    public static void main(String[] args) {\n        System.out.println(\"Hello from Java Edition!\");\n    }\n}";
                    break;
            }

            labelEditionInfo.Text = title;
            textBoxCodeEditor.Text = code;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            string lang = currentEdition switch
            {
                "cpp" => "C++",
                "cs" => "C#",
                "c" => "C",
                "java" => "Java",
                _ => "Hub"
            };

            string codePreview = textBoxCodeEditor.Text;
            if (codePreview.Length > 100)
                codePreview = codePreview.Substring(0, 100) + "...";

            MessageBox.Show(
                $"▶️ Запуск ({lang} Edition)\n\nКод:\n{codePreview}",
                "LocalHub — Запуск",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "💾 Код сохранён в локальном хранилище (демо-режим)",
                "LocalHub — Сохранение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SocialLogin_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string provider)
            {
                MessageBox.Show(
                    $"🔐 Вход через {provider} (демо-режим)",
                    "LocalHub — Вход",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxRegLogin.Text.Trim();
            string email = textBoxRegEmail.Text.Trim();
            string pass = textBoxRegPass.Text.Trim();

            if (login == "Логин" || email == "Email" || pass == "Пароль" ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show(
                    "Пожалуйста, заполните все поля регистрации.",
                    "LocalHub — Регистрация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Простейшая валидация email
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show(
                    "Введите корректный Email адрес.",
                    "LocalHub — Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"✅ Пользователь {login} успешно зарегистрирован (демо-режим)",
                "LocalHub — Регистрация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Очистка полей после успешной регистрации
            textBoxRegLogin.Clear();
            textBoxRegEmail.Clear();
            textBoxRegPass.Clear();
        }

        private void ButtonLoginForm_Click(object sender, EventArgs e)
        {
            string login = textBoxRegLogin.Text.Trim();
            if (login == "Логин" || string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show(
                    "Введите логин для входа.",
                    "LocalHub — Вход",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"🔐 Выполнен вход: {login} (демо-режим)",
                "LocalHub — Вход",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}