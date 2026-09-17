using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LocalHubApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Панель навигации слева
        private Panel panelMenu;
        // Панель контента
        private Panel panelRight;
        // Вкладки Edition
        private Panel panelEditionTabs;
        // Основной контейнер
        private Panel panelMain;

        // Элементы редактора кода
        private Label labelEditorTitle;
        private TextBox textBoxCodeEditor;
        private Button buttonRun;
        private Button buttonSave;

        // Элементы регистрации
        private Panel panelRegister;
        private Label labelRegTitle;
        private TextBox textBoxRegLogin;
        private TextBox textBoxRegEmail;
        private TextBox textBoxRegPass;
        private Button buttonRegister;
        private Button buttonLoginForm;

        // Кнопки входа через соцсети
        private Button buttonGitHub;
        private Button buttonVK;
        private Button buttonMicrosoft;
        private Button buttonGoogle;

        // Кнопки Edition
        private Button btnHub;
        private Button btnCpp;
        private Button btnCs;
        private Button btnC;
        private Button btnJava;

        // Логотип
        private Label labelLogo;
        // Метка текущей версии
        private Label labelEditionInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelEditionTabs = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();

            this.labelEditorTitle = new System.Windows.Forms.Label();
            this.textBoxCodeEditor = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();

            this.panelRegister = new System.Windows.Forms.Panel();
            this.labelRegTitle = new System.Windows.Forms.Label();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.textBoxRegEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegPass = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLoginForm = new System.Windows.Forms.Button();

            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonVK = new System.Windows.Forms.Button();
            this.buttonMicrosoft = new System.Windows.Forms.Button();
            this.buttonGoogle = new System.Windows.Forms.Button();

            this.btnHub = new System.Windows.Forms.Button();
            this.btnCpp = new System.Windows.Forms.Button();
            this.btnCs = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnJava = new System.Windows.Forms.Button();

            this.labelLogo = new System.Windows.Forms.Label();
            this.labelEditionInfo = new System.Windows.Forms.Label();

            this.panelMenu.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelEditionTabs.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(13, 13, 18);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalHub — Multi-Language Hub";

            // panelMenu (левая панель)
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(21, 21, 28);
            this.panelMenu.Controls.Add(this.labelLogo);
            this.panelMenu.Controls.Add(this.btnHub);
            this.panelMenu.Controls.Add(this.btnCpp);
            this.panelMenu.Controls.Add(this.btnCs);
            this.panelMenu.Controls.Add(this.btnC);
            this.panelMenu.Controls.Add(this.btnJava);
            this.panelMenu.Controls.Add(this.buttonGitHub);
            this.panelMenu.Controls.Add(this.buttonVK);
            this.panelMenu.Controls.Add(this.buttonMicrosoft);
            this.panelMenu.Controls.Add(this.buttonGoogle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 700);
            this.panelMenu.TabIndex = 0;

            // labelLogo
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(154, 123, 216);
            this.labelLogo.Location = new System.Drawing.Point(16, 16);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(134, 37);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "LocalHub";

            // btnHub
            this.btnHub.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.btnHub.FlatAppearance.BorderSize = 0;
            this.btnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHub.ForeColor = System.Drawing.Color.FromArgb(154, 123, 216);
            this.btnHub.Location = new System.Drawing.Point(12, 70);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(176, 40);
            this.btnHub.TabIndex = 1;
            this.btnHub.Text = "🌟 Hub";
            this.btnHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHub.UseVisualStyleBackColor = false;
            this.btnHub.Click += new System.EventHandler(this.Edition_Click);
            this.btnHub.Tag = "hub";

            // btnCpp
            this.btnCpp.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.btnCpp.FlatAppearance.BorderSize = 0;
            this.btnCpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCpp.ForeColor = System.Drawing.Color.FromArgb(0, 89, 156);
            this.btnCpp.Location = new System.Drawing.Point(12, 116);
            this.btnCpp.Name = "btnCpp";
            this.btnCpp.Size = new System.Drawing.Size(176, 40);
            this.btnCpp.TabIndex = 2;
            this.btnCpp.Text = "🟦 C++";
            this.btnCpp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpp.UseVisualStyleBackColor = false;
            this.btnCpp.Click += new System.EventHandler(this.Edition_Click);
            this.btnCpp.Tag = "cpp";

            // btnCs
            this.btnCs.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.btnCs.FlatAppearance.BorderSize = 0;
            this.btnCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCs.ForeColor = System.Drawing.Color.FromArgb(104, 33, 122);
            this.btnCs.Location = new System.Drawing.Point(12, 162);
            this.btnCs.Name = "btnCs";
            this.btnCs.Size = new System.Drawing.Size(176, 40);
            this.btnCs.TabIndex = 3;
            this.btnCs.Text = "🟣 C#";
            this.btnCs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCs.UseVisualStyleBackColor = false;
            this.btnCs.Click += new System.EventHandler(this.Edition_Click);
            this.btnCs.Tag = "cs";

            // btnC
            this.btnC.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(88, 108, 128);
            this.btnC.Location = new System.Drawing.Point(12, 208);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(176, 40);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "⬛ C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.Edition_Click);
            this.btnC.Tag = "c";

            // btnJava
            this.btnJava.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.btnJava.FlatAppearance.BorderSize = 0;
            this.btnJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJava.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnJava.ForeColor = System.Drawing.Color.FromArgb(232, 111, 0);
            this.btnJava.Location = new System.Drawing.Point(12, 254);
            this.btnJava.Name = "btnJava";
            this.btnJava.Size = new System.Drawing.Size(176, 40);
            this.btnJava.TabIndex = 5;
            this.btnJava.Text = "🟠 Java";
            this.btnJava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJava.UseVisualStyleBackColor = false;
            this.btnJava.Click += new System.EventHandler(this.Edition_Click);
            this.btnJava.Tag = "java";

            // buttonGitHub
            this.buttonGitHub.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.buttonGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGitHub.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonGitHub.Location = new System.Drawing.Point(12, 540);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(176, 32);
            this.buttonGitHub.TabIndex = 10;
            this.buttonGitHub.Text = "⬡ GitHub";
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new System.EventHandler(this.SocialLogin_Click);
            this.buttonGitHub.Tag = "GitHub";

            // buttonVK
            this.buttonVK.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.buttonVK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonVK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonVK.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonVK.Location = new System.Drawing.Point(12, 578);
            this.buttonVK.Name = "buttonVK";
            this.buttonVK.Size = new System.Drawing.Size(176, 32);
            this.buttonVK.TabIndex = 11;
            this.buttonVK.Text = "Ⓥ VK";
            this.buttonVK.UseVisualStyleBackColor = false;
            this.buttonVK.Click += new System.EventHandler(this.SocialLogin_Click);
            this.buttonVK.Tag = "VK";

            // buttonMicrosoft
            this.buttonMicrosoft.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.buttonMicrosoft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMicrosoft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMicrosoft.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonMicrosoft.Location = new System.Drawing.Point(12, 616);
            this.buttonMicrosoft.Name = "buttonMicrosoft";
            this.buttonMicrosoft.Size = new System.Drawing.Size(176, 32);
            this.buttonMicrosoft.TabIndex = 12;
            this.buttonMicrosoft.Text = "⊞ Microsoft";
            this.buttonMicrosoft.UseVisualStyleBackColor = false;
            this.buttonMicrosoft.Click += new System.EventHandler(this.SocialLogin_Click);
            this.buttonMicrosoft.Tag = "Microsoft";

            // buttonGoogle
            this.buttonGoogle.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.buttonGoogle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoogle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGoogle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonGoogle.Location = new System.Drawing.Point(12, 654);
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.Size = new System.Drawing.Size(176, 32);
            this.buttonGoogle.TabIndex = 13;
            this.buttonGoogle.Text = "Ⓖ Google";
            this.buttonGoogle.UseVisualStyleBackColor = false;
            this.buttonGoogle.Click += new System.EventHandler(this.SocialLogin_Click);
            this.buttonGoogle.Tag = "Google";

            // panelRight
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(13, 13, 18);
            this.panelRight.Controls.Add(this.panelMain);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(200, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(1000, 700);
            this.panelRight.TabIndex = 1;

            // panelMain
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(13, 13, 18);
            this.panelMain.Controls.Add(this.labelEditionInfo);
            this.panelMain.Controls.Add(this.labelEditorTitle);
            this.panelMain.Controls.Add(this.textBoxCodeEditor);
            this.panelMain.Controls.Add(this.buttonRun);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.panelRegister);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 660);
            this.panelMain.TabIndex = 0;

            // labelEditionInfo
            this.labelEditionInfo.AutoSize = true;
            this.labelEditionInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.labelEditionInfo.ForeColor = System.Drawing.Color.FromArgb(136, 136, 160);
            this.labelEditionInfo.Location = new System.Drawing.Point(4, 8);
            this.labelEditionInfo.Name = "labelEditionInfo";
            this.labelEditionInfo.Size = new System.Drawing.Size(208, 20);
            this.labelEditionInfo.TabIndex = 12;
            this.labelEditionInfo.Text = "LocalHub — Multi-Language Hub";

            // labelEditorTitle
            this.labelEditorTitle.AutoSize = true;
            this.labelEditorTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelEditorTitle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.labelEditorTitle.Location = new System.Drawing.Point(4, 36);
            this.labelEditorTitle.Name = "labelEditorTitle";
            this.labelEditorTitle.Size = new System.Drawing.Size(196, 32);
            this.labelEditorTitle.TabIndex = 0;
            this.labelEditorTitle.Text = "✏️ Редактор кода";

            // textBoxCodeEditor
            this.textBoxCodeEditor.AcceptsReturn = true;
            this.textBoxCodeEditor.AcceptsTab = true;
            this.textBoxCodeEditor.BackColor = System.Drawing.Color.FromArgb(10, 10, 15);
            this.textBoxCodeEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodeEditor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodeEditor.ForeColor = System.Drawing.Color.FromArgb(200, 208, 224);
            this.textBoxCodeEditor.Location = new System.Drawing.Point(8, 76);
            this.textBoxCodeEditor.Multiline = true;
            this.textBoxCodeEditor.Name = "textBoxCodeEditor";
            this.textBoxCodeEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCodeEditor.Size = new System.Drawing.Size(920, 280);
            this.textBoxCodeEditor.TabIndex = 1;
            this.textBoxCodeEditor.Text = "// LocalHub — Multi-Language Playground\n// Выберите Edition слева, чтобы сменить язык\n\nusing System;\n\nclass Program {\n    static void Main() {\n        Console.WriteLine(\"Привет, LocalHub!\");\n    }\n}";

            // buttonRun
            this.buttonRun.BackColor = System.Drawing.Color.FromArgb(154, 123, 216);
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRun.ForeColor = System.Drawing.Color.White;
            this.buttonRun.Location = new System.Drawing.Point(8, 364);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(120, 38);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "▶ Запустить";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);

            // buttonSave
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonSave.Location = new System.Drawing.Point(136, 364);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 38);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "💾 Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            // panelRegister
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(26, 26, 36);
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegister.Controls.Add(this.labelRegTitle);
            this.panelRegister.Controls.Add(this.textBoxRegLogin);
            this.panelRegister.Controls.Add(this.textBoxRegEmail);
            this.panelRegister.Controls.Add(this.textBoxRegPass);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.buttonLoginForm);
            this.panelRegister.Location = new System.Drawing.Point(8, 416);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(920, 220);
            this.panelRegister.TabIndex = 10;

            // labelRegTitle
            this.labelRegTitle.AutoSize = true;
            this.labelRegTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelRegTitle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.labelRegTitle.Location = new System.Drawing.Point(16, 12);
            this.labelRegTitle.Name = "labelRegTitle";
            this.labelRegTitle.Size = new System.Drawing.Size(216, 28);
            this.labelRegTitle.TabIndex = 0;
            this.labelRegTitle.Text = "📝 Регистрация / Вход";

            // textBoxRegLogin
            this.textBoxRegLogin.BackColor = System.Drawing.Color.FromArgb(21, 21, 28);
            this.textBoxRegLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRegLogin.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.textBoxRegLogin.Location = new System.Drawing.Point(20, 50);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(400, 30);
            this.textBoxRegLogin.TabIndex = 1;
            this.textBoxRegLogin.Text = "";
            this.textBoxRegLogin.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxRegLogin.Leave += new System.EventHandler(this.TextBox_Leave);
            this.textBoxRegLogin.Tag = "Логин";

            // textBoxRegEmail
            this.textBoxRegEmail.BackColor = System.Drawing.Color.FromArgb(21, 21, 28);
            this.textBoxRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRegEmail.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.textBoxRegEmail.Location = new System.Drawing.Point(20, 90);
            this.textBoxRegEmail.Name = "textBoxRegEmail";
            this.textBoxRegEmail.Size = new System.Drawing.Size(400, 30);
            this.textBoxRegEmail.TabIndex = 2;
            this.textBoxRegEmail.Text = "";
            this.textBoxRegEmail.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxRegEmail.Leave += new System.EventHandler(this.TextBox_Leave);
            this.textBoxRegEmail.Tag = "Email";

            // textBoxRegPass
            this.textBoxRegPass.BackColor = System.Drawing.Color.FromArgb(21, 21, 28);
            this.textBoxRegPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRegPass.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.textBoxRegPass.Location = new System.Drawing.Point(20, 130);
            this.textBoxRegPass.Name = "textBoxRegPass";
            this.textBoxRegPass.PasswordChar = '*';
            this.textBoxRegPass.Size = new System.Drawing.Size(400, 30);
            this.textBoxRegPass.TabIndex = 3;
            this.textBoxRegPass.Text = "";
            this.textBoxRegPass.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxRegPass.Leave += new System.EventHandler(this.TextBox_Leave);
            this.textBoxRegPass.Tag = "Пароль";

            // buttonRegister
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(154, 123, 216);
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(20, 170);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(190, 36);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);

            // buttonLoginForm
            this.buttonLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoginForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 42, 58);
            this.buttonLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLoginForm.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240);
            this.buttonLoginForm.Location = new System.Drawing.Point(220, 170);
            this.buttonLoginForm.Name = "buttonLoginForm";
            this.buttonLoginForm.Size = new System.Drawing.Size(100, 36);
            this.buttonLoginForm.TabIndex = 5;
            this.buttonLoginForm.Text = "Войти";
            this.buttonLoginForm.UseVisualStyleBackColor = false;
            this.buttonLoginForm.Click += new System.EventHandler(this.ButtonLoginForm_Click);

            // Layout
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMenu);

            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelEditionTabs.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}