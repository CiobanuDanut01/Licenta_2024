using System.ComponentModel;

namespace Licenta
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmRegister));
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            label3 = new Label();
            textConPassword = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            btnCloseRegister = new Button();
            btnHidePass = new Button();
            btnShowPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(80, 80);
            label1.Name = "label1";
            label1.Size = new Size(225, 40);
            label1.TabIndex = 0;
            label1.Text = "Înregistrare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 170);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "Utilizator";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(37, 200);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(298, 30);
            textUsername.TabIndex = 2;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(37, 300);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(298, 30);
            textPassword.TabIndex = 4;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 270);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 3;
            label3.Text = "Parolă";
            // 
            // textConPassword
            // 
            textConPassword.BackColor = Color.FromArgb(230, 231, 233);
            textConPassword.BorderStyle = BorderStyle.None;
            textConPassword.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textConPassword.Location = new Point(37, 400);
            textConPassword.Multiline = true;
            textConPassword.Name = "textConPassword";
            textConPassword.PasswordChar = '*';
            textConPassword.Size = new Size(298, 30);
            textConPassword.TabIndex = 6;
            textConPassword.Leave += textConPassword_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 370);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 5;
            label4.Text = "Confirmă parola";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 520);
            button1.Name = "button1";
            button1.Size = new Size(298, 51);
            button1.TabIndex = 8;
            button1.Text = "ÎNREGISTRARE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(37, 590);
            button2.Name = "button2";
            button2.Size = new Size(298, 51);
            button2.TabIndex = 9;
            button2.Text = "GOLIRE CÂMPURI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(113, 682);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 10;
            label5.Text = "Ai deja cont ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(35, 720);
            label6.Name = "label6";
            label6.Size = new Size(322, 28);
            label6.TabIndex = 11;
            label6.Text = "Înapoi la meniul de autentificare";
            label6.Click += label6_Click;
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.BackColor = Color.FromArgb(116, 86, 174);
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.FlatAppearance.BorderSize = 0;
            btnCloseRegister.FlatStyle = FlatStyle.Flat;
            btnCloseRegister.ForeColor = Color.White;
            btnCloseRegister.Location = new Point(341, 12);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(35, 35);
            btnCloseRegister.TabIndex = 25;
            btnCloseRegister.Text = "X";
            btnCloseRegister.UseVisualStyleBackColor = false;
            btnCloseRegister.Click += btnCloseRegister_Click;
            // 
            // btnHidePass
            // 
            btnHidePass.BackColor = Color.White;
            btnHidePass.Cursor = Cursors.Hand;
            btnHidePass.FlatStyle = FlatStyle.Flat;
            btnHidePass.ForeColor = Color.FromArgb(116, 86, 174);
            btnHidePass.Image = (Image)resources.GetObject("btnHidePass.Image");
            btnHidePass.Location = new Point(300, 451);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(35, 35);
            btnHidePass.TabIndex = 26;
            btnHidePass.UseVisualStyleBackColor = false;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.White;
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.ForeColor = Color.FromArgb(116, 86, 174);
            btnShowPass.Image = (Image)resources.GetObject("btnShowPass.Image");
            btnShowPass.Location = new Point(300, 451);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(35, 35);
            btnShowPass.TabIndex = 27;
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(388, 800);
            Controls.Add(btnShowPass);
            Controls.Add(btnHidePass);
            Controls.Add(btnCloseRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textConPassword);
            Controls.Add(label4);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label label3;
        private TextBox textConPassword;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button btnCloseRegister;
        private Button btnHidePass;
        private Button btnShowPass;
    }
}
