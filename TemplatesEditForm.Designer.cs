namespace Licenta
{
    partial class TemplatesEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplatesEditForm));
            txtBank = new TextBox();
            label8 = new Label();
            txtIban = new TextBox();
            label7 = new Label();
            txtAdress = new TextBox();
            label6 = new Label();
            txtCif = new TextBox();
            label5 = new Label();
            txtRegCom = new TextBox();
            label4 = new Label();
            txtFirma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboxTemplates = new ComboBox();
            btnDelete = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtBank
            // 
            txtBank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBank.Location = new Point(316, 409);
            txtBank.Name = "txtBank";
            txtBank.Size = new Size(300, 39);
            txtBank.TabIndex = 28;
            txtBank.TextChanged += txtBank_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 409);
            label8.Name = "label8";
            label8.Size = new Size(89, 32);
            label8.TabIndex = 27;
            label8.Text = "Banca:";
            // 
            // txtIban
            // 
            txtIban.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIban.Location = new Point(316, 349);
            txtIban.Name = "txtIban";
            txtIban.Size = new Size(300, 39);
            txtIban.TabIndex = 26;
            txtIban.TextChanged += txtIban_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 349);
            label7.Name = "label7";
            label7.Size = new Size(80, 32);
            label7.TabIndex = 25;
            label7.Text = "IBAN:";
            // 
            // txtAdress
            // 
            txtAdress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdress.Location = new Point(316, 289);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(300, 39);
            txtAdress.TabIndex = 24;
            txtAdress.TextChanged += txtAdress_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 289);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 23;
            label6.Text = "Adresa:";
            // 
            // txtCif
            // 
            txtCif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCif.Location = new Point(316, 229);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(300, 39);
            txtCif.TabIndex = 22;
            txtCif.TextChanged += txtCif_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(286, 32);
            label5.TabIndex = 21;
            label5.Text = "Cod Identificare Fiscala:";
            // 
            // txtRegCom
            // 
            txtRegCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegCom.Location = new Point(316, 169);
            txtRegCom.Name = "txtRegCom";
            txtRegCom.Size = new Size(300, 39);
            txtRegCom.TabIndex = 20;
            txtRegCom.TextChanged += txtRegCom_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(230, 32);
            label4.TabIndex = 19;
            label4.Text = "Numar Reg. Com. :";
            // 
            // txtFirma
            // 
            txtFirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirma.Location = new Point(316, 109);
            txtFirma.Name = "txtFirma";
            txtFirma.Size = new Size(300, 39);
            txtFirma.TabIndex = 18;
            txtFirma.TextChanged += txtFirma_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 17;
            label1.Text = "Nume firma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(272, 45);
            label2.TabIndex = 30;
            label2.Text = "Selectare sablon:";
            // 
            // cboxTemplates
            // 
            cboxTemplates.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxTemplates.FormattingEnabled = true;
            cboxTemplates.Location = new Point(290, 9);
            cboxTemplates.Name = "cboxTemplates";
            cboxTemplates.Size = new Size(326, 53);
            cboxTemplates.TabIndex = 29;
            cboxTemplates.SelectedIndexChanged += cboxTemplates_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(325, 489);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 60);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Stergere";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(116, 86, 174);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(82, 489);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 60);
            btnSave.TabIndex = 31;
            btnSave.Text = "Salvare";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TemplatesEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 569);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(cboxTemplates);
            Controls.Add(txtBank);
            Controls.Add(label8);
            Controls.Add(txtIban);
            Controls.Add(label7);
            Controls.Add(txtAdress);
            Controls.Add(label6);
            Controls.Add(txtCif);
            Controls.Add(label5);
            Controls.Add(txtRegCom);
            Controls.Add(label4);
            Controls.Add(txtFirma);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TemplatesEditForm";
            Text = "Administrare Sabloane";
            FormClosed += TemplatesEditForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBank;
        private Label label8;
        private TextBox txtIban;
        private Label label7;
        private TextBox txtAdress;
        private Label label6;
        private TextBox txtCif;
        private Label label5;
        private TextBox txtRegCom;
        private Label label4;
        private TextBox txtFirma;
        private Label label1;
        private Label label2;
        private ComboBox cboxTemplates;
        private Button btnDelete;
        private Button btnSave;
    }
}