namespace LPWF.GUI.WinForms
{
    partial class BerekenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudBoten = new System.Windows.Forms.NumericUpDown();
            this.NudMotor = new System.Windows.Forms.NumericUpDown();
            this.NudZeeen = new System.Windows.Forms.NumericUpDown();
            this.NudProducten = new System.Windows.Forms.NumericUpDown();
            this.NudBedrag = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBerekenen = new System.Windows.Forms.Button();
            this.NudKanos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NudDagen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudBoten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudZeeen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProducten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBedrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudKanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zeilboten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motorboten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zeeen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bedrag";
            // 
            // NudBoten
            // 
            this.NudBoten.Location = new System.Drawing.Point(152, 40);
            this.NudBoten.Name = "NudBoten";
            this.NudBoten.Size = new System.Drawing.Size(120, 20);
            this.NudBoten.TabIndex = 4;
            // 
            // NudMotor
            // 
            this.NudMotor.Location = new System.Drawing.Point(152, 67);
            this.NudMotor.Name = "NudMotor";
            this.NudMotor.Size = new System.Drawing.Size(120, 20);
            this.NudMotor.TabIndex = 5;
            // 
            // NudZeeen
            // 
            this.NudZeeen.Location = new System.Drawing.Point(152, 93);
            this.NudZeeen.Name = "NudZeeen";
            this.NudZeeen.Size = new System.Drawing.Size(120, 20);
            this.NudZeeen.TabIndex = 6;
            // 
            // NudProducten
            // 
            this.NudProducten.Location = new System.Drawing.Point(152, 119);
            this.NudProducten.Name = "NudProducten";
            this.NudProducten.Size = new System.Drawing.Size(120, 20);
            this.NudProducten.TabIndex = 7;
            // 
            // NudBedrag
            // 
            this.NudBedrag.DecimalPlaces = 2;
            this.NudBedrag.Location = new System.Drawing.Point(152, 145);
            this.NudBedrag.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudBedrag.Name = "NudBedrag";
            this.NudBedrag.Size = new System.Drawing.Size(120, 20);
            this.NudBedrag.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Producten";
            // 
            // BtnBerekenen
            // 
            this.BtnBerekenen.Location = new System.Drawing.Point(197, 210);
            this.BtnBerekenen.Name = "BtnBerekenen";
            this.BtnBerekenen.Size = new System.Drawing.Size(75, 23);
            this.BtnBerekenen.TabIndex = 10;
            this.BtnBerekenen.Text = "Berekenen";
            this.BtnBerekenen.UseVisualStyleBackColor = true;
            this.BtnBerekenen.Click += new System.EventHandler(this.BtnBerekenen_Click);
            // 
            // NudKanos
            // 
            this.NudKanos.Location = new System.Drawing.Point(152, 12);
            this.NudKanos.Name = "NudKanos";
            this.NudKanos.Size = new System.Drawing.Size(120, 20);
            this.NudKanos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kano\'s";
            // 
            // NudDagen
            // 
            this.NudDagen.Location = new System.Drawing.Point(154, 176);
            this.NudDagen.Name = "NudDagen";
            this.NudDagen.Size = new System.Drawing.Size(120, 20);
            this.NudDagen.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dagen";
            // 
            // BerekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.NudDagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudKanos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBerekenen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudBedrag);
            this.Controls.Add(this.NudProducten);
            this.Controls.Add(this.NudZeeen);
            this.Controls.Add(this.NudMotor);
            this.Controls.Add(this.NudBoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BerekenForm";
            this.Text = "Berekenen";
            ((System.ComponentModel.ISupportInitialize)(this.NudBoten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudZeeen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProducten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBedrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudKanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudBoten;
        private System.Windows.Forms.NumericUpDown NudMotor;
        private System.Windows.Forms.NumericUpDown NudZeeen;
        private System.Windows.Forms.NumericUpDown NudProducten;
        private System.Windows.Forms.NumericUpDown NudBedrag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBerekenen;
        private System.Windows.Forms.NumericUpDown NudKanos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudDagen;
        private System.Windows.Forms.Label label7;
    }
}