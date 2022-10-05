namespace Latihan_1
{
    partial class Form1
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbTidak = new System.Windows.Forms.RadioButton();
            this.cbSop = new System.Windows.Forms.CheckBox();
            this.cbRica = new System.Windows.Forms.CheckBox();
            this.cbEsTeh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSop = new System.Windows.Forms.TextBox();
            this.txtRica = new System.Windows.Forms.TextBox();
            this.txtEsTeh = new System.Windows.Forms.TextBox();
            this.btHitung = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELANGGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MENU PILIHAN :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(146, 29);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(207, 20);
            this.txtNama.TabIndex = 3;
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(146, 64);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(39, 17);
            this.rbYa.TabIndex = 4;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "YA";
            this.rbYa.UseVisualStyleBackColor = true;
            // 
            // rbTidak
            // 
            this.rbTidak.AutoSize = true;
            this.rbTidak.Location = new System.Drawing.Point(208, 64);
            this.rbTidak.Name = "rbTidak";
            this.rbTidak.Size = new System.Drawing.Size(57, 17);
            this.rbTidak.TabIndex = 5;
            this.rbTidak.TabStop = true;
            this.rbTidak.Text = "TIDAK";
            this.rbTidak.UseVisualStyleBackColor = true;
            // 
            // cbSop
            // 
            this.cbSop.AutoSize = true;
            this.cbSop.Location = new System.Drawing.Point(54, 133);
            this.cbSop.Name = "cbSop";
            this.cbSop.Size = new System.Drawing.Size(137, 17);
            this.cbSop.TabIndex = 6;
            this.cbSop.Text = "SOP AYAM [Rp. 9.000]";
            this.cbSop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSop.UseVisualStyleBackColor = true;
            this.cbSop.CheckedChanged += new System.EventHandler(this.cbSop_CheckedChanged);
            // 
            // cbRica
            // 
            this.cbRica.AutoSize = true;
            this.cbRica.Location = new System.Drawing.Point(54, 156);
            this.cbRica.Name = "cbRica";
            this.cbRica.Size = new System.Drawing.Size(168, 17);
            this.cbRica.TabIndex = 7;
            this.cbRica.Text = "AYAM RICA-RICA [Rp. 8.500]";
            this.cbRica.UseVisualStyleBackColor = true;
            this.cbRica.CheckedChanged += new System.EventHandler(this.cbAyam_CheckedChanged);
            // 
            // cbEsTeh
            // 
            this.cbEsTeh.AutoSize = true;
            this.cbEsTeh.Location = new System.Drawing.Point(54, 179);
            this.cbEsTeh.Name = "cbEsTeh";
            this.cbEsTeh.Size = new System.Drawing.Size(158, 17);
            this.cbEsTeh.TabIndex = 8;
            this.cbEsTeh.Text = "ES TEH MANIS [Rp. 2.000]";
            this.cbEsTeh.UseVisualStyleBackColor = true;
            this.cbEsTeh.CheckedChanged += new System.EventHandler(this.cbEsTeh_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "JUMLAH";
            // 
            // txtSop
            // 
            this.txtSop.Location = new System.Drawing.Point(249, 131);
            this.txtSop.Name = "txtSop";
            this.txtSop.Size = new System.Drawing.Size(72, 20);
            this.txtSop.TabIndex = 10;
            // 
            // txtRica
            // 
            this.txtRica.Location = new System.Drawing.Point(249, 154);
            this.txtRica.Name = "txtRica";
            this.txtRica.Size = new System.Drawing.Size(72, 20);
            this.txtRica.TabIndex = 11;
            // 
            // txtEsTeh
            // 
            this.txtEsTeh.Location = new System.Drawing.Point(249, 176);
            this.txtEsTeh.Name = "txtEsTeh";
            this.txtEsTeh.Size = new System.Drawing.Size(72, 20);
            this.txtEsTeh.TabIndex = 12;
            // 
            // btHitung
            // 
            this.btHitung.Location = new System.Drawing.Point(35, 213);
            this.btHitung.Name = "btHitung";
            this.btHitung.Size = new System.Drawing.Size(317, 27);
            this.btHitung.TabIndex = 13;
            this.btHitung.Text = "HITUNG";
            this.btHitung.UseVisualStyleBackColor = true;
            this.btHitung.Click += new System.EventHandler(this.btHitung_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOTAL Rp.";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(236, 254);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 295);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btHitung);
            this.Controls.Add(this.txtEsTeh);
            this.Controls.Add(this.txtRica);
            this.Controls.Add(this.txtSop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEsTeh);
            this.Controls.Add(this.cbRica);
            this.Controls.Add(this.cbSop);
            this.Controls.Add(this.rbTidak);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rumah Makan Waras Wareg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton rbTidak;
        private System.Windows.Forms.CheckBox cbSop;
        private System.Windows.Forms.CheckBox cbRica;
        private System.Windows.Forms.CheckBox cbEsTeh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSop;
        private System.Windows.Forms.TextBox txtRica;
        private System.Windows.Forms.TextBox txtEsTeh;
        private System.Windows.Forms.Button btHitung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

