namespace ledger_horana
{
    partial class ledgerContentCredit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ledgerContentCredit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuDropdown3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPaidAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtInvoiceValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtInvoiceNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBmn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnVoucher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 598);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuDropdown3);
            this.groupBox2.Controls.Add(this.btnVoucher);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.txtSubmit);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtPaidAmount);
            this.groupBox2.Controls.Add(this.txtInvoiceValue);
            this.groupBox2.Controls.Add(this.txtInvoiceNo);
            this.groupBox2.Controls.Add(this.txtBmn);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Location = new System.Drawing.Point(20, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MUST FILL";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown3.BorderRadius = 3;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown3.Items = new string[] {
        "CASH",
        "CHEQUE"};
            this.bunifuDropdown3.Location = new System.Drawing.Point(362, 193);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown3.selectedIndex = -1;
            this.bunifuDropdown3.Size = new System.Drawing.Size(140, 30);
            this.bunifuDropdown3.TabIndex = 18;
            this.bunifuDropdown3.onItemSelected += new System.EventHandler(this.bunifuDropdown3_onItemSelected);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPaidAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPaidAmount.BorderThickness = 3;
            this.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmount.isPassword = false;
            this.txtPaidAmount.Location = new System.Drawing.Point(93, 187);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(219, 36);
            this.txtPaidAmount.TabIndex = 11;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtInvoiceValue
            // 
            this.txtInvoiceValue.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtInvoiceValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceValue.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtInvoiceValue.BorderThickness = 3;
            this.txtInvoiceValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceValue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInvoiceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceValue.isPassword = false;
            this.txtInvoiceValue.Location = new System.Drawing.Point(93, 143);
            this.txtInvoiceValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceValue.Name = "txtInvoiceValue";
            this.txtInvoiceValue.Size = new System.Drawing.Size(219, 36);
            this.txtInvoiceValue.TabIndex = 10;
            this.txtInvoiceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtInvoiceNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtInvoiceNo.BorderThickness = 3;
            this.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceNo.isPassword = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(93, 99);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(219, 36);
            this.txtInvoiceNo.TabIndex = 9;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBmn
            // 
            this.txtBmn.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBmn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBmn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBmn.BorderThickness = 3;
            this.txtBmn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBmn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBmn.isPassword = false;
            this.txtBmn.Location = new System.Drawing.Point(93, 55);
            this.txtBmn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBmn.Name = "txtBmn";
            this.txtBmn.Size = new System.Drawing.Size(219, 36);
            this.txtBmn.TabIndex = 8;
            this.txtBmn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(326, 109);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Date";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(326, 199);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(18, 13);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "by";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(19, 200);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(58, 13);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Paid Value";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(18, 156);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Invoice Value";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 111);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Invoice No :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "BMN           :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Location = new System.Drawing.Point(20, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREDIT";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(362, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(294, 49);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel9.TabIndex = 2;
            this.bunifuCustomLabel9.Text = "Name";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(23, 49);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(49, 13);
            this.bunifuCustomLabel8.TabIndex = 1;
            this.bunifuCustomLabel8.Text = "Category";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(747, 579);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(232, 13);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "Designed by Autonomous Factory  0761262279";
            // 
            // btnVoucher
            // 
            this.btnVoucher.ActiveBorderThickness = 1;
            this.btnVoucher.ActiveCornerRadius = 20;
            this.btnVoucher.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVoucher.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoucher.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoucher.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVoucher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoucher.BackgroundImage")));
            this.btnVoucher.ButtonText = "VOUCHER";
            this.btnVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVoucher.IdleBorderThickness = 1;
            this.btnVoucher.IdleCornerRadius = 20;
            this.btnVoucher.IdleFillColor = System.Drawing.Color.White;
            this.btnVoucher.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnVoucher.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoucher.Location = new System.Drawing.Point(761, 360);
            this.btnVoucher.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(181, 41);
            this.btnVoucher.TabIndex = 17;
            this.btnVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(570, 360);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSubmit
            // 
            this.txtSubmit.ActiveBorderThickness = 1;
            this.txtSubmit.ActiveCornerRadius = 20;
            this.txtSubmit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.txtSubmit.ActiveForecolor = System.Drawing.Color.White;
            this.txtSubmit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.txtSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSubmit.BackgroundImage")));
            this.txtSubmit.ButtonText = "ENTER";
            this.txtSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmit.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSubmit.IdleBorderThickness = 1;
            this.txtSubmit.IdleCornerRadius = 20;
            this.txtSubmit.IdleFillColor = System.Drawing.Color.White;
            this.txtSubmit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.txtSubmit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.txtSubmit.Location = new System.Drawing.Point(381, 360);
            this.txtSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(181, 41);
            this.txtSubmit.TabIndex = 15;
            this.txtSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // ledgerContentCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ledgerContentCredit";
            this.Size = new System.Drawing.Size(1002, 598);
            this.Load += new System.EventHandler(this.ledgerContentCredit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPaidAmount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtInvoiceValue;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtInvoiceNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBmn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVoucher;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 txtSubmit;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
    }
}
