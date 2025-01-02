namespace stok_programi
{
    partial class transactionForm
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
            this.components = new System.ComponentModel.Container();
            this.cikis = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f_tutar = new System.Windows.Forms.TextBox();
            this.f_miktar = new System.Windows.Forms.TextBox();
            this.f_sat_fiyat = new System.Windows.Forms.TextBox();
            this.f_al_fiyat = new System.Windows.Forms.TextBox();
            this.f_saat = new System.Windows.Forms.TextBox();
            this.f_tarih = new System.Windows.Forms.TextBox();
            this.f_urun_combo = new System.Windows.Forms.ComboBox();
            this.f_musteri_combo = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.s_u_adet = new System.Windows.Forms.Label();
            this.s_urun_a = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(691, 434);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(192, 48);
            this.cikis.TabIndex = 31;
            this.cikis.Text = "Exit";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(251, 434);
            this.kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(187, 48);
            this.kaydet.TabIndex = 30;
            this.kaydet.Text = "Save";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(501, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(501, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Amount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(501, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sale Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(501, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Purchase Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date:";
            // 
            // f_tutar
            // 
            this.f_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_tutar.Location = new System.Drawing.Point(715, 348);
            this.f_tutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_tutar.Name = "f_tutar";
            this.f_tutar.Size = new System.Drawing.Size(191, 38);
            this.f_tutar.TabIndex = 23;
            // 
            // f_miktar
            // 
            this.f_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_miktar.Location = new System.Drawing.Point(715, 265);
            this.f_miktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_miktar.Name = "f_miktar";
            this.f_miktar.Size = new System.Drawing.Size(191, 38);
            this.f_miktar.TabIndex = 22;
            this.f_miktar.TextChanged += new System.EventHandler(this.f_miktar_TextChanged);
            // 
            // f_sat_fiyat
            // 
            this.f_sat_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_sat_fiyat.Location = new System.Drawing.Point(715, 94);
            this.f_sat_fiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_sat_fiyat.Name = "f_sat_fiyat";
            this.f_sat_fiyat.Size = new System.Drawing.Size(191, 38);
            this.f_sat_fiyat.TabIndex = 21;
            this.f_sat_fiyat.TextChanged += new System.EventHandler(this.f_sat_fiyat_TextChanged);
            // 
            // f_al_fiyat
            // 
            this.f_al_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_al_fiyat.Location = new System.Drawing.Point(715, 13);
            this.f_al_fiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_al_fiyat.Name = "f_al_fiyat";
            this.f_al_fiyat.Size = new System.Drawing.Size(191, 38);
            this.f_al_fiyat.TabIndex = 20;
            this.f_al_fiyat.TextChanged += new System.EventHandler(this.f_al_fiyat_TextChanged);
            // 
            // f_saat
            // 
            this.f_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_saat.Location = new System.Drawing.Point(209, 348);
            this.f_saat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_saat.Name = "f_saat";
            this.f_saat.Size = new System.Drawing.Size(227, 38);
            this.f_saat.TabIndex = 19;
            // 
            // f_tarih
            // 
            this.f_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_tarih.Location = new System.Drawing.Point(209, 265);
            this.f_tarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_tarih.Name = "f_tarih";
            this.f_tarih.Size = new System.Drawing.Size(227, 38);
            this.f_tarih.TabIndex = 18;
            // 
            // f_urun_combo
            // 
            this.f_urun_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_urun_combo.FormattingEnabled = true;
            this.f_urun_combo.Location = new System.Drawing.Point(57, 107);
            this.f_urun_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_urun_combo.Name = "f_urun_combo";
            this.f_urun_combo.Size = new System.Drawing.Size(379, 39);
            this.f_urun_combo.TabIndex = 17;
            this.f_urun_combo.Text = "Select Product";
            this.f_urun_combo.SelectedIndexChanged += new System.EventHandler(this.f_urun_combo_SelectedIndexChanged);
            // 
            // f_musteri_combo
            // 
            this.f_musteri_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f_musteri_combo.FormattingEnabled = true;
            this.f_musteri_combo.Location = new System.Drawing.Point(56, 26);
            this.f_musteri_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_musteri_combo.Name = "f_musteri_combo";
            this.f_musteri_combo.Size = new System.Drawing.Size(380, 39);
            this.f_musteri_combo.TabIndex = 16;
            this.f_musteri_combo.Text = "Select Customer";
            this.f_musteri_combo.SelectedIndexChanged += new System.EventHandler(this.f_musteri_combo_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // s_u_adet
            // 
            this.s_u_adet.AutoSize = true;
            this.s_u_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.s_u_adet.Location = new System.Drawing.Point(406, 190);
            this.s_u_adet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s_u_adet.Name = "s_u_adet";
            this.s_u_adet.Size = new System.Drawing.Size(367, 31);
            this.s_u_adet.TabIndex = 32;
            this.s_u_adet.Text = "Number of Products in Stock:";
            this.s_u_adet.Visible = false;
            // 
            // s_urun_a
            // 
            this.s_urun_a.AutoSize = true;
            this.s_urun_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.s_urun_a.Location = new System.Drawing.Point(791, 190);
            this.s_urun_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s_urun_a.Name = "s_urun_a";
            this.s_urun_a.Size = new System.Drawing.Size(29, 31);
            this.s_urun_a.TabIndex = 34;
            this.s_urun_a.Text = "0";
            this.s_urun_a.Visible = false;
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 511);
            this.Controls.Add(this.s_urun_a);
            this.Controls.Add(this.s_u_adet);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f_tutar);
            this.Controls.Add(this.f_miktar);
            this.Controls.Add(this.f_sat_fiyat);
            this.Controls.Add(this.f_al_fiyat);
            this.Controls.Add(this.f_saat);
            this.Controls.Add(this.f_tarih);
            this.Controls.Add(this.f_urun_combo);
            this.Controls.Add(this.f_musteri_combo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "transactionForm";
            this.Text = "Transaction Form";
            this.Load += new System.EventHandler(this.islem_formu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f_tutar;
        private System.Windows.Forms.TextBox f_miktar;
        private System.Windows.Forms.TextBox f_sat_fiyat;
        private System.Windows.Forms.TextBox f_al_fiyat;
        private System.Windows.Forms.TextBox f_saat;
        private System.Windows.Forms.TextBox f_tarih;
        private System.Windows.Forms.ComboBox f_urun_combo;
        private System.Windows.Forms.ComboBox f_musteri_combo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label s_u_adet;
        private System.Windows.Forms.Label s_urun_a;
    }
}