namespace Licenta
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            btnView = new Button();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            chkboxEmail = new CheckBox();
            btnSendMail = new Button();
            txtboxMail = new TextBox();
            label1 = new Label();
            lblMissing = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(400, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 45);
            btnRefresh.TabIndex = 34;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.White;
            btnView.Cursor = Cursors.Hand;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.FromArgb(116, 86, 174);
            btnView.Location = new Point(451, 6);
            btnView.Name = "btnView";
            btnView.Size = new Size(200, 60);
            btnView.TabIndex = 33;
            btnView.Text = "Vizualizare";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.MediumPurple;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(0, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Thistle;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(878, 365);
            dataGridView1.TabIndex = 32;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(666, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 60);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Stergere";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(116, 86, 174);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 60);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Adaugare";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // chkboxEmail
            // 
            chkboxEmail.AutoSize = true;
            chkboxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkboxEmail.Location = new Point(12, 72);
            chkboxEmail.Name = "chkboxEmail";
            chkboxEmail.Size = new Size(335, 36);
            chkboxEmail.TabIndex = 35;
            chkboxEmail.Text = "Trimitere factura pe email";
            chkboxEmail.UseVisualStyleBackColor = true;
            chkboxEmail.CheckedChanged += chkboxEmail_CheckedChanged;
            // 
            // btnSendMail
            // 
            btnSendMail.BackColor = Color.FromArgb(116, 86, 174);
            btnSendMail.Cursor = Cursors.Hand;
            btnSendMail.FlatAppearance.BorderSize = 0;
            btnSendMail.FlatStyle = FlatStyle.Flat;
            btnSendMail.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendMail.ForeColor = Color.White;
            btnSendMail.Location = new Point(598, 110);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(268, 50);
            btnSendMail.TabIndex = 36;
            btnSendMail.Text = "Trimitere mail";
            btnSendMail.UseVisualStyleBackColor = false;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // txtboxMail
            // 
            txtboxMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtboxMail.Location = new Point(217, 120);
            txtboxMail.Name = "txtboxMail";
            txtboxMail.Size = new Size(375, 39);
            txtboxMail.TabIndex = 38;
            txtboxMail.TextChanged += txtboxMail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 37;
            label1.Text = "Mail destinatar:";
            // 
            // lblMissing
            // 
            lblMissing.AutoSize = true;
            lblMissing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissing.Location = new Point(206, 6);
            lblMissing.Name = "lblMissing";
            lblMissing.Size = new Size(0, 32);
            lblMissing.TabIndex = 39;
            // 
            // InvoicesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(lblMissing);
            Controls.Add(txtboxMail);
            Controls.Add(label1);
            Controls.Add(btnSendMail);
            Controls.Add(chkboxEmail);
            Controls.Add(btnRefresh);
            Controls.Add(btnView);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 535);
            Name = "InvoicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturi";
            FormClosed += InvoicesForm_FormClosed;
            Load += InvoicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnView;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnAdd;
        private CheckBox chkboxEmail;
        private Button btnSendMail;
        private TextBox txtboxMail;
        private Label label1;
        private Label lblMissing;
    }
}