namespace Licenta
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            dataGridView1 = new DataGridView();
            cboxDrivingCats = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtbxSearch = new TextBox();
            btnReset = new Button();
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
            dataGridView1.Location = new Point(0, 79);
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
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1108, 365);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // cboxDrivingCats
            // 
            cboxDrivingCats.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxDrivingCats.FormattingEnabled = true;
            cboxDrivingCats.Location = new Point(278, 9);
            cboxDrivingCats.Name = "cboxDrivingCats";
            cboxDrivingCats.Size = new Size(108, 53);
            cboxDrivingCats.TabIndex = 1;
            cboxDrivingCats.SelectedIndexChanged += cboxDrivingCats_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 15);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 2;
            label1.Text = "Categorii de permis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 15);
            label2.Name = "label2";
            label2.Size = new Size(144, 45);
            label2.TabIndex = 3;
            label2.Text = "Căutare:";
            // 
            // txtbxSearch
            // 
            txtbxSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbxSearch.Location = new Point(579, 17);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.Size = new Size(456, 45);
            txtbxSearch.TabIndex = 4;
            txtbxSearch.KeyDown += txtbxSearch_KeyDown;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(1050, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(45, 45);
            btnReset.TabIndex = 5;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1108, 444);
            Controls.Add(txtbxSearch);
            Controls.Add(cboxDrivingCats);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1130, 500);
            Name = "DriverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soferi";
            FormClosed += DriverForm_FormClosed;
            Load += DriverForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cboxDrivingCats;
        private Label label1;
        private Label label2;
        private TextBox txtbxSearch;
        private Button btnReset;
    }
}