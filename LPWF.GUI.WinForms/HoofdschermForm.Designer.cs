namespace LPWF.GUI.WinForms
{
    partial class HoofdschermForm
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
            this.BtnWeer = new System.Windows.Forms.Button();
            this.BtnListContract = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NudMeren = new System.Windows.Forms.NumericUpDown();
            this.BtnMeren = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbNaam = new System.Windows.Forms.TextBox();
            this.BtnZeeToevoegen = new System.Windows.Forms.Button();
            this.CbZee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTot = new System.Windows.Forms.DateTimePicker();
            this.BtnPeriode = new System.Windows.Forms.Button();
            this.DtpVan = new System.Windows.Forms.DateTimePicker();
            this.GbHuidigeBestelling = new System.Windows.Forms.GroupBox();
            this.LbBestelling = new System.Windows.Forms.ListBox();
            this.BtnLegen = new System.Windows.Forms.Button();
            this.BtnVerhuren = new System.Windows.Forms.Button();
            this.NudProducten = new System.Windows.Forms.NumericUpDown();
            this.BtnProductToevoegen = new System.Windows.Forms.Button();
            this.CbProducten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBootToevoegen = new System.Windows.Forms.Button();
            this.CbBoten = new System.Windows.Forms.ComboBox();
            this.BtnBerekenen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeren)).BeginInit();
            this.GbHuidigeBestelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnWeer
            // 
            this.BtnWeer.Location = new System.Drawing.Point(12, 12);
            this.BtnWeer.Name = "BtnWeer";
            this.BtnWeer.Size = new System.Drawing.Size(75, 23);
            this.BtnWeer.TabIndex = 0;
            this.BtnWeer.Text = "Weer";
            this.BtnWeer.UseVisualStyleBackColor = true;
            this.BtnWeer.Click += new System.EventHandler(this.BtnWeer_Click);
            // 
            // BtnListContract
            // 
            this.BtnListContract.Location = new System.Drawing.Point(93, 12);
            this.BtnListContract.Name = "BtnListContract";
            this.BtnListContract.Size = new System.Drawing.Size(94, 23);
            this.BtnListContract.TabIndex = 1;
            this.BtnListContract.Text = "Huurcontracten";
            this.BtnListContract.UseVisualStyleBackColor = true;
            this.BtnListContract.Click += new System.EventHandler(this.BtnListContract_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Enabled = false;
            this.BtnAdmin.Location = new System.Drawing.Point(303, 12);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(75, 23);
            this.BtnAdmin.TabIndex = 2;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boten";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NudMeren);
            this.groupBox1.Controls.Add(this.BtnMeren);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbNaam);
            this.groupBox1.Controls.Add(this.BtnZeeToevoegen);
            this.groupBox1.Controls.Add(this.CbZee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpTot);
            this.groupBox1.Controls.Add(this.BtnPeriode);
            this.groupBox1.Controls.Add(this.DtpVan);
            this.groupBox1.Controls.Add(this.GbHuidigeBestelling);
            this.groupBox1.Controls.Add(this.NudProducten);
            this.groupBox1.Controls.Add(this.BtnProductToevoegen);
            this.groupBox1.Controls.Add(this.CbProducten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnBootToevoegen);
            this.groupBox1.Controls.Add(this.CbBoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 422);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verhuren";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Meren";
            // 
            // NudMeren
            // 
            this.NudMeren.Location = new System.Drawing.Point(195, 184);
            this.NudMeren.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NudMeren.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMeren.Name = "NudMeren";
            this.NudMeren.Size = new System.Drawing.Size(73, 20);
            this.NudMeren.TabIndex = 25;
            this.NudMeren.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnMeren
            // 
            this.BtnMeren.Enabled = false;
            this.BtnMeren.Location = new System.Drawing.Point(274, 181);
            this.BtnMeren.Name = "BtnMeren";
            this.BtnMeren.Size = new System.Drawing.Size(75, 23);
            this.BtnMeren.TabIndex = 24;
            this.BtnMeren.Text = "Selecteren";
            this.BtnMeren.UseVisualStyleBackColor = true;
            this.BtnMeren.Click += new System.EventHandler(this.BtnMeren_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(217, 71);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 20);
            this.TbEmail.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Naam";
            // 
            // TbNaam
            // 
            this.TbNaam.Location = new System.Drawing.Point(68, 71);
            this.TbNaam.Name = "TbNaam";
            this.TbNaam.Size = new System.Drawing.Size(100, 20);
            this.TbNaam.TabIndex = 20;
            // 
            // BtnZeeToevoegen
            // 
            this.BtnZeeToevoegen.Enabled = false;
            this.BtnZeeToevoegen.Location = new System.Drawing.Point(275, 98);
            this.BtnZeeToevoegen.Name = "BtnZeeToevoegen";
            this.BtnZeeToevoegen.Size = new System.Drawing.Size(75, 23);
            this.BtnZeeToevoegen.TabIndex = 19;
            this.BtnZeeToevoegen.Text = "Toevoegen";
            this.BtnZeeToevoegen.UseVisualStyleBackColor = true;
            this.BtnZeeToevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbZee
            // 
            this.CbZee.FormattingEnabled = true;
            this.CbZee.Items.AddRange(new object[] {
            "Waddenzee",
            "Ijsselmeer",
            "Noordzee"});
            this.CbZee.Location = new System.Drawing.Point(68, 95);
            this.CbZee.Name = "CbZee";
            this.CbZee.Size = new System.Drawing.Size(121, 21);
            this.CbZee.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Zee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Van:";
            // 
            // DtpTot
            // 
            this.DtpTot.Location = new System.Drawing.Point(69, 45);
            this.DtpTot.Name = "DtpTot";
            this.DtpTot.Size = new System.Drawing.Size(200, 20);
            this.DtpTot.TabIndex = 14;
            // 
            // BtnPeriode
            // 
            this.BtnPeriode.Location = new System.Drawing.Point(274, 22);
            this.BtnPeriode.Name = "BtnPeriode";
            this.BtnPeriode.Size = new System.Drawing.Size(77, 43);
            this.BtnPeriode.TabIndex = 13;
            this.BtnPeriode.Text = "Open Huurcontract";
            this.BtnPeriode.UseVisualStyleBackColor = true;
            this.BtnPeriode.Click += new System.EventHandler(this.BtnPeriode_Click);
            // 
            // DtpVan
            // 
            this.DtpVan.Location = new System.Drawing.Point(69, 19);
            this.DtpVan.Name = "DtpVan";
            this.DtpVan.Size = new System.Drawing.Size(200, 20);
            this.DtpVan.TabIndex = 12;
            // 
            // GbHuidigeBestelling
            // 
            this.GbHuidigeBestelling.Controls.Add(this.LbBestelling);
            this.GbHuidigeBestelling.Controls.Add(this.BtnLegen);
            this.GbHuidigeBestelling.Controls.Add(this.BtnVerhuren);
            this.GbHuidigeBestelling.Enabled = false;
            this.GbHuidigeBestelling.Location = new System.Drawing.Point(9, 210);
            this.GbHuidigeBestelling.Name = "GbHuidigeBestelling";
            this.GbHuidigeBestelling.Size = new System.Drawing.Size(351, 206);
            this.GbHuidigeBestelling.TabIndex = 11;
            this.GbHuidigeBestelling.TabStop = false;
            this.GbHuidigeBestelling.Text = "Huidige Bestelling";
            // 
            // LbBestelling
            // 
            this.LbBestelling.FormattingEnabled = true;
            this.LbBestelling.Location = new System.Drawing.Point(6, 19);
            this.LbBestelling.Name = "LbBestelling";
            this.LbBestelling.Size = new System.Drawing.Size(255, 186);
            this.LbBestelling.TabIndex = 15;
            // 
            // BtnLegen
            // 
            this.BtnLegen.Location = new System.Drawing.Point(268, 177);
            this.BtnLegen.Name = "BtnLegen";
            this.BtnLegen.Size = new System.Drawing.Size(75, 23);
            this.BtnLegen.TabIndex = 13;
            this.BtnLegen.Text = "Verwijderen";
            this.BtnLegen.UseVisualStyleBackColor = true;
            this.BtnLegen.Click += new System.EventHandler(this.BtnLegen_Click);
            // 
            // BtnVerhuren
            // 
            this.BtnVerhuren.Location = new System.Drawing.Point(267, 19);
            this.BtnVerhuren.Name = "BtnVerhuren";
            this.BtnVerhuren.Size = new System.Drawing.Size(75, 23);
            this.BtnVerhuren.TabIndex = 11;
            this.BtnVerhuren.Text = "Verhuren";
            this.BtnVerhuren.UseVisualStyleBackColor = true;
            this.BtnVerhuren.Click += new System.EventHandler(this.BtnVerhuren_Click);
            // 
            // NudProducten
            // 
            this.NudProducten.Location = new System.Drawing.Point(195, 150);
            this.NudProducten.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudProducten.Name = "NudProducten";
            this.NudProducten.Size = new System.Drawing.Size(73, 20);
            this.NudProducten.TabIndex = 9;
            this.NudProducten.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnProductToevoegen
            // 
            this.BtnProductToevoegen.Enabled = false;
            this.BtnProductToevoegen.Location = new System.Drawing.Point(274, 147);
            this.BtnProductToevoegen.Name = "BtnProductToevoegen";
            this.BtnProductToevoegen.Size = new System.Drawing.Size(75, 23);
            this.BtnProductToevoegen.TabIndex = 8;
            this.BtnProductToevoegen.Text = "Toevoegen";
            this.BtnProductToevoegen.UseVisualStyleBackColor = true;
            this.BtnProductToevoegen.Click += new System.EventHandler(this.BtnProductToevoegen_Click);
            // 
            // CbProducten
            // 
            this.CbProducten.FormattingEnabled = true;
            this.CbProducten.Location = new System.Drawing.Point(68, 149);
            this.CbProducten.Name = "CbProducten";
            this.CbProducten.Size = new System.Drawing.Size(121, 21);
            this.CbProducten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producten";
            // 
            // BtnBootToevoegen
            // 
            this.BtnBootToevoegen.Enabled = false;
            this.BtnBootToevoegen.Location = new System.Drawing.Point(275, 122);
            this.BtnBootToevoegen.Name = "BtnBootToevoegen";
            this.BtnBootToevoegen.Size = new System.Drawing.Size(75, 23);
            this.BtnBootToevoegen.TabIndex = 5;
            this.BtnBootToevoegen.Text = "Toevoegen";
            this.BtnBootToevoegen.UseVisualStyleBackColor = true;
            this.BtnBootToevoegen.Click += new System.EventHandler(this.BtnBootToevoegen_Click);
            // 
            // CbBoten
            // 
            this.CbBoten.FormattingEnabled = true;
            this.CbBoten.Location = new System.Drawing.Point(68, 122);
            this.CbBoten.Name = "CbBoten";
            this.CbBoten.Size = new System.Drawing.Size(121, 21);
            this.CbBoten.TabIndex = 4;
            // 
            // BtnBerekenen
            // 
            this.BtnBerekenen.Location = new System.Drawing.Point(189, 12);
            this.BtnBerekenen.Name = "BtnBerekenen";
            this.BtnBerekenen.Size = new System.Drawing.Size(75, 23);
            this.BtnBerekenen.TabIndex = 12;
            this.BtnBerekenen.Text = "Berekenen";
            this.BtnBerekenen.UseVisualStyleBackColor = true;
            this.BtnBerekenen.Click += new System.EventHandler(this.BtnBerekenen_Click);
            // 
            // HoofdschermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnListContract);
            this.Controls.Add(this.BtnBerekenen);
            this.Controls.Add(this.BtnWeer);
            this.Name = "HoofdschermForm";
            this.Text = "Verhuren";
            this.Load += new System.EventHandler(this.HoofdschermForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeren)).EndInit();
            this.GbHuidigeBestelling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudProducten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnWeer;
        private System.Windows.Forms.Button BtnListContract;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbProducten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBootToevoegen;
        private System.Windows.Forms.ComboBox CbBoten;
        private System.Windows.Forms.GroupBox GbHuidigeBestelling;
        private System.Windows.Forms.Button BtnVerhuren;
        private System.Windows.Forms.Button BtnLegen;
        private System.Windows.Forms.Button BtnBerekenen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTot;
        private System.Windows.Forms.Button BtnPeriode;
        private System.Windows.Forms.DateTimePicker DtpVan;
        private System.Windows.Forms.Button BtnZeeToevoegen;
        private System.Windows.Forms.ComboBox CbZee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbBestelling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbNaam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudMeren;
        private System.Windows.Forms.Button BtnMeren;
        private System.Windows.Forms.NumericUpDown NudProducten;
        private System.Windows.Forms.Button BtnProductToevoegen;
    }
}

