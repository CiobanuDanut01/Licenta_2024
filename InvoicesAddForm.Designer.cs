namespace Licenta
{
    partial class InvoicesAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesAddForm));
            dtInvoice = new DateTimePicker();
            btnSave = new Button();
            lblInfoFact = new Label();
            lblInfoFirma = new Label();
            chkboxSaveTemplate = new CheckBox();
            txtMeasUnit = new TextBox();
            lblUnitMas = new Label();
            txtAutoNumber = new TextBox();
            lblNrAuto = new Label();
            txtDueDays = new TextBox();
            lblZilePlata = new Label();
            labeDataFacturare = new Label();
            lblDateFactura = new Label();
            lblDateFirma = new Label();
            txtBank = new TextBox();
            lblBank = new Label();
            txtIban = new TextBox();
            lblIBAN = new Label();
            txtAdress = new TextBox();
            lblAdress = new Label();
            txtCif = new TextBox();
            lblCIF = new Label();
            txtRegCom = new TextBox();
            lblRegCom = new Label();
            lblSelectSablon = new Label();
            cboxTemplates = new ComboBox();
            txtFirma = new TextBox();
            lblNumeFirma = new Label();
            pictureBox1 = new PictureBox();
            txtProdInfo = new TextBox();
            lblDetaliiProd = new Label();
            txtUnitPrice = new TextBox();
            lblPretUnit = new Label();
            txtQuantity = new TextBox();
            lblCant = new Label();
            txtCurrency = new TextBox();
            lblMoneda = new Label();
            lblPret = new Label();
            lblPretFinal = new Label();
            txtCotaTva = new TextBox();
            label1 = new Label();
            btnCalc = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtInvoice
            // 
            dtInvoice.CustomFormat = "dd/MM/yyyy";
            dtInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInvoice.Format = DateTimePickerFormat.Custom;
            dtInvoice.Location = new Point(906, 177);
            dtInvoice.Name = "dtInvoice";
            dtInvoice.Size = new Size(274, 39);
            dtInvoice.TabIndex = 132;
            dtInvoice.ValueChanged += dtInvoice_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(116, 86, 174);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1367, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(291, 60);
            btnSave.TabIndex = 131;
            btnSave.Text = "Salvare factura";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblInfoFact
            // 
            lblInfoFact.AutoSize = true;
            lblInfoFact.BackColor = Color.Transparent;
            lblInfoFact.BorderStyle = BorderStyle.FixedSingle;
            lblInfoFact.FlatStyle = FlatStyle.Flat;
            lblInfoFact.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoFact.Location = new Point(686, 474);
            lblInfoFact.Name = "lblInfoFact";
            lblInfoFact.Size = new Size(587, 142);
            lblInfoFact.TabIndex = 130;
            lblInfoFact.Text = resources.GetString("lblInfoFact.Text");
            // 
            // lblInfoFirma
            // 
            lblInfoFirma.AutoSize = true;
            lblInfoFirma.BackColor = Color.Transparent;
            lblInfoFirma.BorderStyle = BorderStyle.FixedSingle;
            lblInfoFirma.FlatStyle = FlatStyle.Flat;
            lblInfoFirma.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoFirma.Location = new Point(289, 571);
            lblInfoFirma.Name = "lblInfoFirma";
            lblInfoFirma.Size = new Size(347, 198);
            lblInfoFirma.TabIndex = 129;
            lblInfoFirma.Text = resources.GetString("lblInfoFirma.Text");
            // 
            // chkboxSaveTemplate
            // 
            chkboxSaveTemplate.AutoSize = true;
            chkboxSaveTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkboxSaveTemplate.Location = new Point(390, 525);
            chkboxSaveTemplate.Name = "chkboxSaveTemplate";
            chkboxSaveTemplate.Size = new Size(205, 36);
            chkboxSaveTemplate.TabIndex = 128;
            chkboxSaveTemplate.Text = "Salvare sablon";
            chkboxSaveTemplate.UseVisualStyleBackColor = true;
            chkboxSaveTemplate.CheckedChanged += chkboxSaveTemplate_CheckedChanged;
            // 
            // txtMeasUnit
            // 
            txtMeasUnit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMeasUnit.Location = new Point(1411, 237);
            txtMeasUnit.Name = "txtMeasUnit";
            txtMeasUnit.Size = new Size(247, 39);
            txtMeasUnit.TabIndex = 95;
            txtMeasUnit.TextChanged += txtMeasUnit_TextChanged;
            // 
            // lblUnitMas
            // 
            lblUnitMas.AutoSize = true;
            lblUnitMas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitMas.Location = new Point(1210, 237);
            lblUnitMas.Name = "lblUnitMas";
            lblUnitMas.Size = new Size(195, 32);
            lblUnitMas.TabIndex = 94;
            lblUnitMas.Text = "Unitate masura:";
            // 
            // txtAutoNumber
            // 
            txtAutoNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAutoNumber.Location = new Point(906, 237);
            txtAutoNumber.Name = "txtAutoNumber";
            txtAutoNumber.Size = new Size(274, 39);
            txtAutoNumber.TabIndex = 93;
            txtAutoNumber.TextChanged += txtAutoNumber_TextChanged;
            // 
            // lblNrAuto
            // 
            lblNrAuto.AutoSize = true;
            lblNrAuto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrAuto.Location = new Point(719, 237);
            lblNrAuto.Name = "lblNrAuto";
            lblNrAuto.Size = new Size(159, 32);
            lblNrAuto.TabIndex = 92;
            lblNrAuto.Text = "Numar auto:";
            // 
            // txtDueDays
            // 
            txtDueDays.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDueDays.Location = new Point(1411, 177);
            txtDueDays.Name = "txtDueDays";
            txtDueDays.Size = new Size(247, 39);
            txtDueDays.TabIndex = 89;
            txtDueDays.TextChanged += txtDueDays_TextChanged;
            // 
            // lblZilePlata
            // 
            lblZilePlata.AutoSize = true;
            lblZilePlata.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZilePlata.Location = new Point(1195, 177);
            lblZilePlata.Name = "lblZilePlata";
            lblZilePlata.Size = new Size(210, 32);
            lblZilePlata.TabIndex = 88;
            lblZilePlata.Text = "Numar zile plata:";
            // 
            // labeDataFacturare
            // 
            labeDataFacturare.AutoSize = true;
            labeDataFacturare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeDataFacturare.Location = new Point(693, 177);
            labeDataFacturare.Name = "labeDataFacturare";
            labeDataFacturare.Size = new Size(185, 32);
            labeDataFacturare.TabIndex = 87;
            labeDataFacturare.Text = "Data facturare:";
            // 
            // lblDateFactura
            // 
            lblDateFactura.AutoSize = true;
            lblDateFactura.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFactura.ForeColor = Color.DarkOrchid;
            lblDateFactura.Location = new Point(697, 108);
            lblDateFactura.Name = "lblDateFactura";
            lblDateFactura.Size = new Size(204, 45);
            lblDateFactura.TabIndex = 86;
            lblDateFactura.Text = "Date factura";
            // 
            // lblDateFirma
            // 
            lblDateFirma.AutoSize = true;
            lblDateFirma.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFirma.ForeColor = Color.DarkOrchid;
            lblDateFirma.Location = new Point(12, 108);
            lblDateFirma.Name = "lblDateFirma";
            lblDateFirma.Size = new Size(179, 45);
            lblDateFirma.TabIndex = 85;
            lblDateFirma.Text = "Date firma";
            // 
            // txtBank
            // 
            txtBank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBank.Location = new Point(295, 477);
            txtBank.Name = "txtBank";
            txtBank.Size = new Size(300, 39);
            txtBank.TabIndex = 84;
            txtBank.TextChanged += txtBank_TextChanged;
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBank.Location = new Point(12, 477);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(89, 32);
            lblBank.TabIndex = 83;
            lblBank.Text = "Banca:";
            // 
            // txtIban
            // 
            txtIban.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIban.Location = new Point(295, 417);
            txtIban.Name = "txtIban";
            txtIban.Size = new Size(300, 39);
            txtIban.TabIndex = 82;
            txtIban.TextChanged += txtIban_TextChanged;
            // 
            // lblIBAN
            // 
            lblIBAN.AutoSize = true;
            lblIBAN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIBAN.Location = new Point(12, 417);
            lblIBAN.Name = "lblIBAN";
            lblIBAN.Size = new Size(80, 32);
            lblIBAN.TabIndex = 81;
            lblIBAN.Text = "IBAN:";
            // 
            // txtAdress
            // 
            txtAdress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdress.Location = new Point(295, 357);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(300, 39);
            txtAdress.TabIndex = 80;
            txtAdress.TextChanged += txtAdress_TextChanged;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdress.Location = new Point(12, 357);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(100, 32);
            lblAdress.TabIndex = 79;
            lblAdress.Text = "Adresa:";
            // 
            // txtCif
            // 
            txtCif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCif.Location = new Point(295, 297);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(300, 39);
            txtCif.TabIndex = 78;
            txtCif.TextChanged += txtCif_TextChanged;
            // 
            // lblCIF
            // 
            lblCIF.AutoSize = true;
            lblCIF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCIF.Location = new Point(12, 297);
            lblCIF.Name = "lblCIF";
            lblCIF.Size = new Size(286, 32);
            lblCIF.TabIndex = 77;
            lblCIF.Text = "Cod Identificare Fiscala:";
            // 
            // txtRegCom
            // 
            txtRegCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegCom.Location = new Point(295, 237);
            txtRegCom.Name = "txtRegCom";
            txtRegCom.Size = new Size(300, 39);
            txtRegCom.TabIndex = 76;
            txtRegCom.TextChanged += txtRegCom_TextChanged;
            // 
            // lblRegCom
            // 
            lblRegCom.AutoSize = true;
            lblRegCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegCom.Location = new Point(12, 237);
            lblRegCom.Name = "lblRegCom";
            lblRegCom.Size = new Size(230, 32);
            lblRegCom.TabIndex = 75;
            lblRegCom.Text = "Numar Reg. Com. :";
            // 
            // lblSelectSablon
            // 
            lblSelectSablon.AutoSize = true;
            lblSelectSablon.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectSablon.Location = new Point(12, 11);
            lblSelectSablon.Name = "lblSelectSablon";
            lblSelectSablon.Size = new Size(272, 45);
            lblSelectSablon.TabIndex = 74;
            lblSelectSablon.Text = "Selectare sablon:";
            // 
            // cboxTemplates
            // 
            cboxTemplates.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboxTemplates.FormattingEnabled = true;
            cboxTemplates.Location = new Point(290, 11);
            cboxTemplates.Name = "cboxTemplates";
            cboxTemplates.Size = new Size(498, 53);
            cboxTemplates.TabIndex = 73;
            cboxTemplates.SelectedIndexChanged += cboxTemplates_SelectedIndexChanged;
            // 
            // txtFirma
            // 
            txtFirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirma.Location = new Point(295, 177);
            txtFirma.Name = "txtFirma";
            txtFirma.Size = new Size(300, 39);
            txtFirma.TabIndex = 72;
            txtFirma.TextChanged += txtFirma_TextChanged;
            // 
            // lblNumeFirma
            // 
            lblNumeFirma.AutoSize = true;
            lblNumeFirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeFirma.Location = new Point(12, 177);
            lblNumeFirma.Name = "lblNumeFirma";
            lblNumeFirma.Size = new Size(158, 32);
            lblNumeFirma.TabIndex = 71;
            lblNumeFirma.Text = "Nume firma:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 512);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 260);
            pictureBox1.TabIndex = 127;
            pictureBox1.TabStop = false;
            // 
            // txtProdInfo
            // 
            txtProdInfo.AcceptsReturn = true;
            txtProdInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProdInfo.Location = new Point(906, 297);
            txtProdInfo.Multiline = true;
            txtProdInfo.Name = "txtProdInfo";
            txtProdInfo.Size = new Size(752, 99);
            txtProdInfo.TabIndex = 135;
            txtProdInfo.TextChanged += txtProdInfo_TextChanged;
            // 
            // lblDetaliiProd
            // 
            lblDetaliiProd.AutoSize = true;
            lblDetaliiProd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetaliiProd.Location = new Point(695, 297);
            lblDetaliiProd.Name = "lblDetaliiProd";
            lblDetaliiProd.Size = new Size(183, 32);
            lblDetaliiProd.TabIndex = 134;
            lblDetaliiProd.Text = "Detalii produs:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(1411, 417);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(247, 39);
            txtUnitPrice.TabIndex = 139;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // lblPretUnit
            // 
            lblPretUnit.AutoSize = true;
            lblPretUnit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPretUnit.Location = new Point(1137, 417);
            lblPretUnit.Name = "lblPretUnit";
            lblPretUnit.Size = new Size(268, 32);
            lblPretUnit.TabIndex = 138;
            lblPretUnit.Text = "Pret unitar (fara TVA):";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(906, 417);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(221, 39);
            txtQuantity.TabIndex = 137;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(754, 417);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(124, 32);
            lblCant.TabIndex = 136;
            lblCant.Text = "Cantitate:";
            // 
            // txtCurrency
            // 
            txtCurrency.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrency.Location = new Point(1411, 477);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(247, 39);
            txtCurrency.TabIndex = 141;
            txtCurrency.TextChanged += txtCurrency_TextChanged;
            // 
            // lblMoneda
            // 
            lblMoneda.AutoSize = true;
            lblMoneda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoneda.Location = new Point(1290, 477);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(115, 32);
            lblMoneda.TabIndex = 140;
            lblMoneda.Text = "Moneda:";
            // 
            // lblPret
            // 
            lblPret.AutoSize = true;
            lblPret.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPret.ForeColor = Color.DarkOrchid;
            lblPret.Location = new Point(697, 664);
            lblPret.Name = "lblPret";
            lblPret.Size = new Size(166, 45);
            lblPret.TabIndex = 142;
            lblPret.Text = "Pret final:";
            // 
            // lblPretFinal
            // 
            lblPretFinal.AutoSize = true;
            lblPretFinal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPretFinal.Location = new Point(869, 664);
            lblPretFinal.Name = "lblPretFinal";
            lblPretFinal.Size = new Size(0, 45);
            lblPretFinal.TabIndex = 143;
            // 
            // txtCotaTva
            // 
            txtCotaTva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCotaTva.Location = new Point(1411, 537);
            txtCotaTva.Name = "txtCotaTva";
            txtCotaTva.Size = new Size(99, 39);
            txtCotaTva.TabIndex = 145;
            txtCotaTva.TextChanged += txtCotaTva_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1286, 537);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 144;
            label1.Text = "Cota TVA:";
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.White;
            btnCalc.Cursor = Cursors.Hand;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = Color.FromArgb(116, 86, 174);
            btnCalc.Location = new Point(1161, 12);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(200, 60);
            btnCalc.TabIndex = 146;
            btnCalc.Text = "Calcul pret";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1516, 537);
            label2.Name = "label2";
            label2.Size = new Size(35, 32);
            label2.TabIndex = 147;
            label2.Text = "%";
            // 
            // InvoicesAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1671, 782);
            Controls.Add(label2);
            Controls.Add(btnCalc);
            Controls.Add(txtCotaTva);
            Controls.Add(label1);
            Controls.Add(lblPretFinal);
            Controls.Add(lblPret);
            Controls.Add(txtCurrency);
            Controls.Add(lblMoneda);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblPretUnit);
            Controls.Add(txtQuantity);
            Controls.Add(lblCant);
            Controls.Add(txtProdInfo);
            Controls.Add(lblDetaliiProd);
            Controls.Add(dtInvoice);
            Controls.Add(btnSave);
            Controls.Add(lblInfoFact);
            Controls.Add(lblInfoFirma);
            Controls.Add(chkboxSaveTemplate);
            Controls.Add(txtMeasUnit);
            Controls.Add(lblUnitMas);
            Controls.Add(txtAutoNumber);
            Controls.Add(lblNrAuto);
            Controls.Add(txtDueDays);
            Controls.Add(lblZilePlata);
            Controls.Add(labeDataFacturare);
            Controls.Add(lblDateFactura);
            Controls.Add(lblDateFirma);
            Controls.Add(txtBank);
            Controls.Add(lblBank);
            Controls.Add(txtIban);
            Controls.Add(lblIBAN);
            Controls.Add(txtAdress);
            Controls.Add(lblAdress);
            Controls.Add(txtCif);
            Controls.Add(lblCIF);
            Controls.Add(txtRegCom);
            Controls.Add(lblRegCom);
            Controls.Add(lblSelectSablon);
            Controls.Add(cboxTemplates);
            Controls.Add(txtFirma);
            Controls.Add(lblNumeFirma);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InvoicesAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adaugare factura";
            FormClosed += InvoicesAddForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtInvoice;
        private TextBox txtMeasUnit;
        private TextBox txtAutoNumber;
        private TextBox txtDueDays;
        private TextBox txtProdInfo;
        private TextBox txtUnitPrice;
        private Button btnSave;
        private Label lblInfoFact;
        private Label lblInfoFirma;
        private CheckBox chkboxSaveTemplate;
        private Label lblUnitMas;
        private Label lblNrAuto;
        private Label lblZilePlata;
        private Label labeDataFacturare;
        private Label lblDateFactura;
        private Label lblDateFirma;
        private TextBox txtBank;
        private Label lblBank;
        private TextBox txtIban;
        private Label lblIBAN;
        private TextBox txtAdress;
        private Label lblAdress;
        private TextBox txtCif;
        private Label lblCIF;
        private TextBox txtRegCom;
        private Label lblRegCom;
        private Label lblSelectSablon;
        private ComboBox cboxTemplates;
        private TextBox txtFirma;
        private Label lblNumeFirma;
        private PictureBox pictureBox1;
        private Label lblDetaliiProd;
        private Label lblPretUnit;
        private TextBox txtQuantity;
        private Label lblCant;
        private TextBox txtCurrency;
        private Label lblMoneda;
        private Label lblPret;
        private Label lblPretFinal;
        private TextBox txtCotaTva;
        private Label label1;
        private Button btnCalc;
        private Label label2;
    }
}