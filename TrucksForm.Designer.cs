namespace Licenta
{
    partial class TrucksForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrucksForm));
            dataGridView1 = new DataGridView();
            cboxBrand = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtbxSearch = new TextBox();
            btnReset = new Button();
            cboxModel = new ComboBox();
            label3 = new Label();
            cboxYear = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.MediumPurple;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(0, 143);
            dataGridView1.Name = "dataGridView1";
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
            dataGridView1.Size = new Size(1268, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // cboxBrand
            // 
            cboxBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxBrand.FormattingEnabled = true;
            cboxBrand.Location = new Point(104, 9);
            cboxBrand.Name = "cboxBrand";
            cboxBrand.Size = new Size(197, 53);
            cboxBrand.TabIndex = 1;
            cboxBrand.SelectedIndexChanged += cboxBrand_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 2;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(742, 15);
            label2.Name = "label2";
            label2.Size = new Size(144, 45);
            label2.TabIndex = 3;
            label2.Text = "Căutare:";
            // 
            // txtbxSearch
            // 
            txtbxSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbxSearch.Location = new Point(880, 17);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.Size = new Size(316, 45);
            txtbxSearch.TabIndex = 4;
            txtbxSearch.KeyDown += txtbxSearch_KeyDown;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(1211, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(45, 45);
            btnReset.TabIndex = 5;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cboxModel
            // 
            cboxModel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxModel.FormattingEnabled = true;
            cboxModel.Location = new Point(105, 84);
            cboxModel.Name = "cboxModel";
            cboxModel.Size = new Size(196, 53);
            cboxModel.TabIndex = 6;
            cboxModel.SelectedIndexChanged += cboxModel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 90);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 7;
            label3.Text = "Model:";
            // 
            // cboxYear
            // 
            cboxYear.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxYear.FormattingEnabled = true;
            cboxYear.Location = new Point(403, 9);
            cboxYear.Name = "cboxYear";
            cboxYear.Size = new Size(108, 53);
            cboxYear.TabIndex = 8;
            cboxYear.SelectedIndexChanged += cboxYear_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(339, 15);
            label4.Name = "label4";
            label4.Size = new Size(62, 38);
            label4.TabIndex = 9;
            label4.Text = "An:";
            // 
            // TrucksForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1268, 444);
            Controls.Add(cboxYear);
            Controls.Add(label4);
            Controls.Add(cboxModel);
            Controls.Add(label3);
            Controls.Add(txtbxSearch);
            Controls.Add(cboxBrand);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1290, 500);
            Name = "TrucksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Camioane detinute";
            FormClosed += TrucksForm_FormClosed;
            Load += TrucksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cboxBrand;
        private Label label1;
        private Label label2;
        private TextBox txtbxSearch;
        private Button btnReset;
        private ComboBox cboxModel;
        private Label label3;
        private ComboBox cboxYear;
        private Label label4;
    }
}