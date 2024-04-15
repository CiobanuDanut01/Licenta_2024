namespace Licenta
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkbxShowPassword = new CheckBox();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCloseLogin = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(54, 573);
            label6.Name = "label6";
            label6.Size = new Size(278, 28);
            label6.TabIndex = 23;
            label6.Text = "Către meniul de înregistrare";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(132, 535);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 22;
            label5.Text = "Nu ai cont ?";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(40, 443);
            button2.Name = "button2";
            button2.Size = new Size(298, 51);
            button2.TabIndex = 21;
            button2.Text = "GOLIRE CÂMPURI";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 373);
            button1.Name = "button1";
            button1.Size = new Size(298, 51);
            button1.TabIndex = 20;
            button1.Text = "AUTENTIFICARE";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkbxShowPassword
            // 
            checkbxShowPassword.AutoSize = true;
            checkbxShowPassword.Cursor = Cursors.Hand;
            checkbxShowPassword.FlatStyle = FlatStyle.Flat;
            checkbxShowPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkbxShowPassword.Location = new Point(228, 303);
            checkbxShowPassword.Name = "checkbxShowPassword";
            checkbxShowPassword.Size = new Size(151, 32);
            checkbxShowPassword.TabIndex = 19;
            checkbxShowPassword.Text = "Arată parola";
            checkbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(40, 261);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(298, 30);
            textPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 231);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 15;
            label3.Text = "Parolă";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(40, 161);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(298, 30);
            textUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 131);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 13;
            label2.Text = "Utilizator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(244, 40);
            label1.TabIndex = 12;
            label1.Text = "Autentificare";
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnCloseLogin.Cursor = Cursors.Hand;
            btnCloseLogin.FlatAppearance.BorderSize = 0;
            btnCloseLogin.FlatStyle = FlatStyle.Flat;
            btnCloseLogin.ForeColor = Color.White;
            btnCloseLogin.Location = new Point(353, 12);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(35, 35);
            btnCloseLogin.TabIndex = 24;
            btnCloseLogin.Text = "X";
            btnCloseLogin.UseVisualStyleBackColor = false;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 800);
            Controls.Add(btnCloseLogin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkbxShowPassword);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private CheckBox checkbxShowPassword;
        private TextBox textPassword;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
        private Button btnCloseLogin;
    }
}